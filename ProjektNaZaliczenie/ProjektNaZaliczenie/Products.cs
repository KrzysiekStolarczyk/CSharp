using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
namespace ProjektNaZaliczenie
{
    public partial class Products : Form
    {

        string valuefromTextBox = string.Empty;
        string productName;
        string productPrice;
        string idProduct;

        Stack<string> zmienneInSql = new Stack<string>();
        Stack<SqlDbType> sqlType = new Stack<SqlDbType>();
        Stack<string> valueToSql = new Stack<string>();

        ConnectingString handlerToDataBase = new ConnectingString();
        SharedMethods sharedMethod = new SharedMethods();

        public Products()
        {
            InitializeComponent();
            ShowDataOnTable();
            startDefaultTextBox();
        }

        public void ShowDataOnTable()
        {
            dataGridViewProducts.DataSource = handlerToDataBase.localDbConnection.ExecuteSqlQuery("select * from DotNet.Dbo.Products");

            sharedMethod.SettingsDataGrid(dataGridViewProducts);
        }

        public void AddParametrsToStack(string sqlVariable, SqlDbType type, string value)
        {
            zmienneInSql.Push(sqlVariable);
            sqlType.Push(type);
            valueToSql.Push(value);
        }

        public void AddNewProduct()
        {
            productName = textBoxNameProductNew.Text;
            productPrice = textBoxPriceProductNew.Text;
            string procedureName = "[dbo].[AddProduct]";

            AddParametrsToStack("@ProductName", SqlDbType.VarChar, productName);
            AddParametrsToStack("@UnitPrice", SqlDbType.Money, productPrice);

            int result = handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalar(procedureName, zmienneInSql, sqlType, valueToSql);

            ShowDataOnTable();
            textBoxNameProductNew.Clear();
            textBoxPriceProductNew.Clear();
            startDefaultTextBox();
            MessageBox.Show(result == 1 ? "Operacja wykonana poprawnie." : "Błąd po stronie bazy.");
        }

        public void DeleteProduct()
        {
            idProduct = dataGridViewProducts.SelectedRows[0].Cells[0].Value.ToString();
            string procedureName = "[dbo].[DeleteProduct]";

            AddParametrsToStack("@idProduct", SqlDbType.Int, idProduct);

            int result = handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalar(procedureName, zmienneInSql, sqlType, valueToSql);

            ShowDataOnTable();
            startDefaultTextBox();
            MessageBox.Show(result == 1 ? "Operacja wykonana poprawnie." : "Błąd po stronie bazy.");
        }

        public void EditProduct()
        {
            productName = textBoxNameProductEdit.Text;
            productPrice = textBoxPriceProductEdit.Text;
            idProduct = dataGridViewProducts.SelectedRows[0].Cells[0].Value.ToString();
            string procedureName = "[dbo].[EditProduct]";

            AddParametrsToStack("@ProductName", SqlDbType.VarChar, productName);
            AddParametrsToStack("@UnitPrice", SqlDbType.Money, productPrice);
            AddParametrsToStack("@idProduct", SqlDbType.Int, idProduct);

            int result = handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalar(procedureName, zmienneInSql, sqlType, valueToSql);

            ShowDataOnTable();
            textBoxNameProductEdit.Clear();
            textBoxPriceProductEdit.Clear();
            startDefaultTextBox();
            MessageBox.Show(result == 1 ? "Operacja wykonana poprawnie." : "Błąd po stronie bazy.");
        }

        public void startDefaultTextBox()
        {
            sharedMethod.SetDefaultValueToTextBox(textBoxNameProductNew, "!Wprowadź nazwę nowego produktu");
            sharedMethod.SetDefaultValueToTextBox(textBoxPriceProductNew, "!Wprowadź cenę nowego produktu");
            sharedMethod.SetDefaultValueToTextBox(textBoxNameProductEdit, "!Wprowadź nową nazwę produktu");
            sharedMethod.SetDefaultValueToTextBox(textBoxPriceProductEdit, "!Wprowadź nową cenę produktu");
        }

        public void textBoxDefaultValues(object sender, EventArgs e)
        {
            startDefaultTextBox();
        }

        public void textBoxClick(object sender, EventArgs e)
        {
            TextBox textBoxx = (TextBox)sender;
            textBoxx.Clear();
            textBoxx.ForeColor = SystemColors.WindowText;
        }

        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            if(sharedMethod.CheckSelectedRowOnGrid(dataGridViewProducts) == 1 && sharedMethod.CheckEnteredTextBox(textBoxNameProductNew) == 1 && sharedMethod.CheckEnteredTextBox(textBoxPriceProductNew) == 1)
            {
                AddNewProduct();
            }
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {

            if (sharedMethod.CheckSelectedRowOnGrid(dataGridViewProducts)==1 && sharedMethod.CheckEnteredTextBox(textBoxNameProductEdit)==1 && sharedMethod.CheckEnteredTextBox(textBoxPriceProductEdit) == 1)
                EditProduct();
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (sharedMethod.CheckSelectedRowOnGrid(dataGridViewProducts) == 1)
            {
                DeleteProduct();
            }
        }
    }
}

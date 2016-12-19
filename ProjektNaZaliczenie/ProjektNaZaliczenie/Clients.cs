using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
namespace ProjektNaZaliczenie
{
    public partial class Clients : Form
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

        public Clients()
        {
            InitializeComponent();
            ShowDataOnTable();
            startDefaultTextBox();
        }

        public void ShowDataOnTable()
        {
            dataGridViewClients.DataSource = handlerToDataBase.localDbConnection.ExecuteSqlQuery("select * from [DotNet].[dbo].[Client]");

            sharedMethod.SettingsDataGrid(dataGridViewClients);
            dataGridViewClients.Columns[0].Width = 50;
            dataGridViewClients.Columns[1].Width = 70;
            dataGridViewClients.Columns[2].Width = 70;
            dataGridViewClients.Columns[3].Width = 160;
            dataGridViewClients.Columns[4].Width = 60;
            dataGridViewClients.Columns[5].Width = 60;
            dataGridViewClients.Columns[6].Width = 60;
            dataGridViewClients.Columns[7].Width = 80;
        }

        public void AddParametrsToStack(string sqlVariable, SqlDbType type, string value)
        {
            zmienneInSql.Push(sqlVariable);
            sqlType.Push(type);
            valueToSql.Push(value);
        }

        public void AddNewProduct()
        {
            productName = textBoxLastNameClientNew.Text;
            productPrice = textBoxFirstNameClientNew.Text;
            string procedureName = "[dbo].[AddProduct]";

            AddParametrsToStack("@ProductName", SqlDbType.VarChar, productName);
            AddParametrsToStack("@UnitPrice", SqlDbType.Money, productPrice);

            int result = handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalar(procedureName, zmienneInSql, sqlType, valueToSql);

            ShowDataOnTable();
            textBoxLastNameClientNew.Clear();
            textBoxFirstNameClientNew.Clear();
            startDefaultTextBox();
            MessageBox.Show(result == 1 ? "Operacja wykonana poprawnie." : "Błąd po stronie bazy.");
        }

        public void DeleteProduct()
        {
            idProduct = dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString();
            string procedureName = "[dbo].[DeleteProduct]";

            AddParametrsToStack("@idProduct", SqlDbType.Int, idProduct);

            int result = handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalar(procedureName, zmienneInSql, sqlType, valueToSql);

            ShowDataOnTable();
            startDefaultTextBox();
            MessageBox.Show(result == 1 ? "Operacja wykonana poprawnie." : "Błąd po stronie bazy.");
        }

        public void EditProduct()
        {
            //productName = textBoxNameProductEdit.Text;
            //productPrice = textBoxPriceProductEdit.Text;
            idProduct = dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString();
            string procedureName = "[dbo].[EditProduct]";

            AddParametrsToStack("@ProductName", SqlDbType.VarChar, productName);
            AddParametrsToStack("@UnitPrice", SqlDbType.Money, productPrice);
            AddParametrsToStack("@idProduct", SqlDbType.Int, idProduct);

            int result = handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalar(procedureName, zmienneInSql, sqlType, valueToSql);

            ShowDataOnTable();
            //textBoxNameProductEdit.Clear();
            //textBoxPriceProductEdit.Clear();
            startDefaultTextBox();
            MessageBox.Show(result == 1 ? "Operacja wykonana poprawnie." : "Błąd po stronie bazy.");
        }

        public void startDefaultTextBox()
        {
            sharedMethod.SetDefaultValueToTextBox(textBoxLastNameClientNew, "!Wprowadź nazwę nowego produktu");
            sharedMethod.SetDefaultValueToTextBox(textBoxFirstNameClientNew, "!Wprowadź cenę nowego produktu");
            //sharedMethod.SetDefaultValueToTextBox(textBoxNameProductEdit, "!Wprowadź nową nazwę produktu");
            //sharedMethod.SetDefaultValueToTextBox(textBoxPriceProductEdit, "!Wprowadź nową cenę produktu");
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
            if(sharedMethod.CheckSelectedRowOnGrid(dataGridViewClients) == 1 && sharedMethod.CheckEnteredTextBox(textBoxLastNameClientNew) == 1 && sharedMethod.CheckEnteredTextBox(textBoxFirstNameClientNew) == 1)
            {
                AddNewProduct();
            }
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {

            //if (sharedMethod.CheckSelectedRowOnGrid(dataGridViewClients)==1 && sharedMethod.CheckEnteredTextBox(textBoxNameProductEdit)==1 && sharedMethod.CheckEnteredTextBox(textBoxPriceProductEdit) == 1)
            //    EditProduct();
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (sharedMethod.CheckSelectedRowOnGrid(dataGridViewClients) == 1)
            {
                DeleteProduct();
            }
        }
    }
}

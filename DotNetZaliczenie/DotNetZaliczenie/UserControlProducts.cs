using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetZaliczenie
{
    public partial class UserControlProducts : UserControl
    {
        string valuefromTextBox = string.Empty;
        string productName;
        string productPrice;
        string idProduct;
        string producer;
        Stack<string> zmienneInSql = new Stack<string>();
        Stack<SqlDbType> sqlType = new Stack<SqlDbType>();
        Stack<string> valueToSql = new Stack<string>();

        ConnectingString handlerToDataBase = new ConnectingString();
        SharedMethods sharedMethod = new SharedMethods();

        public UserControlProducts()
        {
            InitializeComponent();
            ShowDataOnTable();
            LoadAllComboBox();
        }

        public void AddParametrsToStack(string sqlVariable, SqlDbType type, string value)
        {
            zmienneInSql.Push(sqlVariable);
            sqlType.Push(type);
            valueToSql.Push(value);

        }

        public void ShowDataOnTable()
        {
            dataGridViewProducts.DataSource = handlerToDataBase.localDbConnection.ExecuteSqlQuery("select * from DotNet.dbo.VProducts");

            sharedMethod.SettingsDataGrid(dataGridViewProducts);
        }

        public void LoadAllComboBox()
        {
            DataTable product = new DataTable();
            product = handlerToDataBase.localDbConnection.ExecuteSqlQuery("select distinct Producer from DotNet.Dbo.Products");
            comboBoxName.Text = "Wybierz producenta";
            foreach (DataRow id in product.Rows)
            {
                comboBoxName.Items.Add(id["Producer"]);
            }

            DataTable category = new DataTable();
            product = handlerToDataBase.localDbConnection.ExecuteSqlQuery("select CategoryName from DotNet.Dbo.Categories");
            comboBoxCategory.Text = "Wybierz kategorię";

            foreach (DataRow id in product.Rows)
            {
                comboBoxCategory.Items.Add(id["CategoryName"]);
                comboBoxCategoryEdit.Items.Add(id["CategoryName"]);
                comboBoxCategoryNew.Items.Add(id["CategoryName"]);
            }
        }

        public void AddNewProduct()
        {
            productName = MTBProductNameNew.Text;
            productPrice = MTBProductPriceNew.Text;
            producer = MTBProducerNew.Text;
            string procedureName = "[dbo].[AddProduct]";

            AddParametrsToStack("@ProductName", SqlDbType.VarChar, productName);
            AddParametrsToStack("@UnitPrice", SqlDbType.Money, productPrice);
            AddParametrsToStack("@Producer", SqlDbType.VarChar, producer);
            AddParametrsToStack("@Category", SqlDbType.VarChar, comboBoxCategoryNew.Text);

            int result = handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalar(procedureName, zmienneInSql, sqlType, valueToSql);

            ShowDataOnTable();
            MTBProductNameNew.Clear();
            MTBProductPriceNew.Clear();
            MTBProducerNew.Clear();
            comboBoxCategoryNew.SelectedText= "Wybierz kategorię";
            MessageBox.Show(result == 1 ? "Operacja wykonana poprawnie." : "Błąd po stronie bazy.");
            LoadAllComboBox();//dodane
        }

        public void DeleteProduct()
        {
            idProduct = dataGridViewProducts.SelectedRows[0].Cells[0].Value.ToString();
            string procedureName = "[dbo].[DeleteProduct]";

            AddParametrsToStack("@idProduct", SqlDbType.Int, idProduct);

            int result = handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalar(procedureName, zmienneInSql, sqlType, valueToSql);

            ShowDataOnTable();
            MessageBox.Show(result == 1 ? "Operacja wykonana poprawnie." : "Błąd po stronie bazy.");
        }

        public void EditProduct()
        {
            productName = MTBProductNameEdit.Text;
            productPrice = MTBProductPriceEdit.Text;
            idProduct = dataGridViewProducts.SelectedRows[0].Cells[0].Value.ToString();
            producer = MTBProducerEdit.Text;
            string procedureName = "[dbo].[EditProduct]";

            AddParametrsToStack("@ProductName", SqlDbType.VarChar, productName);
            AddParametrsToStack("@UnitPrice", SqlDbType.Money, productPrice);
            AddParametrsToStack("@idProduct", SqlDbType.Int, idProduct);
            AddParametrsToStack("@Producer", SqlDbType.VarChar, producer);
            AddParametrsToStack("@Category", SqlDbType.VarChar, comboBoxCategoryEdit.Text);

            int result = handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalar(procedureName, zmienneInSql, sqlType, valueToSql);

            ShowDataOnTable();
            MTBProductNameEdit.Clear();
            MTBProductPriceEdit.Clear();
            MTBProducerEdit.Clear();
            comboBoxCategoryEdit.SelectedText = "Wybierz kategorię";
            MessageBox.Show(result == 1 ? "Operacja wykonana poprawnie." : "Błąd po stronie bazy.");
        }

        public void textBoxClick(object sender, EventArgs e)
        {
            TextBox textBoxx = (TextBox)sender;
            textBoxx.Clear();
            textBoxx.ForeColor = SystemColors.WindowText;
        }

        private void buttonAddNewProduct_Click(object sender, EventArgs e)
        {
            AddNewProduct();
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {

            if (sharedMethod.CheckSelectedRowOnGrid(dataGridViewProducts) == 1)
            {
                EditProduct();
            }
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (sharedMethod.CheckSelectedRowOnGrid(dataGridViewProducts) == 1)
            {
                DeleteProduct();
            }
        }
        public void textBoxValueStockValid(object sender, EventArgs e)
        {
            sharedMethod.MaskedTextBoxSetCursor(sender, e);
        }

        private void buttonfiltrName_Click(object sender, EventArgs e)
        {
            dataGridViewProducts.DataSource = handlerToDataBase.localDbConnection.ExecuteSqlQuery("select * from DotNet.dbo.VProducts where Producer='" + comboBoxName.Text + "'");
        }

        private void buttonFirltrCat_Click(object sender, EventArgs e)
        {
            dataGridViewProducts.DataSource = handlerToDataBase.localDbConnection.ExecuteSqlQuery("select * from DotNet.dbo.VProducts where CategoryName='" + comboBoxCategory.Text + "'");
        }
    }
}

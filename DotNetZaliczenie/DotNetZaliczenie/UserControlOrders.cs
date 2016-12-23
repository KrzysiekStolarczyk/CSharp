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
    public partial class UserControlOrders : UserControl
    {
        string selectedProduct;
        int maxOrderQuantity;
        string selectedClient;

        ConnectingString handlerToDataBase = new ConnectingString();
        SharedMethods sharedMethod = new SharedMethods();

        Stack<string> zmienneInSql = new Stack<string>();
        Stack<SqlDbType> sqlType = new Stack<SqlDbType>();
        Stack<string> valueToSql = new Stack<string>();

        public UserControlOrders()
        {
            InitializeComponent();
            LoadComboboxProducts();
            LoadComboboxClient();
        }

        public void AddParametrsToStack(string sqlVariable, SqlDbType type, string value)
        {
            zmienneInSql.Push(sqlVariable);
            sqlType.Push(type);
            valueToSql.Push(value);
        }

        public void LoadComboboxProducts()
        {
            DataTable product = new DataTable();
            product = handlerToDataBase.localDbConnection.ExecuteSqlQuery("select ProductName from DotNet.Dbo.Products");
            comboBoxProducts.Text = "Wybierz produkt";
            foreach (DataRow id in product.Rows)
            {
                comboBoxProducts.Items.Add(id["ProductName"]);
            }
        }

        public void LoadComboboxClient()
        {
            DataTable client = new DataTable();
            client = handlerToDataBase.localDbConnection.ExecuteSqlQuery("select LastName from DotNet.Dbo.Client");
            comboBoxClient.Text = "Wybierz klienta";
            foreach (DataRow id in client.Rows)
            {
                comboBoxClient.Items.Add(id["LastName"]);
            }
        }

        public void GetInfoAboutSelectedproduct(object sender, EventArgs e)
        {           
            selectedProduct = comboBoxProducts.Text; 
            comboBoxQuantity.Items.Clear();
            comboBoxQuantity.Text = "Wybierz ilość";
            string query = "select * from DotNet.Dbo.Products where productName='" + selectedProduct + "'";
            maxOrderQuantity = handlerToDataBase.localDbConnection.ExecuteQueryStokScalar(query);

            for (int i = 0; i <= maxOrderQuantity; i++)
            {
                comboBoxQuantity.Items.Add(i);
            }
        }

        public void GetInfoAboutSelectedClient(object sender, EventArgs e)
        {
            selectedClient = comboBoxClient.Text;
            comboBoxQuantity.Items.Clear();         
        }

        public void AddOrder()
        {
            string procedureName = "[dbo].[AddOrder]";

            AddParametrsToStack("@ProductName", SqlDbType.VarChar, selectedProduct);
            AddParametrsToStack("@Client", SqlDbType.Money, selectedClient);
            AddParametrsToStack("@OrderQuantity", SqlDbType.Int, maxOrderQuantity.ToString());

            int result = handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalar(procedureName, zmienneInSql, sqlType, valueToSql);

            ShowDataOnTable();
            MTBProductNameEdit.Clear();
            MTBProductPriceEdit.Clear();
            MessageBox.Show(result == 1 ? "Operacja wykonana poprawnie." : "Błąd po stronie bazy.");
        }

        public void ShowDataOnTable()
        {
            dataGridViewOrders.DataSource = handlerToDataBase.localDbConnection.ExecuteSqlQuery("select * from DotNet.Dbo.Orders");

            sharedMethod.SettingsDataGrid(dataGridViewOrders);
        }

    }

}

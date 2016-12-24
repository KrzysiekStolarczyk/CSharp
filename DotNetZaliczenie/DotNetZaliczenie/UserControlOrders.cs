using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace DotNetZaliczenie
{
    public partial class UserControlOrders : UserControl
    {
        string selectedProduct;
        int maxOrderQuantity;
        string selectedClient;
        string idOrder;
        string folderPath;
        ConnectingString handlerToDataBase = new ConnectingString();
        SharedMethods sharedMethod = new SharedMethods();

        Stack<string> zmienneInSql = new Stack<string>();
        Stack<SqlDbType> sqlType = new Stack<SqlDbType>();
        Stack<string> valueToSql = new Stack<string>();

        public UserControlOrders()
        {
            InitializeComponent();
            LoadComboBoxProducts();
            LoadComboBoxClient();
            ShowDataOnTable();
        }

        public void ShowDataOnTable()
        {
            dataGridViewOrders.DataSource = handlerToDataBase.localDbConnection.ExecuteSqlQuery("select * from DotNet.Dbo.Orders");

            sharedMethod.SettingsDataGrid(dataGridViewOrders);
        }

        public void AddParametrsToStack(string sqlVariable, SqlDbType type, string value)
        {
            zmienneInSql.Push(sqlVariable);
            sqlType.Push(type);
            valueToSql.Push(value);
        }

        public void LoadComboBoxProducts()
        {
            DataTable product = new DataTable();
            product = handlerToDataBase.localDbConnection.ExecuteSqlQuery("select distinct ProductName from DotNet.Dbo.Products");
            comboBoxProducts.Text = "Wybierz produkt";
            comboBoxProductsEdit.Text = "Wybierz produkt";

            foreach (DataRow id in product.Rows)
            {
                comboBoxProducts.Items.Add(id["ProductName"]);
                comboBoxProductsEdit.Items.Add(id["ProductName"]);
            }
        }

        public void LoadComboBoxClient()
        {
            DataTable client = new DataTable();
            client = handlerToDataBase.localDbConnection.ExecuteSqlQuery("select distinct LastName from DotNet.Dbo.Client");
            comboBoxClient.Text = "Wybierz klienta";
            comboBoxClientedit.Text = "Wybierz klienta";

            foreach (DataRow id in client.Rows)
            {
                comboBoxClient.Items.Add(id["LastName"]);
                comboBoxClientedit.Items.Add(id["LastName"]);
            }
        }

        public void GetInfoAboutSelectedProduct(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            selectedProduct = comboBox.Text;

            // comboBoxQuantity.Items.Clear();
            comboBoxQuantity.Text = "Wybierz ilość";
            comboBoxQuantityEdit.Text = "Wybierz ilość";
            string query = "select * from DotNet.Dbo.Products where productName='" + selectedProduct + "'";
            maxOrderQuantity = handlerToDataBase.localDbConnection.ExecuteQueryStokScalar(query);

            for (int i = 0; i <= maxOrderQuantity; i++)
            {
                comboBoxQuantity.Items.Add(i);
                comboBoxQuantityEdit.Items.Add(i);
            }
        }

        public void GetInfoAboutSelectedClient(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            selectedClient = comboBox.Text;
        }

        public void AddOrder()
        {
            string procedureName = "[dbo].[AddOrders]";

            AddParametrsToStack("@ProductName", SqlDbType.VarChar, selectedProduct);
            AddParametrsToStack("@ClientLastName", SqlDbType.VarChar, selectedClient);
            AddParametrsToStack("@OrderQuantity", SqlDbType.Int, maxOrderQuantity.ToString());

            int result = handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalar(procedureName, zmienneInSql, sqlType, valueToSql);

            ShowDataOnTable();
            MessageBox.Show(result == 1 ? "Operacja wykonana poprawnie." : "Błąd po stronie bazy.");
        }

        public void EditOrder()
        {
            idOrder = dataGridViewOrders.SelectedRows[0].Cells[0].Value.ToString();

            string procedureName = "[dbo].[EditOrders]";

            AddParametrsToStack("@idOrder", SqlDbType.Int, idOrder);
            AddParametrsToStack("@ProductName", SqlDbType.VarChar, selectedProduct);
            AddParametrsToStack("@ClientLastName", SqlDbType.VarChar, selectedClient);
            AddParametrsToStack("@OrderQuantity", SqlDbType.Int, maxOrderQuantity.ToString());

            int result = handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalar(procedureName, zmienneInSql, sqlType, valueToSql);

            ShowDataOnTable();
            MessageBox.Show(result == 1 ? "Operacja wykonana poprawnie." : "Błąd po stronie bazy.");
        }

        public void DeleteOrder()
        {
            idOrder = dataGridViewOrders.SelectedRows[0].Cells[0].Value.ToString();
            string procedureName = "[dbo].[DeleteOrder]";

            AddParametrsToStack("@idOrder", SqlDbType.Int, idOrder);

            int result = handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalar(procedureName, zmienneInSql, sqlType, valueToSql);

            ShowDataOnTable();
            MessageBox.Show(result == 1 ? "Operacja wykonana poprawnie." : "Błąd po stronie bazy.");
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            if (selectedProduct == "" || maxOrderQuantity <= 0 || selectedClient == "")
            {
                MessageBox.Show("Wybierz wszystkie pola");
            }
            else
            {
                AddOrder();
            }
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            DeleteOrder();
        }

        public string GetDateToPdf()
        {
            idOrder = dataGridViewOrders.SelectedRows[0].Cells[0].Value.ToString();
            string procedureName = "[dbo].[GenerateOrderPDF]";
            AddParametrsToStack("@idOrder", SqlDbType.VarChar, idOrder);

            return handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalarString(procedureName, zmienneInSql, sqlType, valueToSql);
        }

        public string DialogSave()
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Pdf Files|*.pdf";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = saveFileDialog1.FileName;
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }

            return folderPath;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Document doc = new Document(PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(DialogSave(), FileMode.Create));
            doc.Open();
            string message = GetDateToPdf();
            string NL = Environment.NewLine;
            Paragraph paragraph = new Paragraph(string.Format(message, NL, NL, NL, NL, NL, NL, NL, NL, NL));
            doc.Add(paragraph);

            doc.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditOrder();
        }
    }
}

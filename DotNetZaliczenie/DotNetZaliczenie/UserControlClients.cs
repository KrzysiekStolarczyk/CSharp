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
    public partial class UserControlClients : UserControl
    {
        string valuefromTextBox = string.Empty;
        string LastName, FirstName, Address, City, PostalCode, Country, HomePhone, IdClient;


        Stack<string> zmienneInSql = new Stack<string>();
        Stack<SqlDbType> sqlType = new Stack<SqlDbType>();
        Stack<string> valueToSql = new Stack<string>();

        ConnectingString handlerToDataBase = new ConnectingString();
        SharedMethods sharedMethod = new SharedMethods();

        public UserControlClients()
        {
            InitializeComponent();
            ShowDataOnTable();
            LoadAllComboBox();
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

        public void LoadAllComboBox()
        {
            DataTable product = new DataTable();
            product = handlerToDataBase.localDbConnection.ExecuteSqlQuery("select distinct LastName from DotNet.Dbo.Client");
            comboBoxLastName.Text = "Wybierz nazwisko";
            foreach (DataRow id in product.Rows)
            {
                comboBoxLastName.Items.Add(id["LastName"]);
            }
        }

        private void buttonfiltrName_Click(object sender, EventArgs e)
        {
            dataGridViewClients.DataSource = handlerToDataBase.localDbConnection.ExecuteSqlQuery("select * from DotNet.dbo.Client where Lastname='" + comboBoxLastName.Text + "'");
        }

        public void AddNewClient()
        {
            LastName = MTBLastNameNew.Text;
            FirstName = MTBFirstNameNew.Text;
            Address = MTBAdressNew.Text;
            City = MTBCityNew.Text;
            PostalCode = MTBPostalCodeNew.Text;
            Country = MTBCountryNew.Text;
            HomePhone = MTBHomePhoneNew.Text;

            string procedureName = "[dbo].[AddClient]";

            AddParametrsToStack("@LastName", SqlDbType.VarChar, LastName);
            AddParametrsToStack("@FirstName", SqlDbType.VarChar, FirstName);
            AddParametrsToStack("@Address", SqlDbType.VarChar, Address);
            AddParametrsToStack("@City", SqlDbType.VarChar, City);
            AddParametrsToStack("@PostalCode", SqlDbType.VarChar, PostalCode);
            AddParametrsToStack("@Country", SqlDbType.VarChar, Country);
            AddParametrsToStack("@HomePhone", SqlDbType.VarChar, HomePhone);

            int result = handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalar(procedureName, zmienneInSql, sqlType, valueToSql);

            ShowDataOnTable();
            MTBLastNameNew.Clear();
            MTBFirstNameNew.Clear();
            MTBAdressNew.Clear();
            MTBCityNew.Clear();
            MTBPostalCodeNew.Clear();
            MTBCountryNew.Clear();
            MTBHomePhoneNew.Clear();
            MessageBox.Show(result == 1 ? "Operacja wykonana poprawnie." : "Błąd po stronie bazy.");
        }

        public void DeleteClient()
        {
            IdClient = dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString();
            string procedureName = "[dbo].[DeleteClient]";

            AddParametrsToStack("@IdClient", SqlDbType.Int, IdClient);

            int result = handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalar(procedureName, zmienneInSql, sqlType, valueToSql);

            ShowDataOnTable();
            MessageBox.Show(result == 1 ? "Operacja wykonana poprawnie." : "Błąd po stronie bazy.");
        }
       
        public void EditClient()
        {
            LastName = MTBLastNameEdit.Text;
            FirstName = MTBFirstNameEdit.Text;
            Address = MTBAdressEdit.Text;
            City = MTBCityEdit.Text;
            PostalCode = MTBPostalCodeEdit.Text;
            Country = MTBCountryEdit.Text;
            HomePhone = MTBHomePhoneEdit.Text;

            IdClient = dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString();
            string procedureName = "[dbo].[EditClient]";

            AddParametrsToStack("@IdClient", SqlDbType.Int, IdClient);
            AddParametrsToStack("@LastName", SqlDbType.VarChar, LastName);
            AddParametrsToStack("@FirstName", SqlDbType.VarChar, FirstName);
            AddParametrsToStack("@Address", SqlDbType.VarChar, Address);
            AddParametrsToStack("@City", SqlDbType.VarChar, City);
            AddParametrsToStack("@PostalCode", SqlDbType.VarChar, PostalCode);
            AddParametrsToStack("@Country", SqlDbType.VarChar, Country);
            AddParametrsToStack("@HomePhone", SqlDbType.VarChar, HomePhone);

            int result = handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalar(procedureName, zmienneInSql, sqlType, valueToSql);

            ShowDataOnTable();
            MTBLastNameEdit.Clear();
            MTBFirstNameEdit.Clear();
            MTBAdressEdit.Clear();
            MTBCityEdit.Clear();
            MTBPostalCodeEdit.Clear();
            MTBCountryEdit.Clear();
            MTBHomePhoneEdit.Clear();
            MessageBox.Show(result == 1 ? "Operacja wykonana poprawnie." : "Błąd po stronie bazy.");
        }

        public void textBoxValueStockValid(object sender, EventArgs e)
        {
            sharedMethod.MaskedTextBoxSetCursor(sender, e);
        }

        private void buttonAddNewClients_Click(object sender, EventArgs e)
        {
            AddNewClient();
        }

        private void buttonEditClients_Click(object sender, EventArgs e)
        {
            EditClient();
        }

        private void buttonDeleteClients_Click(object sender, EventArgs e)
        {
            DeleteClient();
        }
    }
}

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
    public partial class UserControlWarehouseStock : UserControl
    {

        string valuefromTextBox = string.Empty;
        string stokQuantity;
        string idProduct;

        Stack<string> zmienneInSql = new Stack<string>();
        Stack<SqlDbType> sqlType = new Stack<SqlDbType>();
        Stack<string> valueToSql = new Stack<string>();

        ConnectingString handlerToDataBase = new ConnectingString();
        SharedMethods sharedMethod = new SharedMethods();

        public UserControlWarehouseStock()
        {
            InitializeComponent();
            ShowDataOnTable();
        }
        public void ShowDataOnTable()
        {
            dataGridViewWarehouse.DataSource = handlerToDataBase.localDbConnection.ExecuteSqlQuery("select * from DotNet.Dbo.V_WarehouseStock");

            sharedMethod.SettingsDataGrid(dataGridViewWarehouse);
        }

        public void AddParametrsToStack(string sqlVariable, SqlDbType type, string value)
        {
            zmienneInSql.Push(sqlVariable);
            sqlType.Push(type);
            valueToSql.Push(value);
        }

        public void UpdateWarehouseStock()
        {
            stokQuantity = maskedTextBoxValueStock.Text;
            idProduct = dataGridViewWarehouse.SelectedRows[0].Cells[0].Value.ToString();

            string procedureName = "[dbo].[UpdateWarehouseStock]";

            AddParametrsToStack("@idProduct", SqlDbType.Int, idProduct);
            AddParametrsToStack("@newStokQuantity", SqlDbType.Int, stokQuantity);

            int result = handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalar(procedureName, zmienneInSql, sqlType, valueToSql);

            ShowDataOnTable();
            maskedTextBoxValueStock.Clear();

            MessageBox.Show(result == 1 ? "Operacja wykonana poprawnie." : "Błąd po stronie bazy.");
        }


        private void buttonUpdateStock_Click(object sender, System.EventArgs e)
        {
            if (maskedTextBoxValueStock.Text.Length > 0 && sharedMethod.CheckSelectedRowOnGrid(dataGridViewWarehouse) == 1)
            {
                UpdateWarehouseStock();
            }
        }

        public void textBoxValueStockValid(object sender, EventArgs e)
        {
            sharedMethod.MaskedTextBoxSetCursor(sender, e);
        }

    }
}

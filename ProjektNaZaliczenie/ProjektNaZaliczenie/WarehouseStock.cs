using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ProjektNaZaliczenie
{
    public partial class WarehouseStock : Form
    {

        string valuefromTextBox = string.Empty;
        string stokQuantity;
        string idProduct;

        Stack<string> zmienneInSql = new Stack<string>();
        Stack<SqlDbType> sqlType = new Stack<SqlDbType>();
        Stack<string> valueToSql = new Stack<string>();

        ConnectingString handlerToDataBase = new ConnectingString();
        Settings setting = new Settings();
        SharedMethods sharedMethod = new SharedMethods();

        public WarehouseStock()
        {
            InitializeComponent();
            ShowDataOnTable();
        }


        public void ShowDataOnTable()
        {
            dataGridViewWarehouse.DataSource = handlerToDataBase.localDbConnection.ExecuteSqlQuery("select * from DotNet.Dbo.V_WarehouseStock");

            setting.SettingsDataGridWarehouseStock(dataGridViewWarehouse);
        }

        public void AddParametrsToStack(string sqlVariable, SqlDbType type, string value)
        {
            zmienneInSql.Push(sqlVariable);
            sqlType.Push(type);
            valueToSql.Push(value);

        }

        public void UpdateWarehouseStock()
        {
            
            stokQuantity = textBoxValueStock.Text;
            idProduct = dataGridViewWarehouse.SelectedRows[0].Cells[0].Value.ToString();

            string procedureName = "[dbo].[UpdateWarehouseStock]";

            AddParametrsToStack("@idProduct", SqlDbType.Int, idProduct);
            AddParametrsToStack("@newStokQuantity", SqlDbType.Int, stokQuantity);

            int result = handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalar(procedureName, zmienneInSql, sqlType, valueToSql);
 
            ShowDataOnTable();
            textBoxValueStock.Clear();

            MessageBox.Show(result == 1 ? "Operacja wykonana poprawnie." : "Błąd po stronie bazy.");
        }


        private void buttonUpdateStock_Click(object sender, System.EventArgs e)
        {

            if (sharedMethod.CheckBeAbleUpdate(textBoxValueStock, dataGridViewWarehouse)==1)
            {
                UpdateWarehouseStock();
            }
            
        }

        private void textBoxValueStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            sharedMethod.ValidInputChar(sender, e);
        }
    }
}

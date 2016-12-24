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
    public partial class UserControlCategory : UserControl
    {
        string idCat;

        Stack<string> zmienneInSql = new Stack<string>();
        Stack<SqlDbType> sqlType = new Stack<SqlDbType>();
        Stack<string> valueToSql = new Stack<string>();

        ConnectingString handlerToDataBase = new ConnectingString();
        SharedMethods sharedMethod = new SharedMethods();

        public UserControlCategory()
        {
            InitializeComponent();
            ShowDataOnTable();
        }
        public void ShowDataOnTable()
        {
            dataGridViewCat.DataSource = handlerToDataBase.localDbConnection.ExecuteSqlQuery("select * from DotNet.Dbo.Categories");

            sharedMethod.SettingsDataGrid(dataGridViewCat);
        }

        public void AddParametrsToStack(string sqlVariable, SqlDbType type, string value)
        {
            zmienneInSql.Push(sqlVariable);
            sqlType.Push(type);
            valueToSql.Push(value);
        }

        public void AddNewCategory()
        {
            string procedureName = "[dbo].[AddCategory]";

            AddParametrsToStack("@CategoryName", SqlDbType.VarChar, maskedTextBoxAddCat.Text);
            int result = handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalar(procedureName, zmienneInSql, sqlType, valueToSql);

            ShowDataOnTable();
            maskedTextBoxAddCat.Clear();
            MessageBox.Show(result == 1 ? "Operacja wykonana poprawnie." : "Błąd po stronie bazy.");
        }

        public void DeleteProduct()
        {
            idCat = dataGridViewCat.SelectedRows[0].Cells[0].Value.ToString();
            string procedureName = "[dbo].[DeleteCategory]";

            AddParametrsToStack("@idCategory", SqlDbType.Int, idCat);

            int result = handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalar(procedureName, zmienneInSql, sqlType, valueToSql);

            ShowDataOnTable();
            MessageBox.Show(result == 1 ? "Operacja wykonana poprawnie." : "Błąd po stronie bazy.");
        }

        public void EditProduct()
        {

            idCat = dataGridViewCat.SelectedRows[0].Cells[0].Value.ToString();

            string procedureName = "[dbo].[EditCategory]";

            AddParametrsToStack("@idCategory", SqlDbType.Int, idCat);
            AddParametrsToStack("@CategoryName", SqlDbType.VarChar, maskedTextBoxDeleteCat.Text);

            int result = handlerToDataBase.localDbConnection.ExecuteQueryWithParametersStokScalar(procedureName, zmienneInSql, sqlType, valueToSql);

            ShowDataOnTable();
            maskedTextBoxDeleteCat.Clear();
            MessageBox.Show(result == 1 ? "Operacja wykonana poprawnie." : "Błąd po stronie bazy.");
        }

        private void buttonAddNewCat_Click(object sender, EventArgs e)
        {
            AddNewCategory();
        }

        private void buttonDeleteCa_Click(object sender, EventArgs e)
        {
            if(dataGridViewCat.SelectedRows.Count==0)
            {
                MessageBox.Show("Prosze najpierw zaznaczyć wiersz w tabeli");
            }
            else
            {
                DeleteProduct();
            }
            
        }

        public void textBoxValueStockValid(object sender, EventArgs e)
        {
            sharedMethod.MaskedTextBoxSetCursor(sender, e);
        }

        private void buttonEditCat_Click(object sender, EventArgs e)
        {
            if (dataGridViewCat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Prosze najpierw zaznaczyć wiersz w tabeli");
            }
            else
            {
                EditProduct();
            }
           
        }
    }
}

//Wersja C#
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Test();
        }

 public void Test()
        {
            DataTable dicArticles = new DataTable();
            dicArticles.Columns.Add("ArticleId");
            dicArticles.Rows.Add(new object[] { 1 });
            dicArticles.Rows.Add(new object[] { 2 });
            dicArticles.Rows.Add(new object[] { 3 });
            dicArticles.Rows.Add(new object[] { 4 });
            dicArticles.Rows.Add(new object[] { 5 });
            dicArticles.Rows.Add(new object[] { 6 });
            dicArticles.Rows.Add(new object[] { 7 });
            dicArticles.Rows.Add(new object[] { 8 });

            DataTable articlesFromExcel = new DataTable();
            articlesFromExcel.Columns.Add("ArticleId");
            articlesFromExcel.Columns.Add("NameArticle");
            articlesFromExcel.Rows.Add(new object[] { 1, "a" });
            articlesFromExcel.Rows.Add(new object[] { 2, "m" });
            articlesFromExcel.Rows.Add(new object[] { 4, "c" });
            articlesFromExcel.Rows.Add(new object[] { 7, "x" });
            articlesFromExcel.Rows.Add(new object[] { 8, "x" });

            DataTable resultTable = new DataTable();

            var resultLeftJoin =
                from t1 in dicArticles.AsEnumerable()
                join t2 in articlesFromExcel.AsEnumerable()
                on t1["ArticleId"] equals t2["ArticleId"] into Group
                from t2 in Group.DefaultIfEmpty()
                where t2 != null
                select new
                {
                    IdArtBaza = t1["ArticleId"]
                    ,
                    IdArtExcel = t2 == null ? null : t2["NameArticle"]
                };

            resultTable = ConvertToDataTable(resultLeftJoin.AsEnumerable().ToList());
    }
        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }
    }
}


//Wersja VB

Imports System.ComponentModel

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dicArticles As New DataTable
        dicArticles.Columns.Add("ArticleId")
        dicArticles.Rows.Add(New Object() {1})
        dicArticles.Rows.Add(New Object() {2})
        dicArticles.Rows.Add(New Object() {3})
        dicArticles.Rows.Add(New Object() {4})
        dicArticles.Rows.Add(New Object() {5})
        dicArticles.Rows.Add(New Object() {6})
        dicArticles.Rows.Add(New Object() {7})
        dicArticles.Rows.Add(New Object() {8})


        Dim articlesFromExcel As New DataTable
        articlesFromExcel.Columns.Add("ArticleId")
        articlesFromExcel.Columns.Add("NameArticle")
        articlesFromExcel.Rows.Add(New Object() {1, "a"})
        articlesFromExcel.Rows.Add(New Object() {2, "m"})
        articlesFromExcel.Rows.Add(New Object() {4, "c"})
        articlesFromExcel.Rows.Add(New Object() {7, "x"})
        articlesFromExcel.Rows.Add(New Object() {8, "x"})
        Dim resultTable As New DataTable

        Dim resultLeftJoin =
                From t1 In dicArticles.AsEnumerable()
                Group Join t2 In articlesFromExcel.AsEnumerable()
                On t1("ArticleId") Equals t2("ArticleId") Into Group
                From t2 In Group.DefaultIfEmpty()
                Where 1 = 1
                Select
                      IdArtBaza = t1("ArticleId") _
                      , IdArtExcel = If(t2 Is Nothing, "NULL", t2("NameArticle"))

        resultTable = ConvertToDataTable(resultLeftJoin.AsEnumerable().ToList())


    End Sub

    Public Function ConvertToDataTable(Of T)(data As IList(Of T)) As DataTable
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim table As New DataTable()
        For Each prop As PropertyDescriptor In properties
            table.Columns.Add(prop.Name, If(Nullable.GetUnderlyingType(prop.PropertyType), prop.PropertyType))
        Next
        For Each item As T In data
            Dim row As DataRow = table.NewRow()
            For Each prop As PropertyDescriptor In properties
                row(prop.Name) = If(prop.GetValue(item), DBNull.Value)
            Next
            table.Rows.Add(row)
        Next
        Return table

    End Function
End Class

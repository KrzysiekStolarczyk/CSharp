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

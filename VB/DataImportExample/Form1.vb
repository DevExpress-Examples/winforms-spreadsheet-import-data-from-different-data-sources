Imports DevExpress.Spreadsheet
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.IO

Namespace DataImportExample

    Public Partial Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Private imageBytes1 As Byte() = File.ReadAllBytes("images//img.png")

        Private imageBytes2 As Byte() = File.ReadAllBytes("images//x-docserver.png")

        ' ...
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnImportDataTable_Click(ByVal sender As Object, ByVal e As EventArgs)
            spreadsheetControl1.Document.BeginUpdate()
            Try
                Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
                worksheet.Clear(worksheet.GetUsedRange())
                ImportDataTable()
                CreateTable()
            Finally
                spreadsheetControl1.Document.EndUpdate()
            End Try
        End Sub

        Private Sub btnImportArray_Click(ByVal sender As Object, ByVal e As EventArgs)
            spreadsheetControl1.Document.BeginUpdate()
            Try
                Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
                worksheet.Clear(worksheet.GetUsedRange())
                worksheet.Cells("A1").ColumnWidthInCharacters = 35
                worksheet.Cells("A1").Value = "Import an array horizontally:"
                worksheet.Cells("A3").Value = "Import a two-dimensional array:"
                ImportArrays()
            Finally
                spreadsheetControl1.Document.EndUpdate()
            End Try
        End Sub

        Private Sub btnImportList_Click(ByVal sender As Object, ByVal e As EventArgs)
            spreadsheetControl1.Document.BeginUpdate()
            Try
                Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
                worksheet.Clear(worksheet.GetUsedRange())
                worksheet.Cells("A1").ColumnWidthInCharacters = 35
                worksheet.Cells("A1").Value = "Import data from List vertically:"
                ImportList()
            Finally
                spreadsheetControl1.Document.EndUpdate()
            End Try
        End Sub

        Private Sub btnArrayList_Click(ByVal sender As Object, ByVal e As EventArgs)
            spreadsheetControl1.Document.BeginUpdate()
            Try
                Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
                worksheet.Clear(worksheet.GetUsedRange())
                ImportArrayList()
            Finally
                spreadsheetControl1.Document.EndUpdate()
            End Try
        End Sub

#Region "#ImportDataTable"
        Private Sub ImportDataTable()
            Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
            ' Create a "Products" DataTable object with four columns.
            Dim sourceTable As DataTable = New DataTable("Products")
            sourceTable.Columns.Add("Product", GetType(String))
            sourceTable.Columns.Add("Price", GetType(Single))
            sourceTable.Columns.Add("Quantity", GetType(Integer))
            sourceTable.Columns.Add("Discount", GetType(Single))
            sourceTable.Columns.Add("Image", GetType(Byte()))
            sourceTable.Rows.Add("Chocolade", 5, 15, 0.03, imageBytes1)
            sourceTable.Rows.Add("Konbu", 9, 55, 0.1, imageBytes1)
            sourceTable.Rows.Add("Geitost", 15, 70, 0.07, imageBytes2)
            ' Import data from the data table into the worksheet and insert it, starting with the B2 cell.
            worksheet.Import(sourceTable, True, 1, 1)
        End Sub

#End Region  ' #ImportDataTable
#Region "#CreateTable"
        Private Sub CreateTable()
            Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
            ' Insert a table in the worksheet.
            Dim table As Table = worksheet.Tables.Add(worksheet("B2:G5"), True)
            ' Format the table by applying a built-in table style.
            table.Style = spreadsheetControl1.Document.TableStyles(BuiltInTableStyleId.TableStyleMedium27)
            ' Access table columns.
            Dim productColumn As TableColumn = table.Columns(0)
            Dim priceColumn As TableColumn = table.Columns(1)
            Dim quantityColumn As TableColumn = table.Columns(2)
            Dim discountColumn As TableColumn = table.Columns(3)
            Dim imageColumn As TableColumn = table.Columns(4)
            Dim amountColumn As TableColumn = table.Columns(5)
            ' Set the name of the last column. 
            amountColumn.Name = "Amount"
            ' Set the formula to calculate the amount per product 
            ' and display results in the "Amount" column.
            amountColumn.Formula = "=[Price]*[Quantity]*(1-[Discount])"
            ' Display the total row in the table.
            table.ShowTotals = True
            ' Set the label and function to display the sum of the "Amount" column.
            discountColumn.TotalRowLabel = "Total:"
            amountColumn.TotalRowFunction = TotalRowFunction.Sum
            ' Specify the number format for each column.
            priceColumn.DataRange.NumberFormat = "$#,##0.00"
            discountColumn.DataRange.NumberFormat = "0.0%"
            amountColumn.Range.NumberFormat = "$#,##0.00;$#,##0.00;"""";@"
            ' Specify horizontal alignment for header and total rows of the table.
            table.HeaderRowRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            table.TotalRowRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            ' Specify horizontal alignment to display data in all columns except the first one.
            For i As Integer = 1 To table.Columns.Count - 1
                table.Columns(i).DataRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center
            Next

            ' Set the width of table columns.
            table.Range.ColumnWidthInCharacters = 10
        End Sub

#End Region  ' #CreateTable
        Private Sub ImportArrays()
            Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
#Region "#ImportArrays"
            ' Create an array containing string values.
            Dim array As String() = New String() {"AAA", "BBB", "CCC", "DDD"}
            ' Import the array into the worksheet and insert it horizontally, starting with the B1 cell.
            worksheet.Import(array, 0, 1, False)
            ' Create a two-dimensional array containing string values.
            Dim names As String(,) = New String(1, 3) {{"Ann", "Edward", "Angela", "Alex"}, {"Rachel", "Bruce", "Barbara", "George"}}
            ' Import the two-dimensional array into the worksheet and insert it, starting with the B3 cell.
            worksheet.Import(names, 2, 1)
#End Region  ' #ImportArrays
        End Sub

        Private Sub ImportList()
            Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
#Region "#ImportList"
            ' Create a List object containing string values.
            Dim cities As List(Of String) = New List(Of String) From {"New York", "Rome", "Beijing", "Delhi"}
            ' Import the list into the worksheet and insert it vertically, starting with the B1 cell.
            worksheet.Import(cities, 0, 1, True)
            Dim imageList As List(Of Byte()) = New List(Of Byte())()
            If True Then
                imageList.Add(imageBytes1)
                imageList.Add(imageBytes2)
            End If

            ' Import the image list into the worksheet and insert it vertically
            worksheet.Import(imageList, 0, 2, True, New DataImportOptions())
#End Region  ' #ImportList
        End Sub

        Private Sub ImportArrayList()
#Region "#ImportArrayList"
            Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
            Dim listDataSource As Collections.ArrayList = New Collections.ArrayList() From {New TestObject(1, "Jane", True, imageBytes1), New TestObject(2, "Joe", False, imageBytes2), New TestObject(3, "Bill", True, imageBytes1), New TestObject(4, "Michael", False, imageBytes2)}
            worksheet.Import(listDataSource, 0, 0)
#End Region  ' #ImportArrayList
        End Sub

        Private Sub btnImportObject_Click(ByVal sender As Object, ByVal e As EventArgs)
#Region "#ImportObject"
            Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
            worksheet.Clear(worksheet.GetUsedRange())
            worksheet.Import(New TestObject(1, "1", True, imageBytes1), 0, 0)
#End Region  ' #ImportObject
        End Sub

        Private Sub btnUseOptions_Click(ByVal sender As Object, ByVal e As EventArgs)
#Region "#ImportUsingOptions"
            Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
            worksheet.Clear(worksheet.GetUsedRange())
            Dim arrayR1C1 As String() = New String() {"a", "b", "=R1C1&R1C2"}
            worksheet.Import(arrayR1C1, 0, 0, False, New DataImportOptions() With {.ImportFormulas = True, .ReferenceStyle = ReferenceStyle.R1C1})
            Dim arrayLocalized As String() = New String() {"a", "=1,2+1"}
            worksheet.Import(arrayLocalized, 1, 0, False, New DataImportOptions() With {.ImportFormulas = True, .FormulaCulture = New Globalization.CultureInfo("de-DE")})
#End Region  ' #ImportUsingOptions
        End Sub

        Private Sub btnUseFields_Click(ByVal sender As Object, ByVal e As EventArgs)
#Region "#ImportSpecifiedFields"
            Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
            worksheet.Clear(worksheet.GetUsedRange())
            Dim list As List(Of TestObject) = New List(Of TestObject) From {New TestObject(1, "1", True, imageBytes1), New TestObject(2, "2", False, imageBytes2)}
            worksheet.Import(list, 0, 0, New DataSourceImportOptions() With {.PropertyNames = New String() {"BoolValue", "ImageValue"}})
#End Region  ' #ImportSpecifiedFields
        End Sub

        Private Sub btnUseConverter_Click(ByVal sender As Object, ByVal e As EventArgs)
#Region "#ImportUsingConverter"
            Dim worksheet As Worksheet = spreadsheetControl1.Document.Worksheets(0)
            worksheet.Clear(worksheet.GetUsedRange())
            Dim imageBase64 As String = Convert.ToBase64String(imageBytes1)
            Dim list As List(Of TestObject) = New List(Of TestObject) From {New TestObject(1, "1", True, imageBase64), New TestObject(2, "2", False, imageBase64)}
            worksheet.Import(list, 0, 0, New DataSourceImportOptions() With {.Converter = New TestDataValueConverter(), .PropertyNames = New String() {"IntValue", "Value", "BoolValue", "ImageBase64"}})
            worksheet.Import(list, 0, 0, New DataSourceImportOptions() With {.Converter = New TestDataValueConverter()})
#End Region  ' #ImportUsingConverter
        End Sub
    End Class
End Namespace

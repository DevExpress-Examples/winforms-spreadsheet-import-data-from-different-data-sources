﻿using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace DataImportExample
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        #region #ImageBytes
        byte[] imageBytes1 = File.ReadAllBytes("images//img.png");
        byte[] imageBytes2 = File.ReadAllBytes("images//x-docserver.png");
        #endregion #ImageBytes
        // ...
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImportDataTable_Click(object sender, EventArgs e)
        {
            spreadsheetControl1.Document.BeginUpdate();
            try
            {
                Worksheet worksheet = spreadsheetControl1.Document.Worksheets[0];
                worksheet.Clear(worksheet.GetUsedRange());
                ImportDataTable();
                CreateTable();
            }
            finally
            {
                spreadsheetControl1.Document.EndUpdate();
            }
        }

        private void btnImportArray_Click(object sender, EventArgs e)
        {
            spreadsheetControl1.Document.BeginUpdate();
            try
            {
                Worksheet worksheet = spreadsheetControl1.Document.Worksheets[0];
                worksheet.Clear(worksheet.GetUsedRange());
                worksheet.Cells["A1"].ColumnWidthInCharacters = 35;
                worksheet.Cells["A1"].Value = "Import an array horizontally:";
                worksheet.Cells["A3"].Value = "Import a two-dimensional array:";
                ImportArrays();
            }
            finally
            {
                spreadsheetControl1.Document.EndUpdate();
            }
        }

        private void btnImportList_Click(object sender, EventArgs e)
        {
            spreadsheetControl1.Document.BeginUpdate();
            try
            {
                Worksheet worksheet = spreadsheetControl1.Document.Worksheets[0];
                worksheet.Clear(worksheet.GetUsedRange());
                worksheet.Cells["A1"].ColumnWidthInCharacters = 35;
                worksheet.Cells["A1"].Value = "Import data from List vertically:";
                ImportList();
            }
            finally
            {
                spreadsheetControl1.Document.EndUpdate();
            }
        }

        private void btnArrayList_Click(object sender, EventArgs e)
        {
            spreadsheetControl1.Document.BeginUpdate();
            try
            {
                Worksheet worksheet = spreadsheetControl1.Document.Worksheets[0];
                worksheet.Clear(worksheet.GetUsedRange());
                ImportArrayList();
            }
            finally
            {
                spreadsheetControl1.Document.EndUpdate();
            }
        }

        #region #ImportDataTable
        void ImportDataTable()
        {

            Worksheet worksheet = spreadsheetControl1.Document.Worksheets[0];

            // Create a "Products" DataTable object with four columns.
            DataTable sourceTable = new DataTable("Products");
            sourceTable.Columns.Add("Product", typeof(string));
            sourceTable.Columns.Add("Price", typeof(float));
            sourceTable.Columns.Add("Quantity", typeof(Int32));
            sourceTable.Columns.Add("Discount", typeof(float));
            sourceTable.Columns.Add("Image", typeof(byte[]));

            sourceTable.Rows.Add("Chocolade", 5, 15, 0.03, imageBytes1);
            sourceTable.Rows.Add("Konbu", 9, 55, 0.1, imageBytes1);
            sourceTable.Rows.Add("Geitost", 15, 70, 0.07, imageBytes2);

            // Import data from the data table into the worksheet and insert it, starting with the B2 cell.
            worksheet.Import(sourceTable, true, 1, 1);
        }
        #endregion #ImportDataTable

        #region #CreateTable
        void CreateTable() {
            Worksheet worksheet = spreadsheetControl1.Document.Worksheets[0];

            // Insert a table in the worksheet.
            Table table = worksheet.Tables.Add(worksheet["B2:G5"], true);

            // Format the table by applying a built-in table style.
            table.Style = spreadsheetControl1.Document.TableStyles[BuiltInTableStyleId.TableStyleMedium27];

            // Access table columns.
            TableColumn productColumn = table.Columns[0];
            TableColumn priceColumn = table.Columns[1];
            TableColumn quantityColumn = table.Columns[2];
            TableColumn discountColumn = table.Columns[3];
            TableColumn imageColumn = table.Columns[4];
            TableColumn amountColumn = table.Columns[5];

            // Set the name of the last column. 
            amountColumn.Name = "Amount";

            // Set the formula to calculate the amount per product 
            // and display results in the "Amount" column.
            amountColumn.Formula = "=[Price]*[Quantity]*(1-[Discount])";

            // Display the total row in the table.
            table.ShowTotals = true;

            // Set the label and function to display the sum of the "Amount" column.
            discountColumn.TotalRowLabel = "Total:";
            amountColumn.TotalRowFunction = TotalRowFunction.Sum;

            // Specify the number format for each column.
            priceColumn.DataRange.NumberFormat = "$#,##0.00";
            discountColumn.DataRange.NumberFormat = "0.0%";
            amountColumn.Range.NumberFormat = "$#,##0.00;$#,##0.00;\"\";@";

            // Specify horizontal alignment for header and total rows of the table.
            table.HeaderRowRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            table.TotalRowRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;

            // Specify horizontal alignment to display data in all columns except the first one.
            for (int i = 1; i < table.Columns.Count; i++)
            {
                table.Columns[i].DataRange.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            }

            // Set the width of table columns.
            table.Range.ColumnWidthInCharacters = 10;
        }
        #endregion #CreateTable


        void ImportArrays() {
            #region #ImportArrays
            Worksheet worksheet = spreadsheetControl1.Document.Worksheets[0];
            // Create an array containing string values.
            string[] array = new string[] { "AAA", "BBB", "CCC", "DDD" };

            // Import the array into the worksheet and insert it horizontally, starting with the B1 cell.
            worksheet.Import(array, 0, 1, false);

            // Create a two-dimensional array containing string values.
            String[,] names = new String[2, 4]{
            {"Ann", "Edward", "Angela", "Alex"},
            {"Rachel", "Bruce", "Barbara", "George"}
                 };

            // Import the two-dimensional array into the worksheet and insert it, starting with the B3 cell.
            worksheet.Import(names, 2, 1);
            #endregion #ImportArrays
        }

        void ImportList() {
            #region #ImportList
            Worksheet worksheet = spreadsheetControl1.Document.Worksheets[0];
            // Create a List object containing string values.
            List<string> cities = new List<string>
            {
                "New York",
                "Rome",
                "Beijing",
                "Delhi"
            };

            // Import the list into the worksheet and insert it vertically, starting with the B1 cell.
            worksheet.Import(cities, 0, 1, true);

            List<byte[]> imageList = new List<byte[]>();
            {
                imageList.Add(imageBytes1);
                imageList.Add(imageBytes2);
            };

            // Import the image list into the worksheet and insert it vertically
            worksheet.Import(imageList, 0, 2, true, new DataImportOptions());
            #endregion #ImportList
        }

        void ImportArrayList()
        {
            #region #ImportArrayList
            Worksheet worksheet = spreadsheetControl1.Document.Worksheets[0];
            System.Collections.ArrayList listDataSource = new System.Collections.ArrayList()
            {
                new TestObject(1, "Jane", true, imageBytes1),
                new TestObject(2, "Joe", false, imageBytes2),
                new TestObject(3, "Bill", true, imageBytes1),
                new TestObject(4, "Michael", false, imageBytes2),
            };
            worksheet.Import(listDataSource, 0, 0);
            #endregion #ImportArrayList
        }

        private void btnImportObject_Click(object sender, EventArgs e)
        {
            #region #ImportObject
            Worksheet worksheet = spreadsheetControl1.Document.Worksheets[0];
            worksheet.Clear(worksheet.GetUsedRange());
            worksheet.Import(new TestObject(1, "1", true, imageBytes1), 0, 0);
            #endregion #ImportObject
        }


        private void btnUseOptions_Click(object sender, EventArgs e)
        {
            #region #ImportUsingOptions
            Worksheet worksheet = spreadsheetControl1.Document.Worksheets[0];
            worksheet.Clear(worksheet.GetUsedRange());
            string[] arrayR1C1 = new string[] { "a", "b", "=R1C1&R1C2" };
            worksheet.Import(arrayR1C1, 0, 0, false, new DataImportOptions() { ImportFormulas = true, ReferenceStyle = ReferenceStyle.R1C1 });

            string[] arrayLocalized = new string[] { "a", "=1,2+1" };
            worksheet.Import(arrayLocalized, 1, 0, false,
                new DataImportOptions()
                {
                    ImportFormulas = true,
                    FormulaCulture = new System.Globalization.CultureInfo("de-DE")
                });
            #endregion #ImportUsingOptions
        }

        private void btnUseFields_Click(object sender, EventArgs e)
        {
            #region #ImportSpecifiedFields
            Worksheet worksheet = spreadsheetControl1.Document.Worksheets[0];
            worksheet.Clear(worksheet.GetUsedRange());

            List<TestObject> list = new List<TestObject> {
                new TestObject(1, "1", true, imageBytes1),
                new TestObject(2, "2", false, imageBytes2)
            };
            worksheet.Import(list, 0, 0, new DataSourceImportOptions() { PropertyNames = new string[] { "BoolValue", "ImageValue" } });
            #endregion #ImportSpecifiedFields
        }

        private void btnUseConverter_Click(object sender, EventArgs e)
        {
            #region #ImportUsingConverter
            Worksheet worksheet = spreadsheetControl1.Document.Worksheets[0];
            worksheet.Clear(worksheet.GetUsedRange());
            string imageBase64 = Convert.ToBase64String(imageBytes1);

            List<TestObject> list = new List<TestObject> {
                new TestObject(1, "1", true, imageBase64),
                new TestObject(2, "2", false, imageBase64)
            };
            worksheet.Import(list, 0, 0, new DataSourceImportOptions()
            {
                Converter = new TestDataValueConverter(),
                PropertyNames = new string[] { "IntValue", "Value", "BoolValue", "ImageBase64" }
            });
            worksheet.Import(list, 0, 0, new DataSourceImportOptions() { Converter = new TestDataValueConverter() });
            #endregion #ImportUsingConverter
        }
    }
}

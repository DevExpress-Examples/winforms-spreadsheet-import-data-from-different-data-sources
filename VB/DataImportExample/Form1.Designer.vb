Namespace DataImportExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.btnImportArrayList = New DevExpress.XtraEditors.SimpleButton()
			Me.btnUseConverter = New DevExpress.XtraEditors.SimpleButton()
			Me.btnUseFields = New DevExpress.XtraEditors.SimpleButton()
			Me.btnUseOptions = New DevExpress.XtraEditors.SimpleButton()
			Me.btnImportObject = New DevExpress.XtraEditors.SimpleButton()
			Me.btnImportList = New DevExpress.XtraEditors.SimpleButton()
			Me.btnImportArray = New DevExpress.XtraEditors.SimpleButton()
			Me.btnImportDataTable = New DevExpress.XtraEditors.SimpleButton()
			Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
			Me.spreadsheetFormulaBar1 = New DevExpress.XtraSpreadsheet.SpreadsheetFormulaBar()
			Me.spreadsheetDockManager1 = New DevExpress.XtraSpreadsheet.SpreadsheetDockManager(Me.components)
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitContainerControl1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.Panel1.SuspendLayout()
			CType(Me.splitContainerControl1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.Panel2.SuspendLayout()
			Me.splitContainerControl1.SuspendLayout()
			CType(Me.spreadsheetDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' spreadsheetControl1
			' 
			Me.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetControl1.Location = New System.Drawing.Point(0, 40)
			Me.spreadsheetControl1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
			Me.spreadsheetControl1.Name = "spreadsheetControl1"
			Me.spreadsheetControl1.Options.Export.Csv.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl1.Options.Export.Txt.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl1.Options.Export.Txt.ValueSeparator = ","c
			Me.spreadsheetControl1.Options.Import.Csv.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl1.Options.Import.Txt.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl1.Size = New System.Drawing.Size(784, 546)
			Me.spreadsheetControl1.TabIndex = 0
			Me.spreadsheetControl1.Text = "spreadsheetControl1"
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.IsSplitterFixed = True
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			' 
			' splitContainerControl1.Panel1
			' 
			Me.splitContainerControl1.Panel1.Controls.Add(Me.btnImportArrayList)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.btnUseConverter)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.btnUseFields)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.btnUseOptions)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.btnImportObject)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.btnImportList)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.btnImportArray)
			Me.splitContainerControl1.Panel1.Controls.Add(Me.btnImportDataTable)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			' 
			' splitContainerControl1.Panel2
			' 
			Me.splitContainerControl1.Panel2.Controls.Add(Me.spreadsheetControl1)
			Me.splitContainerControl1.Panel2.Controls.Add(Me.splitterControl1)
			Me.splitContainerControl1.Panel2.Controls.Add(Me.spreadsheetFormulaBar1)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(1088, 586)
			Me.splitContainerControl1.SplitterPosition = 292
			Me.splitContainerControl1.TabIndex = 1
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' btnImportArrayList
			' 
			Me.btnImportArrayList.Location = New System.Drawing.Point(6, 235)
			Me.btnImportArrayList.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
			Me.btnImportArrayList.Name = "btnImportArrayList"
			Me.btnImportArrayList.Size = New System.Drawing.Size(280, 44)
			Me.btnImportArrayList.TabIndex = 7
			Me.btnImportArrayList.Text = "Import ArrayList"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnImportArrayList.Click += new System.EventHandler(this.btnArrayList_Click);
			' 
			' btnUseConverter
			' 
			Me.btnUseConverter.Location = New System.Drawing.Point(6, 401)
			Me.btnUseConverter.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
			Me.btnUseConverter.Name = "btnUseConverter"
			Me.btnUseConverter.Size = New System.Drawing.Size(280, 44)
			Me.btnUseConverter.TabIndex = 6
			Me.btnUseConverter.Text = "Import Using Converter"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnUseConverter.Click += new System.EventHandler(this.btnUseConverter_Click);
			' 
			' btnUseFields
			' 
			Me.btnUseFields.Location = New System.Drawing.Point(6, 348)
			Me.btnUseFields.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
			Me.btnUseFields.Name = "btnUseFields"
			Me.btnUseFields.Size = New System.Drawing.Size(280, 44)
			Me.btnUseFields.TabIndex = 5
			Me.btnUseFields.Text = "Import Specified Fields"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnUseFields.Click += new System.EventHandler(this.btnUseFields_Click);
			' 
			' btnUseOptions
			' 
			Me.btnUseOptions.Location = New System.Drawing.Point(6, 290)
			Me.btnUseOptions.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
			Me.btnUseOptions.Name = "btnUseOptions"
			Me.btnUseOptions.Size = New System.Drawing.Size(280, 44)
			Me.btnUseOptions.TabIndex = 4
			Me.btnUseOptions.Text = "Import Using Options"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnUseOptions.Click += new System.EventHandler(this.btnUseOptions_Click);
			' 
			' btnImportObject
			' 
			Me.btnImportObject.Location = New System.Drawing.Point(6, 178)
			Me.btnImportObject.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
			Me.btnImportObject.Name = "btnImportObject"
			Me.btnImportObject.Size = New System.Drawing.Size(280, 44)
			Me.btnImportObject.TabIndex = 3
			Me.btnImportObject.Text = "Import Object"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnImportObject.Click += new System.EventHandler(this.btnImportObject_Click);
			' 
			' btnImportList
			' 
			Me.btnImportList.Location = New System.Drawing.Point(6, 124)
			Me.btnImportList.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
			Me.btnImportList.Name = "btnImportList"
			Me.btnImportList.Size = New System.Drawing.Size(280, 44)
			Me.btnImportList.TabIndex = 2
			Me.btnImportList.Text = "Import List"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnImportList.Click += new System.EventHandler(this.btnImportList_Click);
			' 
			' btnImportArray
			' 
			Me.btnImportArray.Location = New System.Drawing.Point(6, 68)
			Me.btnImportArray.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
			Me.btnImportArray.Name = "btnImportArray"
			Me.btnImportArray.Size = New System.Drawing.Size(280, 44)
			Me.btnImportArray.TabIndex = 1
			Me.btnImportArray.Text = "Import Arrays"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnImportArray.Click += new System.EventHandler(this.btnImportArray_Click);
			' 
			' btnImportDataTable
			' 
			Me.btnImportDataTable.Location = New System.Drawing.Point(6, 6)
			Me.btnImportDataTable.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
			Me.btnImportDataTable.Name = "btnImportDataTable"
			Me.btnImportDataTable.Size = New System.Drawing.Size(280, 50)
			Me.btnImportDataTable.TabIndex = 0
			Me.btnImportDataTable.Text = "Import DataTable"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btnImportDataTable.Click += new System.EventHandler(this.btnImportDataTable_Click);
			' 
			' splitterControl1
			' 
			Me.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.splitterControl1.Location = New System.Drawing.Point(0, 28)
			Me.splitterControl1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
			Me.splitterControl1.MinSize = 20
			Me.splitterControl1.Name = "splitterControl1"
			Me.splitterControl1.Size = New System.Drawing.Size(784, 12)
			Me.splitterControl1.TabIndex = 1
			Me.splitterControl1.TabStop = False
			' 
			' spreadsheetFormulaBar1
			' 
			Me.spreadsheetFormulaBar1.Dock = System.Windows.Forms.DockStyle.Top
			Me.spreadsheetFormulaBar1.Location = New System.Drawing.Point(0, 0)
			Me.spreadsheetFormulaBar1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
			Me.spreadsheetFormulaBar1.MinimumSize = New System.Drawing.Size(0, 28)
			Me.spreadsheetFormulaBar1.Name = "spreadsheetFormulaBar1"
			Me.spreadsheetFormulaBar1.Size = New System.Drawing.Size(784, 28)
			Me.spreadsheetFormulaBar1.SpreadsheetControl = Me.spreadsheetControl1
			Me.spreadsheetFormulaBar1.TabIndex = 2
			' 
			' spreadsheetDockManager1
			' 
			Me.spreadsheetDockManager1.Form = Me
			Me.spreadsheetDockManager1.SpreadsheetControl = Me.spreadsheetControl1
			Me.spreadsheetDockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane"})
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1088, 586)
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.splitContainerControl1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.Panel1.ResumeLayout(False)
			CType(Me.splitContainerControl1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.Panel2.ResumeLayout(False)
			CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			CType(Me.spreadsheetDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private spreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private WithEvents btnImportDataTable As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnImportArray As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnImportList As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnImportObject As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnUseOptions As DevExpress.XtraEditors.SimpleButton
		Private spreadsheetDockManager1 As DevExpress.XtraSpreadsheet.SpreadsheetDockManager
		Private WithEvents btnUseFields As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnUseConverter As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btnImportArrayList As DevExpress.XtraEditors.SimpleButton
		Private splitterControl1 As DevExpress.XtraEditors.SplitterControl
		Private spreadsheetFormulaBar1 As DevExpress.XtraSpreadsheet.SpreadsheetFormulaBar
	End Class
End Namespace


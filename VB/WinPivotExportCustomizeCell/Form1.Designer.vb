Namespace WinPivotExportCustomizeCell
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
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.nwindDataSet = New WinPivotExportCustomizeCell.Data.nwindDataSet()
            Me.fieldCountry1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCategoryName1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.salesPersonTableAdapter1 = New WinPivotExportCustomizeCell.Data.nwindDataSetTableAdapters.SalesPersonTableAdapter()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.barButtonItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 2
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
            Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False
            Me.ribbonControl1.Size = New System.Drawing.Size(698, 147)
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "Export To Excel"
            Me.barButtonItem1.Glyph = (DirectCast(resources.GetObject("barButtonItem1.Glyph"), System.Drawing.Image))
            Me.barButtonItem1.Id = 1
            Me.barButtonItem1.LargeGlyph = (DirectCast(resources.GetObject("barButtonItem1.LargeGlyph"), System.Drawing.Image))
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Main"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem1)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "Export"
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013 Light Gray"
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.DataMember = "SalesPerson"
            Me.pivotGridControl1.DataSource = Me.nwindDataSet
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCountry1, Me.fieldProductName1, Me.fieldCategoryName1, Me.fieldExtendedPrice1, Me.fieldSalesPerson1})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 147)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.Size = New System.Drawing.Size(698, 310)
            Me.pivotGridControl1.TabIndex = 1
            ' 
            ' nwindDataSet
            ' 
            Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' fieldCountry1
            ' 
            Me.fieldCountry1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldCountry1.AreaIndex = 0
            Me.fieldCountry1.FieldName = "Country"
            Me.fieldCountry1.Name = "fieldCountry1"
            ' 
            ' fieldProductName1
            ' 
            Me.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName1.AreaIndex = 1
            Me.fieldProductName1.FieldName = "ProductName"
            Me.fieldProductName1.Name = "fieldProductName1"
            ' 
            ' fieldCategoryName1
            ' 
            Me.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName1.AreaIndex = 0
            Me.fieldCategoryName1.FieldName = "CategoryName"
            Me.fieldCategoryName1.Name = "fieldCategoryName1"
            ' 
            ' fieldExtendedPrice1
            ' 
            Me.fieldExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice1.AreaIndex = 0
            Me.fieldExtendedPrice1.FieldName = "Extended Price"
            Me.fieldExtendedPrice1.Name = "fieldExtendedPrice1"
            ' 
            ' fieldSalesPerson1
            ' 
            Me.fieldSalesPerson1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldSalesPerson1.AreaIndex = 1
            Me.fieldSalesPerson1.FieldName = "Sales Person"
            Me.fieldSalesPerson1.Name = "fieldSalesPerson1"
            ' 
            ' salesPersonTableAdapter1
            ' 
            Me.salesPersonTableAdapter1.ClearBeforeFill = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(698, 457)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Form1"
            Me.Ribbon = Me.ribbonControl1
            Me.Text = "DevExpress Pivot Grid control"
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private WithEvents barButtonItem1 As DevExpress.XtraBars.BarButtonItem
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
        Private nwindDataSet As Data.nwindDataSet
        Private fieldCountry1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldCategoryName1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldExtendedPrice1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldSalesPerson1 As DevExpress.XtraPivotGrid.PivotGridField
        Private salesPersonTableAdapter1 As Data.nwindDataSetTableAdapters.SalesPersonTableAdapter
    End Class
End Namespace


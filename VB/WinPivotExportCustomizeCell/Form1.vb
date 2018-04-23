﻿Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraBars

Namespace WinPivotExportCustomizeCell
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
            ' This line of code is generated by Data Source Configuration Wizard
            salesPersonTableAdapter1.Fill(nwindDataSet.SalesPerson)
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.salesPersonTableAdapter1.Fill(Me.nwindDataSet.SalesPerson)
        End Sub

        Private Sub barButtonItem1_ItemClick(ByVal sender As Object,
                                ByVal e As ItemClickEventArgs) Handles barButtonItem1.ItemClick
            '            #Region "#filepathCreating"
            Dim filePath As String
            Dim saveDialog = New SaveFileDialog()
            saveDialog.DefaultExt = "xlsx"
            saveDialog.FileName = "PivotGrid.xlsx"
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            saveDialog.ShowDialog()
            filePath = saveDialog.FileName
            '            #End Region

            Dim exportOptions = New PivotXlsxExportOptions()
            AddHandler exportOptions.CustomizeCell, AddressOf exportOptions_CustomizeCell
            If filePath <> "" Then
                pivotGridControl1.ExportToXlsx(filePath, exportOptions)
            End If
        End Sub

        Private Sub exportOptions_CustomizeCell(ByVal e As CustomizePivotCellEventArgs)
            If e.ExportArea = PivotExportArea.Data Then
                e.Formatting.BackColor = Color.Azure
                e.Formatting.Font.Italic = True
            End If
            e.Handled = True
        End Sub
    End Class
End Namespace

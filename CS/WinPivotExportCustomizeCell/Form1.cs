﻿using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraBars;

namespace WinPivotExportCustomizeCell {
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        public Form1() {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            salesPersonTableAdapter1.Fill(nwindDataSet.SalesPerson);
        }

        private void Form1_Load(object sender, EventArgs e) {
            this.salesPersonTableAdapter1.Fill(this.nwindDataSet.SalesPerson);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e) {
            #region #filepathCreating
            string filePath;
            var saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xlsx";
            saveDialog.FileName = "PivotGrid.xlsx";
            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveDialog.ShowDialog();
            filePath = saveDialog.FileName;
            #endregion

            var exportOptions = new PivotXlsxExportOptions();
            exportOptions.CustomizeCell += 
                new CustomizePivotCellEventHandler(exportOptions_CustomizeCell);
            if (filePath != "") {
                pivotGridControl1.ExportToXlsx(filePath, exportOptions);
            }
        }

        void exportOptions_CustomizeCell(CustomizePivotCellEventArgs e) {
            if (e.ExportArea == PivotExportArea.Data) {
                e.Formatting.BackColor = Color.Azure;
                e.Formatting.Font.Italic = true; 
            }
            e.Handled = true;
        }
    }
}

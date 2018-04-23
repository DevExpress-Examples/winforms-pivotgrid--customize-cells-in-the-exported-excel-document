# How to customize a cell in the exported Excel document


<p>When exporting a Pivot Grid control to XLSX (or XLS) format, you can customize a cell appearance in the exported document using the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotXlsxExportOptions_CustomizeCelltopic">PivotXlsxExportOptions.CustomizeCell</a> (or <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotXlsExportOptions_CustomizeCelltopic">PivotXlsExportOptions.CustomizeCell</a><u>)</u> event.</p>
<p>In this example, custom appearance settings (the azure background and italic font) are applied to the cells that correspond to the Pivot Grid's data area. The <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridCustomizePivotCellEventArgs_ExportAreatopic">CustomizePivotCellEventArgs.ExportArea</a> property is used to identify cell location in the exported Excel document. The cell format is set by the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridCustomizePivotCellEventArgs_Formattingtopic">CustomizePivotCellEventArgs.Formatting</a> property.</p>

<br/>



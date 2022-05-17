<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581814/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T424327)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WinPivotExportCustomizeCell/Form1.cs) (VB: [Form1.vb](./VB/WinPivotExportCustomizeCell/Form1.vb))
<!-- default file list end -->
# How to customize a cell in the exported Excel document


<p>When exporting a Pivot Grid control to XLSX (or XLS) format, you can customize a cell appearance in the exported document using the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotXlsxExportOptions_CustomizeCelltopic">PivotXlsxExportOptions.CustomizeCell</a> (or <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotXlsExportOptions_CustomizeCelltopic">PivotXlsExportOptions.CustomizeCell</a><u>)</u> event.</p>
<p>In this example, custom appearance settings (the azure background and italic font) are applied to the cells that correspond to the Pivot Grid's data area. The <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridCustomizePivotCellEventArgs_ExportAreatopic">CustomizePivotCellEventArgs.ExportArea</a> property is used to identify cell location in the exported Excel document. The cell format is set by the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridCustomizePivotCellEventArgs_Formattingtopic">CustomizePivotCellEventArgs.Formatting</a> property.</p>

<br/>



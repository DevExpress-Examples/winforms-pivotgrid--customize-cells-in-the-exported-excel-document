<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581814/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T424327)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Pivot Grid for WinForms - Сustomize Сells in the Exported Excel Document

The following example shows how to customize cell appearance in the exported document when you export the Pivot Grid to XLSX (or XLS) format. In this example, custom appearance settings (the azure background and italic font) are applied to the cells that correspond to the Pivot Grid's data area.

![Pivot Grid](images/pivotgrid.png)

## Files to Review

[Form1.cs](./CS/WinPivotExportCustomizeCell/Form1.cs) (VB: [Form1.vb](./VB/WinPivotExportCustomizeCell/Form1.vb))

## Example Overview

Handle the [PivotXlsxExportOptions.CustomizeCell](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotXlsxExportOptions.CustomizeCell) or [PivotXlsExportOptions.CustomizeCell](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotXlsExportOptions.CustomizeCell) event to customize cell appearance in the exported document.

Use the [e.ExportArea](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.CustomizePivotCellEventArgs.ExportArea) property to identify the cell location in the exported Excel document. The [e.Formatting](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.CustomizePivotCellEventArgs.Formatting) property sets the cell format. 

## Documentation

- [Exporting](https://docs.devexpress.com/WindowsForms/1800/controls-and-libraries/pivot-grid/printing-and-exporting/exporting)
- [Data Area](https://docs.devexpress.com/WindowsForms/1693/controls-and-libraries/pivot-grid/ui-elements/data-area)

## More Examples

[WinForms - How to Print a Document that Contains Pivot and Chart Controls](https://github.com/DevExpress-Examples/winforms-print-pivot-and-chart-controls)



<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivotgrid--customize-cells-in-the-exported-excel-document&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-pivotgrid--customize-cells-in-the-exported-excel-document&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

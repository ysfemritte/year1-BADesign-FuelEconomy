Add-Type -AssemblyName System.Windows.Forms
. (Join-Path $PSScriptRoot 'Form1.designer.ps1')
$Form1.ShowDialog()
$Button1_Click = {
$Label2.Text = "Hola mundo"
}
Add-Type -AssemblyName System.Windows.Forms
. (Join-Path $PSScriptRoot 'form01.designer.ps1')
$Form1.ShowDialog()
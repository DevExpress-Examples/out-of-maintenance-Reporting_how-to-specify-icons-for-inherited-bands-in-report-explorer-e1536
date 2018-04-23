Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace BandIcon
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim report As New XtraReport()
			Dim band As New MyBand()
			report.Bands.Add(band)
			report.ShowDesignerDialog()
			Me.Close()
		End Sub
	End Class
	<ToolboxBitmap("XRDetailBand.gif")> _
	Friend Class MyBand
		Inherits DetailBand
	End Class
End Namespace
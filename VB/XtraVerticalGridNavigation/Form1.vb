Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Windows.Forms

Namespace XtraVerticalGridNavigation
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			myVGridControl1.DataSource = CreateTable(50)
		End Sub

		Public Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl = New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(DateTime))
			For i = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) })
			Next i
			Return tbl
		End Function

		Private Sub chUseNavigator_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chUseNavigator.CheckedChanged
			myVGridControl1.UseEmbeddedNavigator = (TryCast(sender, CheckBox)).Checked
		End Sub
	End Class
End Namespace

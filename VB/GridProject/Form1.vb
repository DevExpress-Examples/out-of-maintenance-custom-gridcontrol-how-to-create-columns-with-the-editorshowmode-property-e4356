Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports Helpers
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports ExtendedGridViewSpace
Imports DevExpress.XtraGrid.Views.Base

Namespace GridProject
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			Dim dh As New DataHelper(DSparametr.simpleDS)
			extendedGridControl1.DataSource = dh.DataSet
			extendedGridControl1.DataMember = dh.DataMember

			extendedGridControl1.ForceInitialize()

			CType(extendedGridView1.Columns(0), ExtendedGridColumn).EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp
			CType(extendedGridView1.Columns(1), ExtendedGridColumn).EditorShowMode = DevExpress.Utils.EditorShowMode.Click
			CType(extendedGridView1.Columns(2), ExtendedGridColumn).EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown

		End Sub
	End Class
End Namespace
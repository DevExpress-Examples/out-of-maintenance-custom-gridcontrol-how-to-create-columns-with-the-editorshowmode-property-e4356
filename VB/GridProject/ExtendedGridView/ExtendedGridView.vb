Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils

Namespace ExtendedGridViewSpace
	<System.ComponentModel.DesignerCategory("")> _
	Public Class ExtendedGridView
		Inherits GridView

		Public Sub New()
		End Sub
		Public Sub New(ByVal ownerGrid As GridControl)
			MyBase.New(ownerGrid)

		End Sub

		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "ExtendedGridView"
			End Get
		End Property

		Public Overrides Function GetShowEditorMode() As EditorShowMode
			Dim col As ExtendedGridColumn = TryCast(FocusedColumn, ExtendedGridColumn)
			If col IsNot Nothing Then
				Return col.EditorShowMode
			End If
			Return MyBase.GetShowEditorMode()
		End Function

		Protected Overrides Function CreateColumnCollection() As GridColumnCollection
			Dim columns As GridColumnCollection = New ExtendedGridColumnCollection(Me)
			Return columns
		End Function
	End Class
End Namespace
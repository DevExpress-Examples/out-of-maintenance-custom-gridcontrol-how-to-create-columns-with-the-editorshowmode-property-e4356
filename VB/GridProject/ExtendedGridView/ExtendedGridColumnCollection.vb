Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base

Namespace ExtendedGridViewSpace
	Public Class ExtendedGridColumnCollection
		Inherits GridColumnCollection

		Public Sub New(ByVal view As ColumnView)
			MyBase.New(view)
		End Sub

		Protected Overrides Function CreateColumn() As GridColumn
			Return New ExtendedGridColumn()
		End Function
	End Class
End Namespace

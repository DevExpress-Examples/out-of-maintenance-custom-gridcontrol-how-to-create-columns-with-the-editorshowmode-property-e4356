Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils

Namespace ExtendedGridViewSpace
	<System.ComponentModel.DesignerCategory("")>
	Public Class ExtendedGridColumn
		Inherits GridColumn

		Public Sub New()
			EditorShowMode = DevExpress.Utils.EditorShowMode.Default
		End Sub

		Public Property EditorShowMode() As EditorShowMode

	End Class
End Namespace

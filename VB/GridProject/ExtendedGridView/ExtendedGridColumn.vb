Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils

Namespace ExtendedGridViewSpace
	<System.ComponentModel.DesignerCategory("")> _
	Public Class ExtendedGridColumn
		Inherits GridColumn
		Public Sub New()
			EditorShowMode = DevExpress.Utils.EditorShowMode.Default
		End Sub

		Private privateEditorShowMode As EditorShowMode
		Public Property EditorShowMode() As EditorShowMode
			Get
				Return privateEditorShowMode
			End Get
			Set(ByVal value As EditorShowMode)
				privateEditorShowMode = value
			End Set
		End Property

	End Class
End Namespace

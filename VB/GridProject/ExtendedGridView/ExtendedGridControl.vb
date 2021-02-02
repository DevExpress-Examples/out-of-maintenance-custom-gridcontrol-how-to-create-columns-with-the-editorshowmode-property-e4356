Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Registrator


Namespace ExtendedGridViewSpace
	<System.ComponentModel.DesignerCategory("")>
	Public Class ExtendedGridControl
		Inherits GridControl

		Protected Overrides Sub RegisterAvailableViewsCore(ByVal collection As InfoCollection)
			MyBase.RegisterAvailableViewsCore(collection)
			collection.Add(New ExtendedGridViewInfoRegistrator())
		End Sub
	End Class
End Namespace

Imports Microsoft.VisualBasic
Imports System
Namespace GridProject
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.extendedGridControl1 = New ExtendedGridViewSpace.ExtendedGridControl()
			Me.extendedGridView1 = New ExtendedGridViewSpace.ExtendedGridView()
			CType(Me.extendedGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.extendedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' extendedGridControl1
			' 
			Me.extendedGridControl1.Location = New System.Drawing.Point(29, 38)
			Me.extendedGridControl1.MainView = Me.extendedGridView1
			Me.extendedGridControl1.Name = "extendedGridControl1"
			Me.extendedGridControl1.Size = New System.Drawing.Size(521, 369)
			Me.extendedGridControl1.TabIndex = 0
			Me.extendedGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.extendedGridView1})
			' 
			' extendedGridView1
			' 
			Me.extendedGridView1.GridControl = Me.extendedGridControl1
			Me.extendedGridView1.Name = "extendedGridView1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(601, 584)
			Me.Controls.Add(Me.extendedGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.extendedGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.extendedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private extendedGridControl1 As ExtendedGridViewSpace.ExtendedGridControl
		Private extendedGridView1 As ExtendedGridViewSpace.ExtendedGridView


	End Class
End Namespace


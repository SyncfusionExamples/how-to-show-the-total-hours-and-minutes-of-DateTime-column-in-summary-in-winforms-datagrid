Imports Microsoft.VisualBasic
Imports System
Namespace CustomSummarries
	Partial Public Class Form2
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
			Me.sfDataGrid = New Syncfusion.WinForms.DataGrid.SfDataGrid()
			CType(Me.sfDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' sfDataGrid
			' 
			Me.sfDataGrid.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.sfDataGrid.AccessibleName = "Table"
			Me.sfDataGrid.AllowDraggingColumns = True
			Me.sfDataGrid.AllowEditing = False
			Me.sfDataGrid.AllowFiltering = True
			Me.sfDataGrid.AutoExpandGroups = True
			Me.sfDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill
			Me.sfDataGrid.BackColor = System.Drawing.SystemColors.Window
			Me.sfDataGrid.Location = New System.Drawing.Point(12, 12)
			Me.sfDataGrid.Name = "sfDataGrid"
			Me.sfDataGrid.ShowGroupDropArea = True
			Me.sfDataGrid.AllowResizingColumns = True
			Me.sfDataGrid.AllowResizingHiddenColumns = True
			Me.sfDataGrid.Size = New System.Drawing.Size(722, 467)
			Me.sfDataGrid.TabIndex = 1
			' 
			' Form2
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(746, 491)
			Me.Controls.Add(Me.sfDataGrid)
			Me.Name = "Form2"
			Me.Text = "Form2"
			CType(Me.sfDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private sfDataGrid As Syncfusion.WinForms.DataGrid.SfDataGrid
	End Class
End Namespace
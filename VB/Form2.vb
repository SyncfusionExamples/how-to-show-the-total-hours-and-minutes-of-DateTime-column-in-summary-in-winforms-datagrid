Imports Microsoft.VisualBasic
Imports Syncfusion.Data
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Collections
Imports Syncfusion.WinForms.DataGrid

Namespace CustomSummarries

	Partial Public Class Form2
		Inherits Form
		Public Sub New()
			InitializeComponent()
			Me.sfDataGrid.DataSource = Me.CreateTable()
			Me.sfDataGrid.TableSummaryRows.Add(New GridTableSummaryRow() With {.Name = "tableSumamryTrue", .ShowSummaryInRow = False, .Title = "Total :  {TotalTime}", .SummaryColumns = New System.Collections.ObjectModel.ObservableCollection(Of Syncfusion.Data.ISummaryColumn) (New Syncfusion.Data.ISummaryColumn() {New GridSummaryColumn() With {.Name = "TotalTime", .CustomAggregate = New CustomSummary(), .SummaryType=SummaryType.Custom, .Format="Total time : {TotalHours}", .MappingName="Time in minutes"}})})
		End Sub

		#region "Create DataTable"
		Private name1() As String = { "John", "Peter", "Smith", "Jay", "Krish", "Mike" }
		Private country() As String = { "UK", "USA", "Pune", "India", "China", "England" }
		Private city() As String = { "Graz", "Resende", "Bruxelles", "Aires", "Rio de janeiro", "Campinas" }
		Private scountry() As String = { "Brazil", "Belgium", "Austria", "Argentina", "France", "Beiging" }
		Private dt As New DataTable()
		Private r As New Random()
		Private Function CreateTable() As DataTable

			dt.Columns.Add("Name")
			dt.Columns.Add("Id")
			dt.Columns.Add("Time in minutes", GetType(Integer))
			dt.Columns.Add("Country")
			dt.Columns.Add("Ship City")
			dt.Columns.Add("Ship Country")


            For l As Integer = 0 To 100
                Dim dr As System.Data.DataRow = dt.NewRow()
                dr(0) = name1(r.Next(0, 5))
                dr(1) = "E" & r.Next(30)
                dr(2) = r.Next(30, 60)
                dr(3) = country(r.Next(0, 5))
                dr(4) = city(r.Next(0, 5))
                dr(5) = scountry(r.Next(0, 5))
                dt.Rows.Add(dr)
            Next l

			Return dt
		End Function

		#End Region
	End Class

End Namespace

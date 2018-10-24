Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001-2018."
' Copyright Syncfusion Inc. 2001-2018. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.Collections.ObjectModel

Namespace CustomSummarries
	Public Class SalesInfoCollection
		Public Sub New()
			_SalesDetails = GetSalesInfo()
		End Sub

		Private _SalesDetails As ObservableCollection(Of SalesByYear) = Nothing

		Public ReadOnly Property YearlySalesDetails() As ObservableCollection(Of SalesByYear)
			Get
				Return _SalesDetails
			End Get

		End Property

		''' <summary>
		''' Gets the supplier info.
		''' </summary>
		''' <returns></returns>
		Public Function GetSalesInfo() As ObservableCollection(Of SalesByYear)
			Dim sales = New ObservableCollection(Of SalesByYear)()
			Dim i As Integer = 0
			''' <summary>
			''' Collection of ProductNames
			''' </summary>
			Dim productName() As String = { "Alice Mutton", "NuNuCa Nuß-Nougat-Creme", "Boston Crab Meat", "Raclette Courdavault", "Wimmers gute", "Gorgonzola Telino", "Chartreuse verte", "Fløtemysost", "Carnarvon Tigers", "Thüringer", "Vegie-spread", "Tarte au sucre", "Konbu", "Valkoinen suklaa", "Queso Manchego", "Perth Pasties", "Vegie-spread", "Tofu", "Sir Rodney's", "Manjimup Dried Apples" }

			Dim r = New Random()
			Do While i < 101
				Dim salesByYear = New SalesByYear() With {.Name = productName(r.Next(0, 11)), .Q1 = r.Next(10000, 100000) * 0.01, .Q2 = r.Next(10000, 100000) * 0.01, .Q3 = r.Next(10000, 100000) * 0.01, .Q4 = r.Next(10000, 100000) * 0.01, .Year = r.Next(2000, 2010)}

				salesByYear.Total = salesByYear.Q1 + salesByYear.Q2 + salesByYear.Q3 + salesByYear.Q4
				sales.Add(salesByYear)
				i += 1
			Loop

			Return sales
		End Function
	End Class
End Namespace

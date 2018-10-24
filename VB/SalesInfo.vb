Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001-2018."
' Copyright Syncfusion Inc. 2001-2018. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Namespace CustomSummarries
	''' <summary>
	''' Sales details for an year. 
	''' </summary>
	Public Class SalesByYear
		Implements INotifyPropertyChanged
		#Region "Fields"

'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not allow class members with the same name:
		Private name_Renamed As String
'INSTANT VB NOTE: The variable q1 was renamed since Visual Basic does not allow class members with the same name:
		Private q1_Renamed As Double
'INSTANT VB NOTE: The variable q2 was renamed since Visual Basic does not allow class members with the same name:
		Private q2_Renamed As Double
'INSTANT VB NOTE: The variable q3 was renamed since Visual Basic does not allow class members with the same name:
		Private q3_Renamed As Double
'INSTANT VB NOTE: The variable q4 was renamed since Visual Basic does not allow class members with the same name:
		Private q4_Renamed As Double
		Private _total As Double
		Private _year As Integer

		#End Region

		''' <summary>
		''' Gets or sets the name.
		''' </summary>
		''' <value>The name.</value>
		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				name_Renamed = value
				OnPropertyChanged("Name")
			End Set
		End Property

		''' <summary>
		''' Gets or sets the Q1.
		''' </summary>
		''' <value>The Q1.</value>   
		<DataType(DataType.Currency)> _
		Public Property Q1() As Double
			Get
				Return q1_Renamed
			End Get
			Set(ByVal value As Double)
				q1_Renamed = value
				OnPropertyChanged("Q1")
			End Set
		End Property

		''' <summary>
		''' Gets or sets the Q2.
		''' </summary>
		''' <value>The Q2.</value>
		<DataType(DataType.Currency)> _
		Public Property Q2() As Double
			Get
				Return q2_Renamed
			End Get
			Set(ByVal value As Double)
				q2_Renamed = value
				OnPropertyChanged("Q2")
			End Set
		End Property

		''' <summary>
		''' Gets or sets the Q3.
		''' </summary>
		''' <value>The Q3.</value>
		<DataType(DataType.Currency)> _
		Public Property Q3() As Double
			Get
				Return q3_Renamed
			End Get
			Set(ByVal value As Double)
				q3_Renamed = value
				OnPropertyChanged("Q3")
			End Set
		End Property

		''' <summary>
		''' Gets or sets the Q4.
		''' </summary>
		''' <value>The Q4.</value>
		<DataType(DataType.Currency)> _
		Public Property Q4() As Double
			Get
				Return q4_Renamed
			End Get
			Set(ByVal value As Double)
				q4_Renamed = value
				OnPropertyChanged("Q4")
			End Set
		End Property

		''' <summary>
		''' Gets or sets the total.
		''' </summary>
		''' <value>The total.</value>
		<DataType(DataType.Currency), Display(Name := "Total Sales")> _
		Public Property Total() As Double
			Get
				Return _total
			End Get
			Set(ByVal value As Double)
				_total = value
				OnPropertyChanged("Total")
			End Set
		End Property

		''' <summary>
		''' Gets or sets the year.
		''' </summary>
		''' <value>The year.</value>
		Public Property Year() As Integer
			Get
				Return _year
			End Get
			Set(ByVal value As Integer)
				_year = value
				OnPropertyChanged("Year")
			End Set
		End Property

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Private Sub OnPropertyChanged(ByVal propertyName As String)
			If PropertyChangedEvent IsNot Nothing Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
			End If
		End Sub
	End Class
End Namespace

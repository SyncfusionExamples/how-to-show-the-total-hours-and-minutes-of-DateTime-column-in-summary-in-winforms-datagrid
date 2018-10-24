Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001-2018."
' Copyright Syncfusion Inc. 2001-2018. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Syncfusion.Data
Imports System.Data
Imports System.Collections
Imports System.ComponentModel

Namespace CustomSummarries
	Public Class CustomSummary
		Implements ISummaryAggregate
		Public Sub New()
		End Sub
        Private _totalHours As String
        Public Property TotalHours() As String
            Get
                Return _totalHours
            End Get
            Set(ByVal value As String)
                _totalHours = value
            End Set
        End Property
        Public Function CalculateAggregateFunc() As Action(Of IEnumerable, String, PropertyDescriptor) Implements ISummaryAggregate.CalculateAggregateFunc
            Return Sub(items, [property], pd)
                       If pd.Name = "TotalHours" Then
                           Dim total As Integer = 0
                           For Each item In items
                               Dim dr As DataRowView = TryCast(item, DataRowView)
                               total += Integer.Parse(dr("Time in minutes").ToString())
                           Next item
                           Me._totalHours = total \ 60 & " Hours : " & total Mod 60 & " minutes"
                       End If
                   End Sub
        End Function
	End Class
End Namespace

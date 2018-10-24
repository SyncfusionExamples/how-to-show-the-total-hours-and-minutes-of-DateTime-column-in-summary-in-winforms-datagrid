Public Class CustomSummary
    Implements ISummaryAggregate

    Public Sub New()
    End Sub

    Private date As String

    Public Property Date As String
        Get
            Return date
        End Get
        Set(ByVal value As String)
            date = value
        End Set
    End Property

    Public Function CalculateAggregateFunc() As Action(Of IEnumerable, String, PropertyDescriptor) Implements ISummaryAggregate.CalculateAggregateFunc
        Return Sub(items, [property], pd)
                   Dim enumerableItems = TryCast(items, IEnumerable(Of SalesByYear))

                   If pd.Name Is "Date" Then
                       Dim t As TimeSpan = New TimeSpan(0, 0, 0)
                       Dim ts As TimeSpan
                       Dim dTime As DateTime

                       For Each item In items
                           Dim dr As DataRowView = TryCast(item, DataRowView)

                           If DateTime.TryParse(dr("Date").ToString(), dTime) Then
                               ts = New TimeSpan(dTime.Hour, dTime.Minute, 0)
                               t = t.Add(ts)
                           End If
                       Next

                       Dim hours As Integer = CInt(t.TotalMinutes) / 60
                       Dim min As Integer = CInt(t.TotalMinutes) Mod 60
                       Me.Date = hours & ":" & min
                   End If
               End Sub
    End Function
End Class
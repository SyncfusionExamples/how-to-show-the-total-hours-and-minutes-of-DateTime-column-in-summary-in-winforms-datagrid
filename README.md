# How to show the total summary value in DateTime format using custom aggregate in WinForms DataGrid (SfDataGrid)

## Show the total summary value in DateTime format
You can implement your own summary aggregate functions using the [GridSummaryColumn.CustomAggregate](https://help.syncfusion.com/cr/windowsforms/Syncfusion.WinForms.DataGrid.GridSummaryColumn.html#Syncfusion_WinForms_DataGrid_GridSummaryColumn_CustomAggregate) property when built-in aggregate functions do not meet your requirement. The summary value can be calculated based on any custom logic.

In the following example, the Time column of data grid displays time in minutes. The custom summary aggregate for the summary column is created to display the total time in HH:MM format.

## C#  

```C#  

public Form2()
{
    InitializeComponent();
    this.sfDataGrid.DataSource = this.CreateTable();
    this.sfDataGrid.TableSummaryRows.Add(new GridTableSummaryRow()
    {
        Name = "tableSumamryTrue",
        ShowSummaryInRow = false,
        Title = "Total :  {TotalTime}",
        SummaryColumns = new System.Collections.ObjectModel.ObservableCollection<Syncfusion.Data.ISummaryColumn>()
        {
            new GridSummaryColumn()
            {
                Name = "TotalTime",
               CustomAggregate=new CustomSummary(),
                SummaryType=SummaryType.Custom,
                Format="Total time : {TotalHours}",
                MappingName="Time in minutes"
            },
        }
    });
}
 
public class CustomSummary : ISummaryAggregate
{
    public CustomSummary()
    { }
    private string totalHours;
    public string TotalHours { get { return totalHours; } set { totalHours = value; } }
    public Action<IEnumerable, string, PropertyDescriptor> CalculateAggregateFunc()
    {
        return (items, property, pd) =>
        {
            var enumerableItems = items as IEnumerable<SalesByYear>;
 
            //To check the summary format of the summary row.
            if (pd.Name == "TotalHours")
            {
                int total = 0;
                foreach (var item in items)
                {
                    DataRowView dr = item as DataRowView;
                    total += int.Parse(dr["Time in minutes"].ToString());
                }
 
                this.totalHours = total / 60 + " Hours : " + total % 60 + " minutes";
            }
        };
    }
}
```
## VB

```VB

Public Sub New()
 InitializeComponent()
 Me.sfDataGrid.DataSource = Me.CreateTable()
 Me.sfDataGrid.TableSummaryRows.Add(New GridTableSummaryRow() With {.Name = "tableSumamryTrue", .ShowSummaryInRow = False, .Title = "Total :  {TotalTime}", .SummaryColumns =      New System.Collections.ObjectModel.ObservableCollection(Of Syncfusion.Data.ISummaryColumn) (New Syncfusion.Data.ISummaryColumn() {New GridSummaryColumn() With {.Name = "TotalTime",     .CustomAggregate = New CustomSummary(), .SummaryType=SummaryType.Custom, .Format="Total time : {TotalHours}", .MappingName="Time in minutes"}})})
End Sub
 
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
```
 
using Syncfusion.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Syncfusion.WinForms.DataGrid;

namespace CustomSummarries

{
    public partial class Form2 : Form
    {
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

        #region "Create DataTable"
        string[] name1 = new string[] { "John", "Peter", "Smith", "Jay", "Krish", "Mike" };
        string[] country = new string[] { "UK", "USA", "Pune", "India", "China", "England" };
        string[] city = new string[] { "Graz", "Resende", "Bruxelles", "Aires", "Rio de janeiro", "Campinas" };
        string[] scountry = new string[] { "Brazil", "Belgium", "Austria", "Argentina", "France", "Beiging" };
        DataTable dt = new DataTable();
        Random r = new Random();
        private DataTable CreateTable()
        {

            dt.Columns.Add("Name");
            dt.Columns.Add("Id");
            dt.Columns.Add("Time in minutes", typeof(int));
            dt.Columns.Add("Country");
            dt.Columns.Add("Ship City");
            dt.Columns.Add("Ship Country");
            

            for (int l = 0; l < 100; l++)
            {
                System.Data.DataRow dr = dt.NewRow();
                dr[0] = name1[r.Next(0, 5)];
                dr[1] = "E" + r.Next(30);
                dr[2] = r.Next(30,60);
                dr[3] = country[r.Next(0, 5)];
                dr[4] = city[r.Next(0, 5)];
                dr[5] = scountry[r.Next(0, 5)];
                dt.Rows.Add(dr);
            }

            return dt;
        }

        #endregion
    }

}

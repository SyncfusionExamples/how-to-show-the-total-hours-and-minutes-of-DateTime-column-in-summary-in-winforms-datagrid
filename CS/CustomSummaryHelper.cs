#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Data;
using System.Data;
using System.Collections;
using System.ComponentModel;

namespace CustomSummarries
{
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
}

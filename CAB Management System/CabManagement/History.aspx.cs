using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CAB_Management_System.CabManagement
{
    public partial class History : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool bDailyRequest = true;
            bool bWeeklyRequest = true;

            if (bWeeklyRequest)
            {
                gvWeeklyResponse.Visible = true;
                DataSet ds = new DataSet();
                DataTable WeeklyTrip = new DataTable();

                WeeklyTrip.Columns.Add("strDate", Type.GetType("System.String"));
                WeeklyTrip.Columns.Add("strPickupLocation", Type.GetType("System.String"));
                WeeklyTrip.Columns.Add("strPickupTime", Type.GetType("System.String"));
                WeeklyTrip.Columns.Add("strDropLocation", Type.GetType("System.String"));
                WeeklyTrip.Columns.Add("strDropTime", Type.GetType("System.String"));
                WeeklyTrip.Columns.Add("strTripType", Type.GetType("System.String"));

                DataRow row1 = WeeklyTrip.NewRow();
                row1["strDate"] = "30/09/2015 [Wed]";
                row1["strPickupLocation"] = "Thambaram";
                row1["strPickupTime"] = "21:00";
                row1["strDropLocation"] = "RMZ";
                row1["strDropTime"] = "06:00";
                row1["strTripType"] = "Return";
                WeeklyTrip.Rows.Add(row1);

                DataRow row2 = WeeklyTrip.NewRow();
                row2["strDate"] = "01/10/2015 [Thurs]";
                row2["strPickupLocation"] = "Thambaram";
                row2["strPickupTime"] = "21:00";
                row2["strDropLocation"] = "RMZ";
                row2["strDropTime"] = "06:00";
                row2["strTripType"] = "Return";
                WeeklyTrip.Rows.Add(row2);

                DataRow row3 = WeeklyTrip.NewRow();
                row3["strDate"] = "02/10/2015 [Fri]";
                row3["strPickupLocation"] = "Thambaram";
                row3["strPickupTime"] = "21:00";
                row3["strDropLocation"] = "RMZ";
                row3["strDropTime"] = "06:00";
                row3["strTripType"] = "Return";
                WeeklyTrip.Rows.Add(row3);

                DataRow row4 = WeeklyTrip.NewRow();
                row4["strDate"] = "03/10/2015 [Sat]";
                row4["strPickupLocation"] = "Thambaram";
                row4["strPickupTime"] = "21:00";
                row4["strDropLocation"] = "RMZ";
                row4["strDropTime"] = "06:00";
                row4["strTripType"] = "Return";
                WeeklyTrip.Rows.Add(row4);

                DataRow row5 = WeeklyTrip.NewRow();
                row5["strDate"] = "04/10/2015 [Sun]";
                row5["strPickupLocation"] = "Thambaram";
                row5["strPickupTime"] = "21:00";
                row5["strDropLocation"] = "OTP";
                row5["strDropTime"] = "06:00";
                row5["strTripType"] = "Return";
                WeeklyTrip.Rows.Add(row5);

                DataRow row6 = WeeklyTrip.NewRow();
                row6["strDate"] = "05/10/2015 [Mon]";
                row6["strPickupLocation"] = "Thambaram";
                row6["strPickupTime"] = "21:00";
                row6["strDropLocation"] = "OTP";
                row6["strDropTime"] = "06:00";
                row6["strTripType"] = "Return";
                WeeklyTrip.Rows.Add(row6);

                DataRow row7 = WeeklyTrip.NewRow();
                row7["strDate"] = "06/10/2015 [Tues]";
                row7["strPickupLocation"] = "Thambaram";
                row7["strPickupTime"] = "21:00";
                row7["strDropLocation"] = "RMZ";
                row7["strDropTime"] = "06:00";
                row7["strTripType"] = "Return";
                WeeklyTrip.Rows.Add(row7);

                ds.Tables.Add(WeeklyTrip);
                gvWeeklyResponse.DataSource = ds;
                gvWeeklyResponse.DataBind();

            }

            if (bDailyRequest)
            {
                gvDailyResponse.Visible = true;

                var vTravelType = "BOTH";

                DataSet ds = new DataSet();
                DataTable DailyTrip = new DataTable();

                DailyTrip.Columns.Add("strRequestId", Type.GetType("System.String"));

                if (vTravelType == "PICKUP")
                {
                    DailyTrip.Columns.Add("strPickupDate", Type.GetType("System.String"));
                    DailyTrip.Columns.Add("strPickupTime", Type.GetType("System.String"));
                    DailyTrip.Columns.Add("strPickupLocation", Type.GetType("System.String"));
                }
                else if (vTravelType == "DROP")
                {
                    DailyTrip.Columns.Add("strDropDate", Type.GetType("System.String"));
                    DailyTrip.Columns.Add("strDropTime", Type.GetType("System.String"));
                    DailyTrip.Columns.Add("strDropLocation", Type.GetType("System.String"));
                }
                else
                {
                    DailyTrip.Columns.Add("strPickupDate", Type.GetType("System.String"));
                    DailyTrip.Columns.Add("strPickupTime", Type.GetType("System.String"));
                    DailyTrip.Columns.Add("strPickupLocation", Type.GetType("System.String"));
                    DailyTrip.Columns.Add("strDropDate", Type.GetType("System.String"));
                    DailyTrip.Columns.Add("strDropTime", Type.GetType("System.String"));
                    DailyTrip.Columns.Add("strDropLocation", Type.GetType("System.String"));
                }

                DataRow row1 = DailyTrip.NewRow();
                row1["strRequestId"] = "15698";

                if (vTravelType == "PICKUP")
                {
                    row1["strPickupDate"] = "30/09/2015 [Wed]";
                    row1["strPickupTime"] = "21:00";
                    row1["strPickupLocation"] = "Thambaram";
                }
                else if (vTravelType == "DROP")
                {
                    row1["strDropDate"] = "01/10/2015 [Wed]";
                    row1["strDropLocation"] = "Thambaram";
                    row1["strDropTime"] = "06:00";
                }
                else
                {
                    row1["strPickupDate"] = "30/09/2015 [Wed]";
                    row1["strPickupTime"] = "21:00";
                    row1["strPickupLocation"] = "Thambaram";
                    row1["strDropDate"] = "01/10/2015 [Wed]";
                    row1["strDropLocation"] = "Thambaram";
                    row1["strDropTime"] = "06:00";

                }
                DailyTrip.Rows.Add(row1);

                if (vTravelType == "DROP")
                {
                    gvDailyResponse.Columns[1].Visible = false;
                    gvDailyResponse.Columns[2].Visible = false;
                    gvDailyResponse.Columns[3].Visible = false;
                }
                else if (vTravelType == "PICKUP")
                {
                    gvDailyResponse.Columns[4].Visible = false;
                    gvDailyResponse.Columns[5].Visible = false;
                    gvDailyResponse.Columns[6].Visible = false;
                }

                ds.Tables.Add(DailyTrip);
                gvDailyResponse.DataSource = ds;
                gvDailyResponse.DataBind();

            }

            if (!bDailyRequest && !bWeeklyRequest)
            {
                Response.Write("Oops !! .. There is no Drives available for you");
            }
        }
        
    }
}
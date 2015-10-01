/*

 Designed and Developed by Kumaresan Ganesan
 
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CAB_Management_System
{
    public partial class CabRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SetTravelType(rdRequestType.SelectedItem.Text.ToString().ToUpper());
                SetRequestType(rdRequestType.SelectedItem.Text.ToString().ToUpper());
                BuildWeeklyRequest();
            }
        }

        protected void rdTravelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTravelType(rdRequestType.SelectedItem.Text.ToString().ToUpper());
        }

        protected void rdRequestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetRequestType(rdRequestType.SelectedItem.Text.ToString().ToUpper());
        }

        private void SetTravelType(string strRequestType)
        {
            var vTravelType = rdTravelType.SelectedItem.Text.ToUpper();

            if (strRequestType == "DAILY")
            {
                btnDailySave.Enabled = true;
                gvDailyResponse.Visible = false;

                if (vTravelType == "DROP")
                {
                    divDrop.Visible = true;
                    divPickup.Visible = false;
                }
                else if (vTravelType == "PICKUP")
                {
                    divDrop.Visible = false;
                    divPickup.Visible = true;
                }
                else
                {
                    divDrop.Visible = true;
                    divPickup.Visible = true;
                }
            }
            else
            {
                btnWeeklySave.Enabled = true;
                gvWeeklyResponse.Visible = false;

                if (vTravelType == "DROP")
                {
                    gvWeeklyRequest.Columns[0].Visible = false;
                    gvWeeklyRequest.Columns[1].Visible = false;
                    gvWeeklyRequest.Columns[2].Visible = false;

                    gvWeeklyRequest.Columns[3].Visible = true;
                    gvWeeklyRequest.Columns[4].Visible = true;
                    gvWeeklyRequest.Columns[5].Visible = true;

                    gvWeeklyRequest.Columns[6].Visible = false;
                    gvWeeklyRequest.Columns[7].Visible = false;
                }
                else if (vTravelType == "PICKUP")
                {
                    gvWeeklyRequest.Columns[0].Visible = true;
                    gvWeeklyRequest.Columns[1].Visible = true;
                    gvWeeklyRequest.Columns[2].Visible = true;
                    gvWeeklyRequest.Columns[3].Visible = false;
                    gvWeeklyRequest.Columns[4].Visible = false;
                    gvWeeklyRequest.Columns[5].Visible = false;
                    gvWeeklyRequest.Columns[6].Visible = false;
                    gvWeeklyRequest.Columns[7].Visible = false;
                }
                else
                {
                    gvWeeklyRequest.Columns[0].Visible = true;
                    gvWeeklyRequest.Columns[1].Visible = true;
                    gvWeeklyRequest.Columns[2].Visible = true;
                    gvWeeklyRequest.Columns[3].Visible = false;
                    gvWeeklyRequest.Columns[4].Visible = false;
                    gvWeeklyRequest.Columns[5].Visible = true;
                    gvWeeklyRequest.Columns[6].Visible = true;
                    gvWeeklyRequest.Columns[7].Visible = true;
                }
            }
        }

        private void SetRequestType(string strRequestType)
        {
            btnDailySave.Enabled = true;
            btnWeeklySave.Enabled = true;

            if (strRequestType == "DAILY")
            {
                fsDailyRequest.Visible = true;
                fsWeeklyRequest.Visible = false;
            }
            else
            {
                fsDailyRequest.Visible = false;
                fsWeeklyRequest.Visible = true;
                SetTravelType(strRequestType);
            }
        }

        private void BuildWeeklyRequest()
        {
            DataSet ds = new DataSet();
            DataTable WeeklyTrip = new DataTable();

            WeeklyTrip.Columns.Add("strPickupDate", Type.GetType("System.String"));
            WeeklyTrip.Columns.Add("strDropDate", Type.GetType("System.String"));
            WeeklyTrip.Columns.Add("strReturnDate", Type.GetType("System.String"));
            WeeklyTrip.Columns.Add("PickupLocation", Type.GetType("System.String"));
            WeeklyTrip.Columns.Add("DropLocation", Type.GetType("System.String"));

            DataRow row1 = WeeklyTrip.NewRow();
            row1["strPickupDate"] = "30/09/2015 [Wed]";
            row1["strDropDate"] = "30/09/2015 [Wed]";
            row1["strReturnDate"] = "30/09/2015 [Wed]";
            row1["PickupLocation"] = "Thambaram";
            row1["DropLocation"] = "RMZ";
            WeeklyTrip.Rows.Add(row1);

            DataRow row2 = WeeklyTrip.NewRow();
            row2["strPickupDate"] = "01/10/2015 [Thurs]";
            row2["strDropDate"] = "01/10/2015 [Thurs]";
            row2["strReturnDate"] = "01/10/2015 [Thurs]";
            row2["PickupLocation"] = "Thambaram";
            row2["DropLocation"] = "RMZ";
            WeeklyTrip.Rows.Add(row2);

            DataRow row3 = WeeklyTrip.NewRow();
            row3["strPickupDate"] = "02/10/2015 [Fri]";
            row3["strDropDate"] = "02/10/2015 [Fri]";
            row3["strReturnDate"] = "02/10/2015 [Fri]";
            row3["PickupLocation"] = "Thambaram";
            row3["DropLocation"] = "RMZ";
            WeeklyTrip.Rows.Add(row3);

            DataRow row4 = WeeklyTrip.NewRow();
            row4["strPickupDate"] = "03/10/2015 [Mon]";
            row4["strDropDate"] = "03/10/2015 [Mon]";
            row4["strReturnDate"] = "03/10/2015 [Mon]";
            row4["PickupLocation"] = "Thambaram";
            row4["DropLocation"] = "RMZ";
            WeeklyTrip.Rows.Add(row4);

            DataRow row5 = WeeklyTrip.NewRow();
            row5["strPickupDate"] = "04/10/2015 [Tues]";
            row5["strDropDate"] = "04/10/2015 [Tues]";
            row5["strReturnDate"] = "04/10/2015 [Tues]";
            row5["PickupLocation"] = "Thambaram";
            row5["DropLocation"] = "OTP";
            WeeklyTrip.Rows.Add(row5);

            ds.Tables.Add(WeeklyTrip);
            gvWeeklyRequest.DataSource = ds;
            ViewState["WeeklyRequest"] = ds;
            gvWeeklyRequest.DataBind();
        }

        protected void btnDailySave_Click(object sender, EventArgs e)
        {
            gvDailyResponse.Visible = true;
            btnDailySave.Enabled = false;

            var vTravelType = rdTravelType.SelectedItem.Text.ToUpper();

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
                gvDailyResponse.Columns[4].Visible = true;
                gvDailyResponse.Columns[5].Visible = true;
                gvDailyResponse.Columns[6].Visible = true;
            }
            else if (vTravelType == "PICKUP")
            {
                gvDailyResponse.Columns[1].Visible = true;
                gvDailyResponse.Columns[2].Visible = true;
                gvDailyResponse.Columns[3].Visible = true;
                gvDailyResponse.Columns[4].Visible = false;
                gvDailyResponse.Columns[5].Visible = false;
                gvDailyResponse.Columns[6].Visible = false;
            }
            else
            {
                gvDailyResponse.Columns[1].Visible = true;
                gvDailyResponse.Columns[2].Visible = true;
                gvDailyResponse.Columns[3].Visible = true;
                gvDailyResponse.Columns[4].Visible = true;
                gvDailyResponse.Columns[5].Visible = true;
                gvDailyResponse.Columns[6].Visible = true;
            }

            ds.Tables.Add(DailyTrip);
            gvDailyResponse.DataSource = ds;
            gvDailyResponse.DataBind();
        }

        protected void btnWeeklySave_Click(object sender, EventArgs e)
        {
            btnWeeklySave.Enabled = false;
            gvWeeklyResponse.Visible = true;

            DataSet ds = new DataSet();
            DataTable WeeklyTrip = new DataTable();

            var vTravelType = rdTravelType.SelectedItem.Text.ToUpper();
            var vRequestType = rdRequestType.SelectedItem.Text.ToUpper();

            WeeklyTrip.Columns.Add("strRequestId", Type.GetType("System.String"));

            if (vTravelType == "PICKUP")
            {
                WeeklyTrip.Columns.Add("strPickupDate", Type.GetType("System.String"));
                WeeklyTrip.Columns.Add("strPickupLocation", Type.GetType("System.String"));
                WeeklyTrip.Columns.Add("strPickupTime", Type.GetType("System.String"));
            }
            if (vTravelType == "DROP")
            {
                WeeklyTrip.Columns.Add("strDropLocation", Type.GetType("System.String"));
                WeeklyTrip.Columns.Add("strDropDate", Type.GetType("System.String"));
                WeeklyTrip.Columns.Add("strDropTime", Type.GetType("System.String"));
            }
            if (vTravelType == "BOTH")
            {
                WeeklyTrip.Columns.Add("strPickupDate", Type.GetType("System.String"));
                WeeklyTrip.Columns.Add("strPickupLocation", Type.GetType("System.String"));
                WeeklyTrip.Columns.Add("strPickupTime", Type.GetType("System.String"));

                WeeklyTrip.Columns.Add("strReturnDate", Type.GetType("System.String"));
                WeeklyTrip.Columns.Add("strReturnTime", Type.GetType("System.String"));
                WeeklyTrip.Columns.Add("strDropLocation", Type.GetType("System.String"));
            }

            DataRow row1 = WeeklyTrip.NewRow();
            row1["strRequestId"] = "13675";
            if (vTravelType == "PICKUP")
            {
                row1["strPickupDate"] = "30/09/2015 [Wed]";
                row1["strPickupLocation"] = "Thambaram";
                row1["strPickupTime"] = "21:00";
            }
            if (vTravelType == "DROP")
            {
                row1["strDropDate"] = "30/09/2015 [Wed]";
                row1["strDropTime"] = "21:00";
                row1["strDropLocation"] = "RMZ";
            }
            if (vTravelType == "BOTH")
            {
                row1["strPickupDate"] = "30/09/2015 [Wed]";
                row1["strPickupLocation"] = "Thambaram";
                row1["strPickupTime"] = "21:00";
                row1["strDropLocation"] = "RMZ";

                row1["strReturnDate"] = "01/10/2015 [Thurs]";
                row1["strReturnTime"] = "06:00";
            }
            WeeklyTrip.Rows.Add(row1);

            DataRow row2 = WeeklyTrip.NewRow();
            row2["strRequestId"] = "13676";
            if (vTravelType == "PICKUP")
            {
                row2["strPickupDate"] = "01/10/2015 [Thurs]";
                row2["strPickupLocation"] = "Thambaram";
                row2["strPickupTime"] = "21:00";
            }
            if (vTravelType == "DROP")
            {
                row2["strDropDate"] = "01/10/2015 [Thurs]";
                row2["strDropTime"] = "21:00";
                row2["strDropLocation"] = "RMZ";
            }
            if (vTravelType == "BOTH")
            {
                row2["strPickupDate"] = "01/10/2015 [Thurs]";
                row2["strPickupLocation"] = "Thambaram";
                row2["strPickupTime"] = "21:00";
                row2["strDropLocation"] = "RMZ";
                row2["strReturnDate"] = "02/10/2015 [Fri]";
                row2["strReturnTime"] = "06:00";
            }
            WeeklyTrip.Rows.Add(row2);

            DataRow row3 = WeeklyTrip.NewRow();
            row3["strRequestId"] = "13677";
            if (vTravelType == "PICKUP")
            {
                row3["strPickupDate"] = "02/10/2015 [Fri]";
                row3["strPickupLocation"] = "Thambaram";
                row3["strPickupTime"] = "21:00";
            }
            if (vTravelType == "DROP")
            {
                row3["strDropDate"] = "02/10/2015 [Fri]";
                row3["strDropTime"] = "21:00";
                row3["strDropLocation"] = "RMZ";
            }
            if (vTravelType == "BOTH")
            {
                row3["strPickupDate"] = "02/10/2015 [Fri]";
                row3["strPickupLocation"] = "Thambaram";
                row3["strPickupTime"] = "21:00";
                row3["strDropLocation"] = "RMZ";
                row3["strReturnDate"] = "03/10/2015 [Sat]";
                row3["strReturnTime"] = "06:00";
            }
            WeeklyTrip.Rows.Add(row3);

            DataRow row4 = WeeklyTrip.NewRow();
            row4["strRequestId"] = "13678";
            if (vTravelType == "PICKUP")
            {
                row4["strPickupDate"] = "03/10/2015 [Mon]";
                row4["strPickupLocation"] = "Thambaram";
                row4["strPickupTime"] = "21:00";
            }
            if (vTravelType == "DROP")
            {
                row4["strDropDate"] = "03/10/2015 [Mon]";
                row4["strDropTime"] = "21:00";
                row4["strDropLocation"] = "RMZ";
            }
            if (vTravelType == "BOTH")
            {
                row4["strPickupDate"] = "03/10/2015 [Mon]";
                row4["strPickupLocation"] = "Thambaram";
                row4["strPickupTime"] = "21:00";
                row4["strDropLocation"] = "RMZ";
                row4["strReturnDate"] = "04/10/2015 [Tues]";
                row4["strReturnTime"] = "06:00";
            }
            WeeklyTrip.Rows.Add(row4);

            DataRow row5 = WeeklyTrip.NewRow();
            row5["strRequestId"] = "13679";
            if (vTravelType == "PICKUP")
            {
                row5["strPickupDate"] = "04/10/2015 [Tues]";
                row5["strPickupLocation"] = "Thambaram";
                row5["strPickupTime"] = "21:00";
            }
            if (vTravelType == "DROP")
            {
                row5["strDropDate"] = "04/10/2015 [Tues]";
                row5["strDropTime"] = "21:00";
                row5["strDropLocation"] = "OTP";
            }
            if (vTravelType == "BOTH")
            {
                row5["strPickupDate"] = "04/10/2015 [Tues]";
                row5["strPickupLocation"] = "Thambaram";
                row5["strPickupTime"] = "21:00";
                row5["strDropLocation"] = "OTP";
                row5["strReturnDate"] = "05/10/2015 [Wed]";
                row5["strReturnTime"] = "06:00";
            }
            WeeklyTrip.Rows.Add(row5);

            if (vTravelType == "DROP")
            {
                gvWeeklyResponse.Columns[1].Visible = false;
                gvWeeklyResponse.Columns[2].Visible = false;
                gvWeeklyResponse.Columns[3].Visible = false;
                gvWeeklyResponse.Columns[4].Visible = true;
                gvWeeklyResponse.Columns[5].Visible = true;
                gvWeeklyResponse.Columns[6].Visible = true;
                gvWeeklyResponse.Columns[7].Visible = false;
                gvWeeklyResponse.Columns[8].Visible = false;
            }
            else if (vTravelType == "PICKUP")
            {
                gvWeeklyResponse.Columns[1].Visible = true;
                gvWeeklyResponse.Columns[2].Visible = true;
                gvWeeklyResponse.Columns[3].Visible = true;
                gvWeeklyResponse.Columns[4].Visible = false;
                gvWeeklyResponse.Columns[5].Visible = false;
                gvWeeklyResponse.Columns[6].Visible = false;
                gvWeeklyResponse.Columns[7].Visible = false;
                gvWeeklyResponse.Columns[8].Visible = false;
            }
            else
            {
                gvWeeklyResponse.Columns[1].Visible = true;
                gvWeeklyResponse.Columns[2].Visible = true;
                gvWeeklyResponse.Columns[3].Visible = true;
                gvWeeklyResponse.Columns[4].Visible = false;
                gvWeeklyResponse.Columns[5].Visible = false;
                gvWeeklyResponse.Columns[6].Visible = true;
                gvWeeklyResponse.Columns[7].Visible = true;
                gvWeeklyResponse.Columns[8].Visible = true;
            }

            ds.Tables.Add(WeeklyTrip);
            gvWeeklyResponse.DataSource = ds;
            gvWeeklyResponse.DataBind();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CAB_Management_System
{
    public partial class MyNextDrives : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool bDailyRequest = true;
            bool bWeeklyRequest = true;

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

                ViewState["DailyResponse"] = ds;
                BindGrid("DailyResponse");
            }

            if (bWeeklyRequest)
            {
                var vTravelType = "BOTH";

                gvWeeklyResponse.Visible = true;

                DataSet ds = new DataSet();
                DataTable WeeklyTrip = new DataTable();

                WeeklyTrip.Columns.Add("strRequestId", Type.GetType("System.String"));
                WeeklyTrip.Columns.Add("strPickupDate", Type.GetType("System.String"));
                WeeklyTrip.Columns.Add("strPickupLocation", Type.GetType("System.String"));
                WeeklyTrip.Columns.Add("strPickupTime", Type.GetType("System.String"));
                WeeklyTrip.Columns.Add("strReturnDate", Type.GetType("System.String"));
                WeeklyTrip.Columns.Add("strDropLocation", Type.GetType("System.String"));
                WeeklyTrip.Columns.Add("strReturnTime", Type.GetType("System.String"));
                WeeklyTrip.Columns.Add("strTripType", Type.GetType("System.String"));

                DataRow row1 = WeeklyTrip.NewRow();
                row1["strRequestId"] = "13675";
                row1["strPickupDate"] = "30/09/2015 [Wed]";
                row1["strPickupLocation"] = "Thambaram";
                row1["strPickupTime"] = "21:00";
                row1["strReturnDate"] = "01/10/2015 [Thurs]";
                row1["strDropLocation"] = "RMZ";
                row1["strReturnTime"] = "06:00";
                row1["strTripType"] = "Return";
                WeeklyTrip.Rows.Add(row1);

                DataRow row2 = WeeklyTrip.NewRow();
                row2["strRequestId"] = "13676";
                row2["strPickupDate"] = "01/10/2015 [Thurs]";
                row2["strPickupLocation"] = "Thambaram";
                row2["strPickupTime"] = "21:00";
                row2["strReturnDate"] = "02/10/2015 [Fri]";
                row2["strDropLocation"] = "RMZ";
                row2["strReturnTime"] = "06:00";
                row2["strTripType"] = "Return";
                WeeklyTrip.Rows.Add(row2);

                DataRow row3 = WeeklyTrip.NewRow();
                row3["strRequestId"] = "13677";
                row3["strPickupDate"] = "02/10/2015 [Fri]";
                row3["strPickupLocation"] = "Thambaram";
                row3["strPickupTime"] = "21:00";
                row3["strReturnDate"] = "03/10/2015 [Sat]";
                row3["strDropLocation"] = "RMZ";
                row3["strReturnTime"] = "06:00";
                row3["strTripType"] = "Return";
                WeeklyTrip.Rows.Add(row3);

                DataRow row4 = WeeklyTrip.NewRow();
                row4["strRequestId"] = "13678";
                row4["strPickupDate"] = "03/10/2015 [Mon]";
                row4["strPickupLocation"] = "Thambaram";
                row4["strPickupTime"] = "21:00";
                row4["strReturnDate"] = "04/10/2015 [Tues]";
                row4["strDropLocation"] = "RMZ";
                row4["strReturnTime"] = "06:00";
                row4["strTripType"] = "Return";
                WeeklyTrip.Rows.Add(row4);

                DataRow row5 = WeeklyTrip.NewRow();
                row5["strRequestId"] = "13679";
                row5["strPickupDate"] = "04/10/2015 [Tues]";
                row5["strPickupLocation"] = "Thambaram";
                row5["strPickupTime"] = "21:00";
                row5["strReturnDate"] = "05/10/2015 [Wed]";
                row5["strDropLocation"] = "OTP";
                row5["strReturnTime"] = "06:00";
                row5["strTripType"] = "Return";
                WeeklyTrip.Rows.Add(row5);

                ds.Tables.Add(WeeklyTrip);

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

                ViewState["WeeklyResponse"] = ds;
                BindGrid("WeeklyResponse");
            }

            if (!bDailyRequest && !bWeeklyRequest)
            {
                Response.Write("Oops !! .. There is no Drives available for you");
            }
        }

        protected void BindGrid(string gvSource)
        {
            if (gvSource == "DailyResponse")
            {
                gvDailyResponse.DataSource = ViewState["DailyResponse"] as DataSet;
                gvDailyResponse.DataBind();
            }
            else if (gvSource == "WeeklyResponse")
            {
                gvWeeklyResponse.DataSource = ViewState["WeeklyResponse"] as DataSet;
                gvWeeklyResponse.DataBind();
            }
        }

        protected void OnDailyResponseRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string item = e.Row.Cells[0].Text;
                foreach (Button button in e.Row.Cells[7].Controls.OfType<Button>())
                {
                    if (button.CommandName == "Delete")
                    {
                        button.Attributes["onclick"] = "if(!confirm('Do you want to delete " + item + "?')){ return false; };";
                    }
                }
            }
        }

        protected void OnDailyResponseRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            DataSet ds = ViewState["DailyResponse"] as DataSet;
            ds.Tables[0].Rows[index].Delete();
            ViewState["DailyResponse"] = ds;
            BindGrid("DailyResponse");
        }

        protected void OnWeeklyResponseRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string item = e.Row.Cells[0].Text;
                foreach (Button button in e.Row.Cells[9].Controls.OfType<Button>())
                {
                    if (button.CommandName == "Delete")
                    {
                        button.Attributes["onclick"] = "if(!confirm('Do you want to delete " + item + "?')){ return false; };";
                    }
                }
            }
            if (e.Row.RowType == DataControlRowType.Header)
            {
                Button hButton = (Button)e.Row.Cells[9].FindControl("btnDeleteAll");

                if (hButton.CommandName == "DeleteAll")
                {
                    hButton.Attributes["onclick"] = "if(!confirm('Do you want to Delete  All ?')){ return false; };";
                }
            }
        }

        protected void OnWeeklyResponseRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int index = Convert.ToInt32(e.RowIndex);
            DataSet ds = ViewState["WeeklyResponse"] as DataSet;
            ds.Tables[0].Rows[index].Delete();
            ViewState["WeeklyResponse"] = ds;
            BindGrid("WeeklyResponse");
        }
    }
}
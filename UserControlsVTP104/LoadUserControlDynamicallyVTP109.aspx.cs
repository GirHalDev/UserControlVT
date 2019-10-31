using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControlsVTP104
{
    public partial class LoadUserControlDynamicallyVTP109 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //The UserCalendarControl is loaded dynamically instead of being loaded at design time.
            CalendarUserControl calendarUser = (CalendarUserControl)LoadControl("~/UserControls/CalendarUserControl.ascx");
            calendarUser.ID = "calendarUser1";

            calendarUser.DateSelected += CalendarUser_DateSelected;
            calendarUser.CalendarVisibilityChanged += CalendarUser_CalendarVisibilityChanged;
            PlaceHolder1.Controls.Add(calendarUser);
        }

        private void CalendarUser_CalendarVisibilityChanged(object sender, CalendarVisibilityChangedEventArgs e)
        {
            Response.Write("Calendar Visible: " + e.IsCalendarVisible.ToString() + "<br/>");
        }

        protected void CalendarUser_DateSelected(object sender, DateSelectedEventArgs e)
        {
            Response.Write(e.SelectedDates.ToShortDateString() + "<br/>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //To retrieve the ID of the UserCalendarControl, since it is not set at design time,
            //it needs to be retrieved programatically at run time.
            Response.Write(((CalendarUserControl)PlaceHolder1.FindControl("calendarUser1")).SelectedDate);
        }
    }
}
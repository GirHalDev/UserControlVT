using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace UserControlsVTP104
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Registering and hooking up or subscribing the button control click event 
            //with the method using the delegate EvenHandler.
            Button1.Click += new EventHandler(Button1_Click);

            //Custom Event registering(CalendarVisibilityChanged) and subscription. The control is User Control
            //Registering the EventHandler has to be done before the event raised(page_load)
            CalendarUserControl.CalendarVisibilityChanged += new CalendarVisibilityChangedEventHandler(CalendarUserControl_CalendarVisibilityChanged);

            //Unregistering event
            //CalendarUserControl.CalendarVisibilityChanged -= new CalendarVisibilityChangedEventHandler(CalendarUserControl_CalendarVisibilityChanged);
        }

        protected void CalendarUserControl_CalendarVisibilityChanged(object sender, CalendarVisibilityChangedEventArgs e)
        {
            Response.Write("Calendar visible = " + e.IsCalendarVisible);
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
           
            //Registering the EventHandler has to be done before the event raised on (page_load)
            //PreRender occurs after page_Load which is after event is raised
            //CalendarUserControl.CalendarVisibilityChanged += new CalendarVisibilityChangedEventHandler(CalendarUserControl_CalendarVisibilityChanged);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(CalendarUserControl.SelectedDate); 
        }
    }
}
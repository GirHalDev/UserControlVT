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
            //CalendarUserControl.CalendarVisibilityChanged += new CalendarVisibilityChangedEventHandler();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write(CalendarUserControl.SelectedDate); 
        }
    }
}
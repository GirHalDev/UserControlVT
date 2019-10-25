using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace UserControlsVTP104
{
    public partial class CalendarUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.Visible = false;
            }
        }

        protected void imgBtn_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
                //Step5: Raising the event. Initialize the class that contain the data then raise the event
                //However, there is another way of raising event using protected virtual method
                CalendarVisibilityChangedEventArgs visibilityChangedEventData = new CalendarVisibilityChangedEventArgs(false);
                OnCalendarVisibilityChanged(visibilityChangedEventData);
                //if(CalendarVisibilityChanged != null)
                //{
                //    CalendarVisibilityChanged(this, visibilityChangedEventData);
                //}
             
            }
            else
            {
                Calendar1.Visible = true;
                CalendarVisibilityChangedEventArgs visibilityChangedEventData = new CalendarVisibilityChangedEventArgs(true);
                OnCalendarVisibilityChanged(visibilityChangedEventData);
            }
        }

        //Protected means this method is only available for the CalendarUserControl class and its derivatives
        //virtual means the method implementation can be overriden by those derived classes
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtDate.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
            CalendarVisibilityChangedEventArgs visibilityChangedEventData = new CalendarVisibilityChangedEventArgs(false);
            OnCalendarVisibilityChanged(visibilityChangedEventData);
        }

        //Creating a property for the text value of date to issolate and provide to the button_Click event
        //a property for the CalendarUserControl
        public string SelectedDate
        {
            get
            {
                return txtDate.Text;
            }
            set
            {
                txtDate.Text = value;
            }
        }

        //Raising custom event: Step4- creating Protected Virtual method to raise the event
        protected virtual void OnCalendarVisibilityChanged(CalendarVisibilityChangedEventArgs e)
        {
            if (CalendarVisibilityChanged != null)
            {
                CalendarVisibilityChanged(this, e);
            }

        }
        //Raising Custom Event: Step3-Registered event and created with the name CalendarVisibilityChanged 
        public event CalendarVisibilityChangedEventHandler CalendarVisibilityChanged;


        //The advantage of using protected virtual method 
        public class SpecialCalendarControler : CalendarUserControl
        {
            protected override void OnCalendarVisibilityChanged(CalendarVisibilityChangedEventArgs e)
            {
                //when a method overriden, before the event raised code can be added.
                //Therefore, the child class can be flexable.
                base.OnCalendarVisibilityChanged(e);
            }
        }
    }
}
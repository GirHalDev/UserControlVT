using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserControlsVTP104
{
    //Raising Custom Events: Step1- Creating the class that would contain the data
    public class CalendarVisibilityChangedEventArgs : EventArgs
    {
        //CalenderVisibilityChangedEventArgs is a class that contains the event data
        //Here the data holds a boolean
        
        private bool isCalendarVisible;

        public CalendarVisibilityChangedEventArgs(bool _isCalendarVisible)
        {
            this.isCalendarVisible = _isCalendarVisible;
        }

        public bool IsCalendarVisible
        {
            get
            {
                return isCalendarVisible;
            }
        }
    }

    //The use of delegate to connect the event for example (Click) with the event handler method eg button_click
    //Raising custom events: Step2- to creating the delegate
    public delegate void CalendarVisibilityChangedEventHandler(object sender, CalendarVisibilityChangedEventArgs e);

    //raising custom events: Step3: creating event, event is a variable of type delegate.
    //an event belongs to a class so it has to be created inside UserControlClass
}
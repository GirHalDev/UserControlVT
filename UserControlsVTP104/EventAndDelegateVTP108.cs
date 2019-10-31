using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserControlsVTP104
{
    //Custom Events and Delegates: Step1- Creating the class that would contain the data
    public class DateSelectedEventArgs : EventArgs
    {
        private DateTime selectedDates;

        public DateTime SelectedDates
        {
            get
            {
                return this.selectedDates;
            }
        }

        public DateSelectedEventArgs(DateTime _selectedDate)
        {
            this.selectedDates = _selectedDate;
        }
    }

    //Custom Events and Delegates: Step2- Creating Delegate
    //Parameter gives which object sends the event and the class that contains the data
    public delegate void DateSelectedEventHandler(object sender, DateSelectedEventArgs e);

    //CustomEvents and Delegates: Step3: Creating Event
    //Event should be a part of the UserControl Class

    //CustomEvents and Delegates: 
    //Step 4: Create a protected virtual method "OnDateSelection" to raise the event

    //CustomEvents and Delegate: Step 5- Raise the event, whenever a date is selected
    //Drag and drop the user control on a webform. Associate DateSelected event with an
    //event handler method, either In HTML or Code



}
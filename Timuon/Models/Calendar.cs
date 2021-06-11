using System;
using Microsoft.Toolkit.Uwp.UI.Controls.TextToolbarSymbols;

namespace Timuon.Models
{
    public class Calendar
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Meeting { get; set; }
        public string Requests { get; set; }

        public Calendar(int iD, string type, string meeting, string requests)
        {
            ID = iD;
            Type = type;
            Meeting = meeting;
            Requests = requests;
        }

        public void getImminentDeadlines()
        {
            
        }
        public void getImportantDates()
        {

        }
        public void mergeCalendar(Calendar cal)
        {

        }
        public void notifyUser(User u)
        {

        }
        public void everyDay()
        {

        }
        public void cal()
        {

        }
        public void button_save_Pref()
        {

        }
        public void button_add_file_Calendar()
        {

        }
        public void button_Save_World()
        {

        }
        public void button_save_me(Conflict c)
        {

        }
        public void add_calendar(String calendar)
        {

        }
        public void grey_out(String hours)
        {

        }
        public void recalculate_Disaster()
        {

        }
        public void reload_page()
        {

        }
    }
}


using System;

namespace Timuon.Models
{
    public class User
    {
        public string Username { get; set; }
        private string Password { get; set; }
        private string Email { get; set; }
        private int Phone_number { get; set; }
        private string Address { get; set; }
        private DateTime Registration_date { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int Id { get; set; }
        private string Calendars { get; set; }
        private string Platforms { get; set; }
        private string Preferences { get; set; }

        public User(string username, string password, string email,
            int phone_number, string address, DateTime registration_date,
            string firstName, string lastName, int id, string calendars,
            string platforms, string preferences)
        {
            Username = username;
            Password = password;
            Email = email;
            Phone_number = phone_number;
            Address = address;
            Registration_date = registration_date;
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Calendars = calendars;
            Platforms = platforms;
            Preferences = preferences;
        }

        public void getOrganizations()
        {

        }

        public void getSchedule()
        {

        }

        public void getCalendar()
        {

        }

        public void gerAuditorium()
        {

        }

        public void addFeed(RSSFeed feed)
        {

        }

        public void EclassAccount(EclassIntegration eclass)
        {

        }

        public void addPlatform(Platform plat)
        {

        }

        public void viewProfile()
        {

        }

        public void select()
        {

        }

        public void save()
        {

        }

        public void confirm()
        {

        }

        public void cancel()
        {

        }

        public void submit()
        {

        }
        public void announcements()
        {

        }

        public void save_Preferences()
        {

        }

        public void get_User_channels()
        {

        }

        public void add_Channel()
        {

        }

        public void get_User_info()
        {

        }

        public void get_Conflicts()
        {

        }

        public void set_mode()
        {

        }

        public void insert_file_cal()
        {

        }

        public void reflood_conflicts(Conflict con)
        {

        }

        public void sace_cal()
        {

        }

        public void find_conlicts()
        {

        }

    }
}


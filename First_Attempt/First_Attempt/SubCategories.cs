using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace First_Attempt
{
    class SubCategories
    {
        private List<catIcons> _subCat = new List<catIcons>();
        List<catIcons> shopping_Icon_List = new List<catIcons>();
        List<catIcons> school_Icon_List = new List<catIcons>();
        List<catIcons> office_Icon_List = new List<catIcons>();
        List<catIcons> help_Icon_List = new List<catIcons>();
        List<catIcons> gen_Icon_List = new List<catIcons>();
        List<catIcons> home_Icon_List = new List<catIcons>();
        List<catIcons> everyday_Icon_List = new List<catIcons>();
        
        // Use this for files that you want to acces on images being shipped with your app. Else "ms-appdata:///local/Logo.png" 
        // for files that are on your local directory.
        private static Uri _baseUri = new Uri("ms-appx:///");
        public List<catIcons> subCat
        {
            get
            {
                return this._subCat;
            }
        }

        // Add an icon to the school list.
        public void addSchoolCatIcons(string title, string subtitle, BitmapImage image)
        {
            catIcons icon = new catIcons();
            icon.Title = title;
            icon.Subtitle = subtitle;
            icon.Image = image;
            this.school_Icon_List.Add(icon);
            this._subCat = school_Icon_List;
        }

        //All the categories on the first page of the applicaton. 
        public void getSchoolCatIcons()
        {
            {
                catIcons icon_School_English = new catIcons();
                catIcons icon_School_Math = new catIcons();
                catIcons icon_School_Science = new catIcons();
                catIcons icon_School_General = new catIcons();
                catIcons icon_School_Help = new catIcons();

                //Editing properties of each item.
                icon_School_English.Title = "English";
                icon_School_English.Subtitle = "This is the English class.";
                icon_School_English.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School_School.png"));

                icon_School_Math.Title = "Mathematics";
                icon_School_Math.Subtitle = "This is the Math class.";
                icon_School_Math.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School_School.png"));

                icon_School_Science.Title = "Science";
                icon_School_Science.Subtitle = "This is the Science class.";
                icon_School_Science.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School_Office.png"));

                icon_School_General.Title = "General;";
                icon_School_General.Subtitle = "General texts.";
                icon_School_General.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School_Shopping.png"));

                icon_School_Help.Title = "Help";
                icon_School_Help.Subtitle = "Call for help.";
                icon_School_Help.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School_Everyday.png"));

                school_Icon_List.Add(icon_School_English);
                school_Icon_List.Add(icon_School_Math);
                school_Icon_List.Add(icon_School_Science);
                school_Icon_List.Add(icon_School_General);
                school_Icon_List.Add(icon_School_Help);

                this._subCat = school_Icon_List;
            }
        }

        public void addOfficeCatIcons(string title, string subtitle)
        {
            catIcons icon = new catIcons();
            icon.Title = title;
            icon.Subtitle = subtitle;
            icon.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School_Everyday.png"));
            this.office_Icon_List.Add(icon);
            this._subCat = office_Icon_List;
        }
        //Icons in the Office Category
        public void getOfficeCatIcons()
        {
            {
                catIcons icon_Office_Permissions = new catIcons();
                catIcons icon_Office_Mail = new catIcons();
                catIcons icon_Office_Calendar = new catIcons();
                catIcons icon_Office_Meeting = new catIcons();

                //Editing properties of each item.
                icon_Office_Permissions.Title = "Permissions";
                icon_Office_Permissions.Subtitle = "Standard Permissions.";
                icon_Office_Permissions.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_Office_School.png"));

                icon_Office_Mail.Title = "Mail";
                icon_Office_Mail.Subtitle = "Open and Read Mails";
                icon_Office_Mail.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_Office_School.png"));

                icon_Office_Calendar.Title = "Calendar";
                icon_Office_Calendar.Subtitle = "Open Calendar and check events.";
                icon_Office_Calendar.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_Office_Office.png"));

                icon_Office_Meeting.Title = "Meeting";
                icon_Office_Meeting.Subtitle = "Open and Read today's Meeting Schedule";
                icon_Office_Meeting.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_Office_Shopping.png"));

                office_Icon_List.Add(icon_Office_Permissions);
                office_Icon_List.Add(icon_Office_Calendar);
                office_Icon_List.Add(icon_Office_Mail);
                office_Icon_List.Add(icon_Office_Meeting);

                this._subCat = office_Icon_List;
            }
        }

        public void addShoppingCatIcons(string title, string subtitle)
        {
            catIcons icon = new catIcons();
            icon.Title = title;
            icon.Subtitle = subtitle;
            icon.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School_Everyday.png"));
            this.shopping_Icon_List.Add(icon);
            this._subCat = shopping_Icon_List;
        }

        //All the categories on the first page of the applicaton. 
        public void getShoppingCatIcons()
        {
            {
                catIcons icon_Shopping_Groceries = new catIcons();
                catIcons icon_Shopping_Electronics = new catIcons();
                catIcons icon_Shopping_GeneralEnquiry = new catIcons();
                catIcons icon_Shopping_Assistance = new catIcons();
                catIcons icon_Shopping_Help = new catIcons();

                //Editing properties of each item.
                icon_Shopping_Groceries.Title = "Groceries";
                icon_Shopping_Groceries.Subtitle = "Buy Groceries";
                icon_Shopping_Groceries.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_Shopping_School.png"));

                icon_Shopping_Electronics.Title = "Electronics";
                icon_Shopping_Electronics.Subtitle = "Buy Electronics";
                icon_Shopping_Electronics.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_Shopping_School.png"));

                icon_Shopping_GeneralEnquiry.Title = "General Enquiry";
                icon_Shopping_GeneralEnquiry.Subtitle = "General Enquiries";
                icon_Shopping_GeneralEnquiry.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_Shopping_Office.png"));

                icon_Shopping_Assistance.Title = "Assistance;";
                icon_Shopping_Assistance.Subtitle = "Call for a Shopping assistant";
                icon_Shopping_Assistance.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_Shopping_Shopping.png"));

                icon_Shopping_Help.Title = "Help";
                icon_Shopping_Help.Subtitle = "Call for help.";
                icon_Shopping_Help.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_Shopping_Everyday.png"));

                shopping_Icon_List.Add(icon_Shopping_Assistance);
                shopping_Icon_List.Add(icon_Shopping_Electronics);
                shopping_Icon_List.Add(icon_Shopping_GeneralEnquiry);
                shopping_Icon_List.Add(icon_Shopping_Groceries);
                shopping_Icon_List.Add(icon_Shopping_Help);

                this._subCat = shopping_Icon_List;
            }
        }

        public void addHelpCatIcons(string title, string subtitle)
        {
            catIcons icon = new catIcons();
            icon.Title = title;
            icon.Subtitle = subtitle;
            icon.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School_Everyday.png"));
            this.help_Icon_List.Add(icon);
            this._subCat = help_Icon_List;
        }

        //All the categories on the first page of the applicaton. 
        public void getHelpCatIcons()
        {
            {

                catIcons icon_Help_Emergency = new catIcons();
                catIcons icon_Help_Phone_Call = new catIcons();
                catIcons icon_Help_Help = new catIcons();

                //Editing properties of each item.
                icon_Help_Emergency.Title = "Emergency (911)";
                icon_Help_Emergency.Subtitle = "Call 911";
                icon_Help_Emergency.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_Help_School.png"));

                icon_Help_Phone_Call.Title = "Call Contact";
                icon_Help_Phone_Call.Subtitle = "Call Immediate Emergency Contact";
                icon_Help_Phone_Call.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_Help_School.png"));

                icon_Help_Help.Title = "Help";
                icon_Help_Help.Subtitle = "Send notifications to all immediate Help contacts";
                icon_Help_Help.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_Help_Office.png"));

                help_Icon_List.Add(icon_Help_Emergency);
                help_Icon_List.Add(icon_Help_Help);
                help_Icon_List.Add(icon_Help_Phone_Call);
                
                this._subCat = help_Icon_List;
            }
        }

        public void addGeneralCatIcons(string title, string subtitle)
        {
            catIcons icon = new catIcons();
            icon.Title = title;
            icon.Subtitle = subtitle;
            icon.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School_Everyday.png"));
            this.gen_Icon_List.Add(icon);
            this._subCat = gen_Icon_List;
        }
        //All the categories on the first page of the applicaton. 
        public void getGeneralCatIcons()
        {
            {
                catIcons icon_School_English = new catIcons();
                catIcons icon_School_Math = new catIcons();
                catIcons icon_School_Science = new catIcons();
                catIcons icon_School_General = new catIcons();
                catIcons icon_School_Help = new catIcons();

                //Editing properties of each item.
                icon_School_English.Title = "General";
                icon_School_English.Subtitle = "This is the English class.";
                icon_School_English.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School_School.png"));

                icon_School_Math.Title = "General";
                icon_School_Math.Subtitle = "This is the Math class.";
                icon_School_Math.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School_School.png"));

                icon_School_Science.Title = "General";
                icon_School_Science.Subtitle = "This is the Science class.";
                icon_School_Science.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School_Office.png"));

                icon_School_General.Title = "General;";
                icon_School_General.Subtitle = "General texts.";
                icon_School_General.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School_Shopping.png"));

                icon_School_Help.Title = "General";
                icon_School_Help.Subtitle = "Call for help.";
                icon_School_Help.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School_Everyday.png"));

                gen_Icon_List.Add(icon_School_English);
                gen_Icon_List.Add(icon_School_Math);
                gen_Icon_List.Add(icon_School_Science);
                gen_Icon_List.Add(icon_School_General);
                gen_Icon_List.Add(icon_School_Help);

                this._subCat = gen_Icon_List;
            }
        }

        public void addEverydayCatIcons(string title, string subtitle)
        {
            catIcons icon = new catIcons();
            icon.Title = title;
            icon.Subtitle = subtitle;
            icon.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School_Everyday.png"));
            this.everyday_Icon_List.Add(icon);
            this._subCat = everyday_Icon_List;
        }
        //All the categories on the first page of the applicaton. 
        public void getEverydayCatIcons()
        {
            {
                catIcons icon_School_English = new catIcons();
                catIcons icon_School_Math = new catIcons();
                catIcons icon_School_Science = new catIcons();
                catIcons icon_School_General = new catIcons();
                catIcons icon_School_Help = new catIcons();

                //Editing properties of each item.
                icon_School_English.Title = "Everyday";
                icon_School_English.Subtitle = "This is the English class.";
                icon_School_English.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School_School.png"));

                icon_School_Math.Title = "Everyday";
                icon_School_Math.Subtitle = "This is the Math class.";
                icon_School_Math.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School_School.png"));

                icon_School_Science.Title = "Everyday";
                icon_School_Science.Subtitle = "This is the Science class.";
                icon_School_Science.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School_Office.png"));

                icon_School_General.Title = "Everyday;";
                icon_School_General.Subtitle = "General texts.";
                icon_School_General.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School_Shopping.png"));

                icon_School_Help.Title = "Everyday";
                icon_School_Help.Subtitle = "Call for help.";
                icon_School_Help.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School_Everyday.png"));

                school_Icon_List.Add(icon_School_English);
                school_Icon_List.Add(icon_School_Math);
                school_Icon_List.Add(icon_School_Science);
                school_Icon_List.Add(icon_School_General);
                school_Icon_List.Add(icon_School_Help);

                this._subCat = school_Icon_List;
            }
        }

        public void addHomeCatIcons(string title, string subtitle)
        {
            catIcons icon = new catIcons();
            icon.Title = title;
            icon.Subtitle = subtitle;
            icon.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School_Everyday.png"));
            this.home_Icon_List.Add(icon);
            this._subCat = home_Icon_List;
        }

        //Home Icons
        public void getHomeCatIcons()
        {
            {
                catIcons icon_Home_Food = new catIcons();
                catIcons icon_Home_Essentials = new catIcons();
                catIcons icon_Home_Greetings = new catIcons();

                //Editing properties of each item.
                icon_Home_Food.Title = "Food";
                icon_Home_Food.Subtitle = "Ask for Food";
                icon_Home_Food.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_Home_School.png"));

                icon_Home_Essentials.Title = "Essentials";
                icon_Home_Essentials.Subtitle = "Notify for essentials";
                icon_Home_Essentials.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_Home_School.png"));

                icon_Home_Greetings.Title = "Greetings";
                icon_Home_Greetings.Subtitle = "General Greetings";
                icon_Home_Greetings.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_Home_Office.png"));

                home_Icon_List.Add(icon_Home_Food);
                home_Icon_List.Add(icon_Home_Essentials);
                home_Icon_List.Add(icon_Home_Greetings);

                this._subCat = home_Icon_List;
            }
        }

        //Properties of each TextBlock in the applications first page.
        public class catIcons
        {
            public string Title { get; set; }
            public string Subtitle { get; set; }
            public BitmapImage Image { get; set; }
        }
    }
}
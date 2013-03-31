using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace First_Attempt
{
    class TileData
    {
        private List<itemDet> _Items = new List<itemDet>();
        // Use this for files that you want to acces on images being shipped with your app. Else "ms-appdata:///local/Logo.png" 
        // for files that are on your local directory.
        private static Uri _baseUri = new Uri("ms-appx:///");
        public List<itemDet> items
        {
            get
            {
                return this._Items;
            }
        }

        //All the categories on the first page of the applicaton. 
        public void getItemDet()
        {
            {
                //Places/Location
                itemDet item_School = new itemDet();
                itemDet item_Home = new itemDet();
                itemDet item_Office = new itemDet();
                itemDet item_Shopping = new itemDet();
                itemDet item_Help = new itemDet();
                itemDet item_General = new itemDet();
                itemDet item_Everyday = new itemDet();
         
                //Activities
                itemDet item_Playground = new itemDet();
                itemDet item_Study = new itemDet();
                itemDet item_Computer = new itemDet();

                //Editing properties of each item.
                item_School.Title = "School";
                item_School.Subtitle = "English, Math, Science";
                item_School.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_School.png"));

                item_Home.Title = "Home";
                item_Home.Subtitle = "Food, Essential activities, Medical";
                item_Home.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_Home.png"));

                item_Office.Title = "Office";
                item_Office.Subtitle = "Mail, Calendar, Meetings";
                item_Office.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_Office.png"));

                item_Shopping.Title = "Shopping";
                item_Shopping.Subtitle = "Price List, Assistance, Product Enquiry";
                item_Shopping.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_Shopping.png"));

                item_Everyday.Title = "Everyday";
                item_Everyday.Subtitle = "Greeting, Call out, Conversation mode";
                item_Everyday.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_Everyday.png"));

                item_Help.Title = "Help";
                item_Help.Subtitle = "911, Medical Help, Call someone";
                item_Help.Image = new BitmapImage(new Uri(_baseUri, "Assets/icon_Help.png"));

                item_General.Title = "General";
                item_General.Subtitle = "Emoticons, Games, Internet";
                item_General.Image = new BitmapImage(new Uri(_baseUri, "Assets/item_General.png"));

                item_Playground.Title = "Playground";
                item_Playground.Subtitle = "English, Math, Science";
                item_Playground.Image = new BitmapImage(new Uri(_baseUri, "Assets/item_Playground.png"));

                item_Study.Title = "Study";
                item_Study.Subtitle = "English, Math, Science";
                item_Study.Image = new BitmapImage(new Uri(_baseUri, "Assets/item_Study.png"));

                item_Computer.Title = "Computer";
                item_Computer.Subtitle = "English, Math, Science";
                item_Computer.Image = new BitmapImage(new Uri(_baseUri, "Assets/item_Computer.png"));

                this._Items.Add(item_School);
                this._Items.Add(item_Home);
                this._Items.Add(item_Office);
                this._Items.Add(item_Shopping);
                this._Items.Add(item_Help);
                this._Items.Add(item_General);
                this._Items.Add(item_Everyday);
                /*this._Items.Add(item_Playground);
                this._Items.Add(item_Study);
                this._Items.Add(item_Computer);*/
            }
        }
    }

    //Properties of each TextBlock in the applications first page.
    class itemDet
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public BitmapImage Image { get; set; }
    }
}

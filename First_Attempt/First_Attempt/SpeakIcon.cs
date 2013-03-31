using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace First_Attempt
{
    class SpeakIcon
    {
        
        private List<itemDet> _speakIcon = new List<itemDet>();
        //private static Uri _baseUri = new Uri("ms-appx:///");
        public List<itemDet> speakIcon
        {
            get
            {
                return this._speakIcon;
            }
        }

        public void getItemDet()
        {
            for (int i = 0; i < 8; i++)
            {
                itemDet icon = new itemDet();

                icon.Title = "School";
                icon.Subtitle = "English, Math, Science";
                icon.Image = new BitmapImage(new Uri(@"C:\Users\akshay\Documents\Visual Studio 2012\Projects\First_Attempt\First_Attempt\Assets\Calvin_School.png"));
                this._speakIcon.Add(icon);
            }
            //return this._Items;
        }

    }
    class iconDet
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public BitmapImage Image { get; set; }
    }
    
}

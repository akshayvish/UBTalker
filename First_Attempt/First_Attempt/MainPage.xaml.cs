using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Items Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234233

namespace First_Attempt
{
    /// <summary>
    /// A page that displays a collection of item previews.  In the Split Application this page
    /// is used to display and select one of the available groups.
    /// </summary>
    public sealed partial class MainPage : First_Attempt.Common.LayoutAwarePage
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            // TODO: Assign a bindable collection of items to this.DefaultViewModel["Items"]
            TileData tile = new TileData();
            tile.getItemDet();
            this.DefaultViewModel["Items"] = tile.items;
        }

        private void ItemView_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.ClickedItem != null)
            {
                string title = ((itemDet)e.ClickedItem).Title;

                if (title.Equals("School"))
                {
                    //var viewType = Type.GetType("First_Attempt."+title.pagePath.Substring(0, getMenu.pagePath.LastIndexOf("."));
                    this.Frame.Navigate(typeof(School), title);
                }
                else if (title.Equals("Home"))
                {
                    //var viewType = Type.GetType("First_Attempt."+title.pagePath.Substring(0, getMenu.pagePath.LastIndexOf("."));
                    this.Frame.Navigate(typeof(Home), title);
                }
                else if (title.Equals("Office"))
                {
                    //var viewType = Type.GetType("First_Attempt."+title.pagePath.Substring(0, getMenu.pagePath.LastIndexOf("."));
                    this.Frame.Navigate(typeof(Office), title);
                }
                else if (title.Equals("Shopping"))
                {
                    //var viewType = Type.GetType("First_Attempt."+title.pagePath.Substring(0, getMenu.pagePath.LastIndexOf("."));
                    this.Frame.Navigate(typeof(Shopping), title);
                }
                else if (title.Equals("Help"))
                {
                    //var viewType = Type.GetType("First_Attempt."+title.pagePath.Substring(0, getMenu.pagePath.LastIndexOf("."));
                    this.Frame.Navigate(typeof(Help), title);
                }
                else if (title.Equals("General"))
                {
                    //var viewType = Type.GetType("First_Attempt."+title.pagePath.Substring(0, getMenu.pagePath.LastIndexOf("."));
                    this.Frame.Navigate(typeof(General), title);
                }
                else if (title.Equals("Everyday"))
                {
                    //var viewType = Type.GetType("First_Attempt."+title.pagePath.Substring(0, getMenu.pagePath.LastIndexOf("."));
                    this.Frame.Navigate(typeof(Everyday), title);
                }
                else
                {
                    this.Frame.Navigate(typeof(SpeakIcons), title);
                }
            }
        }

        //Add Tile button clicked on the top right of the screen.
        private void newTile_Button(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                this.Frame.Navigate(typeof(AddTile));
            }
        }
    }
}

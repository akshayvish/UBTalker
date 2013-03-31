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
    public sealed partial class Office : First_Attempt.Common.LayoutAwarePage
    {
        public Office()
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
            SubCategories icon = new SubCategories();
            if ((!string.IsNullOrEmpty(AddTile.newTile_Subtitle))
                || (!string.IsNullOrEmpty(AddTile.newTile_Title)))
            {
                icon.addOfficeCatIcons(AddTile.newTile_Title, AddTile.newTile_Subtitle);
                //Call this again after adding the new tile to the page.
                icon.getOfficeCatIcons();
                //clear all the variables now that the tile has been added.
                AddTile.clearGlobalVar();
            }
            else
            {
                icon.getOfficeCatIcons();
            }
            //Call  the respective method as per the class.
            
            this.DefaultViewModel["Items"] = icon.subCat;
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Streams;
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
    public sealed partial class School : First_Attempt.Common.LayoutAwarePage
    {
        SubCategories icon;
        private const string clientID = "71d8efd0-5779-4c96-9d3a-02e5c387c57e";
        private const string clientSecret = "zYtEdidpSIY4V9C+7Q+VuI/3AfYERM9PyDmwcAeY2U0=";

        public School()
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
            icon = new SubCategories();

            if ((!string.IsNullOrEmpty(AddTile.newTile_Subtitle))
                || (!string.IsNullOrEmpty(AddTile.newTile_Title)))
            {
                icon.addSchoolCatIcons(AddTile.newTile_Title, AddTile.newTile_Subtitle, AddTile.newTile_Image);
                //Call this again after adding the new tile to the page.
                icon.getSchoolCatIcons();
                //clear all the variables now that the tile has been added.
                AddTile.clearGlobalVar();
            }
            else
            {
                icon.getSchoolCatIcons();
            }
            //await SaveAsync();   
            this.DefaultViewModel["Items"] = icon.subCat;
        }
        public async Task SaveAsync()
        {
            StorageFile schoolFile = await ApplicationData.Current.LocalFolder.CreateFileAsync("UserDetails", CreationCollisionOption.ReplaceExisting);
            
            IRandomAccessStream raStream = await schoolFile.OpenAsync(FileAccessMode.ReadWrite);
            using (IOutputStream outStream = raStream.GetOutputStreamAt(0))
            {
                //Serialize the session state.
                DataContractSerializer serializer = new DataContractSerializer(typeof(SubCategories));
                serializer.WriteObject(outStream.AsStreamForWrite(), icon);
                await outStream.FlushAsync();
            }
        }
        private async void ItemView_ItemClick(object sender, ItemClickEventArgs e)
        {
            TranslatorService.Speech.SpeechSynthesizer speech = new TranslatorService.Speech.SpeechSynthesizer(clientID, clientSecret);
            //spe.Speak("Hello", SpeechMediaElement);*/

            // Gets the audio stream.
            var stream = await speech.GetSpeakStreamAsync("Hello", "en-us");

            // Reproduces the audio stream using a MediaElement.
            SpeechMediaElement.SetSource(stream, speech.MimeContentType);
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

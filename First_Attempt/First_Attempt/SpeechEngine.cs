using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranslatorService.Speech;
//using TranslatorService.Speech;
using Windows.UI.Xaml.Controls;

 namespace First_Attempt
{
    public class SpeechEngine
    {
        private const string CLIENT_ID = "71d8efd0-5779-4c96-9d3a-02e5c387c57e";
        private const string CLIENT_SECRET = "zYtEdidpSIY4V9C+7Q+VuI/3AfYERM9PyDmwcAeY2U0=";

        private SpeechSynthesizer speech;
        private String language = "en";

        public SpeechEngine()
        {
            
            speech = new SpeechSynthesizer(CLIENT_ID, CLIENT_SECRET);
            speech.AudioFormat = SpeakStreamFormat.MP3;
            speech.AudioQuality = SpeakStreamQuality.MaxQuality;
            speech.AutoDetectLanguage = true;
            speech.AutomaticTranslation = true;
        }

       public async void Speak(String speechText, MediaElement me)
        {
            var stream = await speech.GetSpeakStreamAsync(speechText, language);
            me.SetSource(stream, speech.MimeContentType);
        }
    }
}

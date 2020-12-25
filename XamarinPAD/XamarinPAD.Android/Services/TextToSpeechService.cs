using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Speech.Tts;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XamarinPAD.Services;
using static Android.Speech.Tts.TextToSpeech;

[assembly: Xamarin.Forms.Dependency(typeof(XamarinPAD.Droid.Services.TextToSpeechService))]
namespace XamarinPAD.Droid.Services
{
    class TextToSpeechService : Java.Lang.Object, ITextToSpeechService, IOnInitListener
    {
        TextToSpeech speaker;
        string toSpeak;
        public void Speak(object text)
        {
            toSpeak = (string)text;
            if (speaker == null)
            {
                speaker = new TextToSpeech(Android.App.Application.Context, this);
            }
            else
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }

        public void OnInit(OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }
    }
}
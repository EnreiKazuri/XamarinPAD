using AVFoundation;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using XamarinPAD.Services;
using XamarinPAD.iOS.Services;

[assembly: Xamarin.Forms.Dependency(typeof(XamarinPAD.iOS.Services.TextToSpeechService))]
namespace XamarinPAD.iOS.Services
{
    class TextToSpeechService : ITextToSpeechService
    {
        public void Speak(object text)
        {
            var speechSynthesizer = new AVSpeechSynthesizer();

            var speechUtterance = new AVSpeechUtterance((string)text)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 2,
                Voice = AVSpeechSynthesisVoice.FromLanguage("en-US"),
                Volume = 1f,
                PitchMultiplier = 1.0f
            };

            speechSynthesizer.SpeakUtterance(speechUtterance);
        }
    }
}
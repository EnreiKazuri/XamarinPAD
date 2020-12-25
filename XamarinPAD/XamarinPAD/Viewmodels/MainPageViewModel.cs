using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using XamarinPAD.Services;

namespace XamarinPAD.Viewmodels
{
    class MainPageViewModel
    {
        public ICommand SpeakCommand => new Command(SpeakAloud);
        private async void SpeakAloud(object text)
        {
            if (text != null)
            {
                DependencyService.Get<ITextToSpeechService>().Speak(text);
                DeviceOrientation orientation = DependencyService.Get<IDeviceOrientationService>().GetOrientation();
                var result = orientation.ToString();
                await App.Current.MainPage.DisplayAlert("Orientation", "Your phone is on " + result, "OK");
            }
        }
    }
}

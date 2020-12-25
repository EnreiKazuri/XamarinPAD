using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinPAD.Services
{
    public interface ITextToSpeechService
    {
        void Speak(object text);
    }
}

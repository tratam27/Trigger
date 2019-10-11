using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Trigger
{
    public class TextViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string butText;
        public TextViewModel()
        {
            ShowResult = new Command(Result);
        }
        private string dateTest;

        public string DateTest
        {
            get { return dateTest; }
            set { dateTest = value; OnPropertyChanged(nameof(DateTest)); }
        }

        public string ButText
        {
            get { return butText; }
            set { butText = value; OnPropertyChanged(nameof(ButText)); }
        }
        public bool Switchy { get; set; }
        public bool sWitcher;
        public bool SWitcher
        {
            get { return sWitcher; }
            set { sWitcher = value; OnPropertyChanged(nameof(SWitcher)); }
        }
        private string entryText;

        public string EntryText
        {
            get { return entryText; }
            set { entryText = value; OnPropertyChanged(nameof(EntryText)); }
        }

        public ICommand ShowResult { get; set; }
        public void Result()
        {
            if(EntryText == "Tratam")
            {
                ButText = "Correct";
            }
            else
            {
                ButText = "Incorrect";
            }
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

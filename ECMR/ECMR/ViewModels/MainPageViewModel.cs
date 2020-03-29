using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Essentials;

namespace ECMR.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {

        private string _fullName;

        public string FullName
        {
            get { return _fullName; }
            set
            {
                _fullName = value;
                OnPropertyChanged("FullName");
            }
        }

        private string _serviceNumber;

        public string ServiceNumber
        {
            get { return _serviceNumber; }
            set { _serviceNumber = value; OnPropertyChanged(nameof(ServiceNumber)); }
        }

        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; OnPropertyChanged(nameof(Address)); }
        }

        public MainPageViewModel()
        {
            FullName = Preferences.Get("FullName_pref", String.Empty);
            Address = Preferences.Get("Address_pref", String.Empty);
            ServiceNumber = Preferences.Get("ServiceNumber_pref", String.Empty);
        }

        public void SavePrefs()
        {
            Preferences.Set("FullName_pref", FullName);
            Preferences.Set("Address_pref", Address);
            Preferences.Set("ServiceNumber_pref", ServiceNumber);
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

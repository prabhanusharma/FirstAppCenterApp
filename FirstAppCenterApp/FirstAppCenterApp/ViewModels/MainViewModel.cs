using Microsoft.AppCenter.Analytics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FirstAppCenterApp.ViewModels
{
    public class MainViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            
        }

        private string _labelText;
        public string LabelText
        {
            get
            {
                return _labelText;
            }

            set
            {
                _labelText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LabelText)));
            }
        }

        public ICommand RegisterCommand => new Command(Register);

        private void Register()
        {
            var t = LabelText;
            //bool isEnabled = await Analytics.IsEnabledAsync();
            Analytics.TrackEvent("Register clicked", new Dictionary<string, string> {
                { "FileName", t}
            });
        }
    }
}

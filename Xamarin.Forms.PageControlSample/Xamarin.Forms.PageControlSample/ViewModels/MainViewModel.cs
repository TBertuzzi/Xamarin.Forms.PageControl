using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms.PageControlSample.Models;

namespace Xamarin.Forms.PageControlSample.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        #region Property

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion

        private int _position;
        public int Position
        {
            get { return _position; }
            set { SetProperty(ref _position, value); }
        }

        private bool _showIcons = false;
        public bool ShowIcons
        {
            get { return _showIcons; }
            set
            {
                SetProperty(ref _showIcons, value);
            }
        }

        public ObservableCollection<Screenshot> Screenshots { get; }

        public MainViewModel()
        {
            Screenshots = new ObservableCollection<Screenshot>();

            Screenshot screen = new Screenshot();
            screen.Url = "";
            Screenshots.Add(screen);

            screen = new Screenshot();
            screen.Url = "";
            Screenshots.Add(screen);

            screen = new Screenshot();
            screen.Url = "";
            Screenshots.Add(screen);

            screen = new Screenshot();
            screen.Url = "";
            Screenshots.Add(screen);

            screen = new Screenshot();
            screen.Url = "";
            Screenshots.Add(screen);


        }
    }
}

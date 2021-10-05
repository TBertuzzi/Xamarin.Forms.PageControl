using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace XFPageControlSample
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
            get
            {
                this.Image = Screenshots[_position].Image;
                return _position;
            }
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

        private string _image;
        public string Image
        {
            get { return _image; }
            set { SetProperty(ref _image, value); }
        }



        public ObservableCollection<Screenshot> Screenshots { get; }

        public MainViewModel()
        {
            Screenshots = new ObservableCollection<Screenshot>();

            Screenshot screen = new Screenshot();
            screen.Image = "Polly1.jpg";
            Screenshots.Add(screen);

            screen = new Screenshot();
            screen.Image = "Polly2.jpg";
            Screenshots.Add(screen);

            screen = new Screenshot();
            screen.Image = "Polly3.jpg";
            Screenshots.Add(screen);

            screen = new Screenshot();
            screen.Image = "Polly4.jpg";
            Screenshots.Add(screen);

            Position = 1;

        }
    }
}

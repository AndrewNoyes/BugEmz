using System;
using System.ComponentModel;
using Mana.UI.Util;

namespace Mana.UI
{
    public class MenuItem : INotifyPropertyChanged
    {
        private string _name;
        private object _content;
        private string _icon;

        public string Name
        {
            get { return _name; }
            set
            {
                this.MutateVerbose(ref _name, value, RaisePropertyChanged());
            }
        }

        public string Icon
        {
            get { return _icon; }
            set { this.MutateVerbose(ref _icon, value, RaisePropertyChanged()); }
        }

        public object Content
        {
            get { return _content; }
            set
            {
                this.MutateVerbose(ref _content, value, RaisePropertyChanged());
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private Action<PropertyChangedEventArgs> RaisePropertyChanged()
        {
            return args => PropertyChanged?.Invoke(this, args);
        }
    }
}

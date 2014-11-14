using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Turist_App_v4.Annotations;
using Turist_App_v4.Model;

namespace Turist_App_v4.Viewmodel
{
    class MainViewVM : INotifyPropertyChanged
    {
        private static ObservableCollection<Attraktioner> _attraktionsListe = new ObservableCollection<Attraktioner>();
        private Attraktioner _selectedAttraktion;

        public static ObservableCollection<Attraktioner> AttraktionsListe
        {
            get { return _attraktionsListe; }
            set { _attraktionsListe = value; }
        }

        public Attraktioner SelectedAttraktion
        {
            get { return _selectedAttraktion; }
            set { _selectedAttraktion = value; OnPropertyChanged();}
        }

        public MainViewVM()
        {
        }

        #region propertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}

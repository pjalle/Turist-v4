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
        private bool hasRun;
        private static ObservableCollection<Attraktioner> _attraktionsListe = new ObservableCollection<Attraktioner>();
        private static ObservableCollection<Kategorier> _kategoriers = new ObservableCollection<Kategorier>();
        private Attraktioner _selectedAttraktion;
        private Kategorier _selectedKategori;
        private static Kategorier _staticSelectedKategori;

        public static ObservableCollection<Attraktioner> AttraktionsListe
        {
            get { return _attraktionsListe; }
            set { _attraktionsListe = value; }
        }

        public static ObservableCollection<Kategorier> Kategoriers
        {
            get { return _kategoriers; }
            set { _kategoriers = value; }
        }

        public Attraktioner SelectedAttraktion
        {
            get { return _selectedAttraktion; }
            set { _selectedAttraktion = value; OnPropertyChanged();}
        }

        public Kategorier SelectedKategori
        {
            get { return _selectedKategori; }
            set { _selectedKategori = value; OnPropertyChanged();}
        }

        public static Kategorier StaticSelectedKategori
        {
            get { return _staticSelectedKategori; }
            set { _staticSelectedKategori = value; }
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

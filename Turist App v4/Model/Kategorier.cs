using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turist_App_v4.Model
{
    class Kategorier
    {
        private ObservableCollection<Attraktioner> _underAttraktioner = new ObservableCollection<Attraktioner>();
        public string Name { get; set; }
        public string Billede { get; set; }

        public ObservableCollection<Attraktioner> UnderAttraktioner
        {
            get { return _underAttraktioner; }
            set { _underAttraktioner = value; }
        }

        public Kategorier(string name, string billede, ObservableCollection<Attraktioner> underCollection)
        {
            Name = name;
            Billede = billede;
            UnderAttraktioner = underCollection;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

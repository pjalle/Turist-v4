using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turist_App_v4.Model
{
    class Attraktioner
    {
        private string _vurderinger;
        private string _åbningstider;
        private string _telefon;
        private string _pris;
        private string _afstand;
        private string _beskrivelse;
        private string _navn;
        private string _adresse;
        
        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Beskrivelse
        {
            get { return _beskrivelse; }
            set { _beskrivelse = value; }
        }

        public string Afstand
        {
            get { return _afstand; }
            set { _afstand = value; }
        }

        public string Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }

        public string Åbningstider
        {
            get { return _åbningstider; }
            set { _åbningstider = value; }
        }

        public string Vurderinger
        {
            get { return _vurderinger; }
            set { _vurderinger = value; }
        }

        public Attraktioner(string vurderinger, string åbningstider, string telefon, string pris, string afstand, string beskrivelse, string navn, string adresse)
        {
            _vurderinger = vurderinger;
            _åbningstider = åbningstider;
            _telefon = telefon;
            _pris = pris;
            _afstand = afstand;
            _beskrivelse = beskrivelse;
            _navn = navn;
            _adresse = adresse;
        }

        public override string ToString()
        {
            return Navn;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindwerk_Domain.Business.Norm.Tables
{
    public class Gebruiker
    {
        private int _gebruikerID;
        private string _naam;
        private string _voornaam;
        private string _email;
        private int _telefoonnummer;
        private DateTime _geboortedatum;
        private string _wachtwoord;

        public int GebruikerID
        {
            get { return _gebruikerID; }
            set { _gebruikerID = value; }
        }
        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public int Telefoonnummer
        {
            get { return _telefoonnummer; }
            set { _telefoonnummer = value; }
        }
        public DateTime Geboortedatum
        {
            get { return _geboortedatum; }
            set { _geboortedatum = value; }
        }
        public string Wachtwoord
        {
            get { return _wachtwoord; }
            set { _wachtwoord = value; }
        }
        public Gebruiker(int gebruikerID, string naam, string voornaam, string email, int telefoonnummer, DateTime geboortedatum, string wachtwoord)
        {
            _gebruikerID = gebruikerID;
            _naam = naam;
            _voornaam = voornaam;
            _email = email;
            _telefoonnummer = telefoonnummer;
            _geboortedatum = geboortedatum;
            _wachtwoord = wachtwoord;
        }
        public Gebruiker(string naam, string voornaam, string email, int telefoonnummer, DateTime geboortedatum, string wachtwoord)
        {
            _gebruikerID = 0;
            _naam = naam;
            _voornaam = voornaam;
            _email = email;
            _telefoonnummer = telefoonnummer;
            _geboortedatum = geboortedatum;
            _wachtwoord = wachtwoord;
        }

        public override string ToString()
        {
            return _gebruikerID + " - " + _naam + " - " + _voornaam + " - " + _email + " - " + _telefoonnummer + " - " + _geboortedatum.ToShortDateString() + " - " + _wachtwoord;
        }

    }
}

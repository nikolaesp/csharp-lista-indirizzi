using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    internal class Addresses
    {
        private string Name;
        private string Surname;
        private string Street;
        private string City;
        private string Province;
        private string ZIP;

        public Addresses(string name, string surname, string street, string city, string province, string zip)
        {
            this.Name = name;
            this.Surname = surname; 
            this.Street= street;    
            this.City= city;
            this.Province = province;
            this.ZIP = zip;
        }
        public string GetZip() { return this.ZIP; }
        public void SetZip(string zip) { this.ZIP = zip;}
        public string GetSurname()
        {
            return GetSurname();
        }

        public void SetSurname(string value)
        {
            SetSurname(value);
        }

        public string GetStreet()
        {
            return GetStreet();
        }

        public void SetStreet(string value)
        {
            SetStreet(value);
        }

        public string GetCity()
        {
            return GetCity();
        }

        public void SetCity(string value)
        {
            SetCity(value);
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string value)
        {
            Name = value;
        }

        public override string ToString()
        {
            return "---------------------------------------------------------------------------------" +
                "\nPerson: " + Name + "\t" + Surname + 
                "\nAddress:\t"+ Street+ "\t"+City+"\t"+Province+"\t"+ZIP+"\n" +
                   "---------------------------------------------------------------------------------";
        }
    }
}

//Yizhou Wang
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__WPF___Class___Listbox
{
    class EntryForm
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }

        public EntryForm()
        {
            Name = string.Empty;
            Address = string.Empty;
            ZipCode = 0;
        }

        public EntryForm(string name, string address, int zipCode)
        {
            name = Name;
            address = Address;
            zipCode = ZipCode;
        }

        public EntryForm(string address,int zipCpde)
        {
            Name = string.Empty;
            Address = address; 
            ZipCode = zipCpde;
        }
        public override string ToString()
        {
            return base.ToString();
           // return $"Thank you {Name}, you live in {Address},and your zipcode is {ZipCode}";
        }
    }
}

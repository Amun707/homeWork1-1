using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork1
{
    public class Postoffice
    {
        private int index;
        private string city;
        private string street;
        private int homenumber;
        private int corpusnumber;
        private int flatnumber;
        private string message;

        public Postoffice(int index, string city, string street, int homenumber, int corpusnumber, int flatnumber, string message)
        {
            this.index = index;
            this.city = city;
            this.street = street;
            this.homenumber = homenumber;
            this.corpusnumber = corpusnumber;
            this.flatnumber = flatnumber;
            this.message = message;
        }
        public void AddresOfRecipient()
        {
            Console.WriteLine(index);
            Console.WriteLine(city);
            Console.WriteLine(street);
            Console.WriteLine(homenumber);
            Console.WriteLine(corpusnumber);
            Console.WriteLine(flatnumber);
            Console.WriteLine(message);
        }
    }
}

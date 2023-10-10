using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavAutoDev
{
    public class Contract
    {
        public string Number { get; set; }
        public List<Auto> Auto { get; set; }
        public List<Contact> Contact { get; set; }
        public string Summa { get; set; }
        public string FactSumma { get; set; }
        public string Fact { get; set; }
        public List<Invoice> Invoices { get; set; }
    }
    
    public class Auto
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Details { get; set; }
        public string VIN { get; set; }
    }

    public class Contact
    {
       public string FullName { get; set; }
    }

    public class Invoice
    {
        public string Number { get; set; }
        public string Date { get; set; }
        public string Amount { get; set; }
        public string Fact { get; set; }
        public string TypeNameInvoice { get; set; }
    }

}

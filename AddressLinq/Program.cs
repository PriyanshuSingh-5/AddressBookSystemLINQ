using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Data LINQ Operartion Program");
            //AddressDataTable.AddDataIntoTable();
            //AddressDataTable.EditExistingContactDetails("Mansingh", "Meena", 322514);
            //AddressDataTable.DeleteContactUsingName();
            //AddressDataTable.RetrievingContactDetailsByCityOrState();
            AddressDataTable.GetCountOfContactInCityOrState();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace ReadWriteInJSON
{
    class AddressBookCsv
    {
        public static void Implement_CSV(List<TakeContacts> list)
        {
            string exportFilePath = @"C:\Users\Sashi\Desktop\AdressBoook\AdressBookProblem\ReadWriteInJSON\Utility\AddressBook.csv";

            using (var writer = new StreamWriter(exportFilePath))
            using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvExport.WriteRecords(list);
            }
        }

        public static void Implement_CSV_Read()
        {
            string FilePath = @"C: \Users\Sashi\Desktop\AdressBoook\AdressBookProblem\ReadWriteInJSON\Utility\AddressBook.csv";

            using (var reader = new StreamReader(FilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<TakeContacts>().ToList();
                Console.WriteLine("Read data successfully from addresses csv.");
                foreach (TakeContacts addressData in records)
                {
                    Console.Write("\t" + addressData.FirstName);
                    Console.Write("\t" + addressData.LastName);
                    Console.Write("\t" + addressData.Address);
                    Console.Write("\t" + addressData.City);
                    Console.Write("\t" + addressData.State);
                    Console.Write("\t" + addressData.Zip);
                    Console.Write("\t" + addressData.Phone_number);
                    Console.Write("\t" + addressData.Email + "\n");
                }
            }
        }
    }
}
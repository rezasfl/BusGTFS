using System;
using System.IO;
using LumenWorks.Framework.IO.Csv;


namespace GTFS
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (CsvReader file =
                new CsvReader(new StreamReader(@"C:\Users\rez\Desktop\WGTNgoogle-transit\agency.txt"), true))
                {
                    int fieldCount = file.FieldCount;

                    string[] headers = file.GetFieldHeaders();

                    while (file.ReadNextRecord())
                    {
                        for (int i = 0; i < fieldCount; i++)
                            Console.Write(string.Format("{0 } = {1 };", headers[i], file[i]));
                        Console.WriteLine();
                    }
                }

                Console.ReadKey();
            }

            catch
            {

            }
        }
    }
}

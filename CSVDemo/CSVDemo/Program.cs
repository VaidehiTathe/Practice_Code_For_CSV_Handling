using System;
using System.Data;
using System.IO;
using LumenWorks.Framework.IO.Csv;

namespace CSVDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(@"E:\CodinClub\Fellowship_Demos\CSVDemo\CSVDemo\data.csv")), true))
            {
                csvTable.Load(csvReader);
            }
            string Column1 = csvTable.Columns[0].ToString();
            string Row1 = csvTable.Rows[0][0].ToString();
            Console.WriteLine(Column1);
            Console.WriteLine(Row1);
            Console.WriteLine("Hello World!");
        }
    }
}

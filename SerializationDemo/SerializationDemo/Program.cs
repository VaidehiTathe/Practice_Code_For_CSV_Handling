using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Tutorial obj = new Tutorial();
            obj.ID = 1;
            obj.Name = ".Net";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("E:\\Example.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, obj);
            stream.Close();

            stream = new FileStream("E:\\Example.txt", FileMode.Open, FileAccess.Read);
            Tutorial objNew = (Tutorial)formatter.Deserialize(stream);
            Console.WriteLine(objNew.ID);
            Console.WriteLine(objNew.Name);

            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}

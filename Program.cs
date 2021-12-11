using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {



            /////////первая часть
            string RequestInput(string msg)
            {
                Console.WriteLine(msg);
                return Console.ReadLine();
            }

            var ar = new List<Tovar>();
            string json1 = "";
            for (int i = 0; i <= 4; i++)
            {
                
               int kod = int.Parse(RequestInput("Введите код товара"));
                string name = RequestInput("Введите название товара");
                double price = double.Parse(RequestInput("Введите цену товара"));            
                ar.Add(new Tovar() { kod = kod, name = name, price= price });
            }
            json1 = JsonConvert.SerializeObject(ar);
          
            File.WriteAllText(@"D:\Products.json", json1);

            ///вторая часть
            // string jsonstr2 = File.ReadAllText(@"D:\Products.json");
            // var json2 = JsonConvert.DeserializeObject<List<Tovar>>(jsonstr2);
            // var maxValue = json2.Max(x => x.price);
            // var result = json2.Last(x => x.price == maxValue).name;


        }
    }
}

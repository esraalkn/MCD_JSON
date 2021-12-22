using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MCD_JSONOkuma
{
    class Program
    {
        static void Main(string[] args)
        {
            string JsonOkunanData = File.ReadAllText("C:\\JsonIslemlerim\\Personellerim.json");
            List<Personel> Data = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Personel>>(JsonOkunanData);
            for (int i = 0; i < 50; i++)
            {
                Console.Write(Data[i].Isim + " ");
                Console.WriteLine(" ");
                Console.Write(Data[i].Soyisim);
                
            }
            Console.ReadLine();
        }
    }
}

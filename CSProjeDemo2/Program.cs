using Newtonsoft.Json;
using System.IO;

namespace CSProjeDemo2
{
    public class ReadJsonDto
    {
        public string name { get; set; }
        public string title { get; set; }
    }
    public class BordrdoDto
    {
        public string PersonelIsmi { get; set; }
        public int CalismaSaati { get; set; }
        public decimal AnaOdeme { get; set; }
        public decimal Mesai { get; set; }
        public decimal ToplamOdeme { get; set; }
    }

    


    public class Program
    {
        public static void Main(string[] args)
        {
            var path = @"C:\Users\fafsi\OneDrive\Masaüstü\deneme.json";

            var listPersonel = ReadJson(path);
            MaasBordro.MaasHesaplaKaydet(listPersonel);
        }
        public static List<ReadJsonDto> ReadJson(string path)
        {
            var json = File.ReadAllText(path);
            var listPersonel = JsonConvert.DeserializeObject<List<ReadJsonDto>>(json);
            return listPersonel;
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class MaasBordro
    {
        public static void MaasHesaplaKaydet(List<ReadJsonDto> listPersonel)
        {
            List<BordrdoDto> listBordo = new List<BordrdoDto>();

            foreach (var item in listPersonel)
            {
                Yonetici manager = new Yonetici();
                Memur memur = new Memur();
                if (item.title == "Yonetici")
                {
                    manager.name = item.name;
                    Console.WriteLine($"Müdür olan {item.name} personelinin Saatlik ücretini giriniz ? ");
                    manager.saatlikUcret = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Müdür olan {item.name} personelinin çalışma saatini giriniz ? ");
                    manager.calismaSaati = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Müdür olan {item.name} personelin bonusunu giriniz ? ");
                    manager.bonus = decimal.Parse(Console.ReadLine());
                    listBordo.Add(manager.MaasHesapla());
                }
                else
                {
                    memur.name = item.name;

                    Console.WriteLine("Derece 1-2-3");
                    Console.WriteLine($"Memur olan {item.name} personelinin Derecesini giriniz");
                    int derece = int.Parse(Console.ReadLine());
                    switch (derece)
                    {
                        case 1:
                            memur.saatlikUcret = 500;
                            break;
                        case 2:
                            memur.saatlikUcret = 550;
                            break;
                        case 3:
                            memur.saatlikUcret = 600;
                            break;
                        default:
                            throw new Exception("Derece bilgisi yanlızca 1-2-3 olmalıdır");
                    }

                    Console.WriteLine($"Memur olan {item.name} personelinin çalışma saatini giriniz ? ");
                    memur.calismaSaati = int.Parse(Console.ReadLine());
                    listBordo.Add(memur.MaasHesapla());

                }
            }
            var docPath = @"C:\Users\fafsi\OneDrive\Documents\zehra\deneme.json";
            var json = JsonConvert.SerializeObject(listBordo);
            File.WriteAllText(docPath, json);

            foreach (var item in listBordo)
            {
                Console.WriteLine("Personel İsmi =  " + item.PersonelIsmi);
                Console.WriteLine("Çalışma Saati =  " + item.CalismaSaati);
                Console.WriteLine("Ana Odeme =  " + item.AnaOdeme);
                Console.WriteLine("Mesai =  " + item.Mesai);
                Console.WriteLine("Toplam Ödeme =  " + item.ToplamOdeme);
            }

            var azCalisanlar = listBordo.Where(x => x.CalismaSaati < 150);
            Console.WriteLine("***150 saatten az çalışan personeller ***");
            foreach (var item in azCalisanlar)
            {
                Console.WriteLine("Personel İsmi =  " + item.PersonelIsmi);
                Console.WriteLine("Çalışma Saati =  " + item.CalismaSaati);
                Console.WriteLine("Ana Odeme =  " + item.AnaOdeme);
                Console.WriteLine("Mesai =  " + item.Mesai);
                Console.WriteLine("Toplam Ödeme =  " + item.ToplamOdeme);
            }
        }
    }

}

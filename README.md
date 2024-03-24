# Maaş Bordro Programı

Bu proje, küçük bir şirketin maaş bordrolarını oluşturan bir uygulamayı içerir. Şirketin farklı tiplerdeki personeli için maaş hesaplaması, kayıt altına alma ve raporlama işlemlerini gerçekleştirir. Ayrıca yeni personel kadroları eklendikçe genişletilebilir.

## Beklenen İşlevler

- Her personelin maaşı, saatlik ücret * çalışma saati bilgilerine göre hesaplanır.
- Yöneticilerin saatlik ücreti en az 500 TL'dir ve bonus adlı ek bir ödeme alırlar.
- Memurların maaşı maksimum 180 saat üzerinden hesaplanır. 180 saati geçen her çalışma süresi normal saatlik ücretin 1.5 katı bedelle belirlenerek ek mesai ücreti olarak ana maaşa eklenir.
- Memurun saatlik ücreti varsayılan olarak 500 TL'dir, ancak memurun derecesine göre değişebilir.
- Memur ve Yönetici listesi bir JSON dosyası olarak verilecek ve program bu dosyadan okuma yaparak personelin maaş bilgilerinin girişini isteyecektir.
- Hesaplanan maaş bilgileri her personelin adına açılan klasörün içine maaş tarih bilgisiyle birlikte JSON formatında kaydedilecektir.
- Program sonunda maaş hesabı yapılan tüm personelin rapor görüntüsünün ekrana yazdırılmasını ve ayrıca 150 saat az çalışan personellerin bilgilerinin belirtilmesi gerekmektedir.

## Başlangıç

Bu projenin temel bileşenleri şunlardır:

1. **Personel (Abstract)**: Temel bilgileri içerir ve temel ücreti hesaplamak için bir metot sağlar.
2. **Yönetici ve Memur (Sub Class)**: Personel sınıfını devralır ve maaş hesaplaması için MaasHesapla() metodunu override eder.
3. **DosyaOku**: Bir JSON dosyasından okuyan ve içeriğe dayalı olarak Personel nesnelerinin bir listesini oluşturan bir metot içerir.
4. **MaasBordro**: Her çalışanın maaş bordrosunu oluşturur ve ayda 10 saatten az çalışan personelin ayrıntılarının bir özetini de oluşturur.
5. **Program**: Bir konsol uygulamasıyla geliştirilen class library çalıştırmak için kullanılır.

## Kullanım

Programı çalıştırmak için aşağıdaki adımları izleyin:

1. Proje dosyalarını indirin veya klonlayın.
2. Projeyi Visual Studio veya tercih ettiğiniz bir IDE'de açın.
3. Programı derleyin ve çalıştırın.
4. JSON dosyasında belirtilen personel bilgilerini girin.
5. Program, maaş bordrosunu oluşturacak ve ekrana yazdıracaktır.



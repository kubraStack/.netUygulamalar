using System;

namespace uygulamaKosulIfadeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1- Kullanıcan isim, yaş ve eğitim bilgilerini isteyip ehliyet alabilme 
            // durumunu kontrol ediniz.Ehliyet alma koşulu en az 18 yaş ve eğitim durumu lise veya üniversite olmalıdır.

            // System.Console.Write("Name: ");
            // string name = Console.ReadLine();

            // System.Console.Write("Age: ");
            // int age = int.Parse(Console.ReadLine());

            // System.Console.Write("Educational: ");
            // string edu = Console.ReadLine();
            // // yas bilgisi kontrol
            // if(age >= 18){
            //     // eğitim bilgilerini kontrol
            //     if(( edu == "lise") || (edu == "üniversite")){
            //         System.Console.WriteLine($"{name} Ehliyet Alabilirsiniz");
            //     }
            //     else{
            //         System.Console.WriteLine($"{name} Ehliyet almak için eğitim seviyeniz yetersiz.");
            //     }
            // }else{
            //     System.Console.WriteLine($"{name} Ehliyet almak için yaşınız en az 18 olmalı");
            // }
           

            // 2- Girilen 3 sayıdan en büyüğü bulunuz.

            // System.Console.Write("Sayı 1: ");
            // int sayı1 = int.Parse(Console.ReadLine());

            // System.Console.Write("Sayı 2: ");
            // int sayı2 = int.Parse(Console.ReadLine());

            // System.Console.Write("Sayı 3: ");
            // int sayı3 = int.Parse(Console.ReadLine());

            // if(sayı1 > sayı2 && sayı1 < sayı3){
            //     System.Console.WriteLine("Sayı 1 en büyük.");
            // }else if( sayı2 > sayı1 && sayı2 > sayı3){
            //     System.Console.WriteLine("Sayı 2 en büyük.");
            // }else if(sayı3 > sayı1 && sayı3 > sayı2){
            //     System.Console.WriteLine("Sayı 3 en büyük.");
            // }else{
            //     System.Console.WriteLine("Yanlış Bilgi");
            // }

            // 3- Bir öğrencinin 2 yazılı bir sözlü sınavNotuunu alıp hesaplanan ortamaya göre sınavNotu aralığına karşılık gelen sınavNotu bilgisini yazdırınız.

                // 0 - 24 => 0
                // 25 - 44 = > 1
                // 45 - 54 => 2
                // 55 - 69 => 3
                // 70 - 84 => 4
                // 85 - 100 => 5

                // System.Console.Write("Yazılı Sınav 1: ");
                // int yazılı1 = int.Parse(Console.ReadLine());

                // System.Console.Write("Yazılı Sınav 2: ");
                // int yazılı2 = int.Parse(Console.ReadLine());

                // System.Console.Write("Sözlü Sınav: ");
                // int sozluSınav = int.Parse(Console.ReadLine());

                // var ortalama = (yazılı1 + yazılı2 + sozluSınav) / 3;
                // int sınavNotu = -1;

               
                // if (ortalama>=0 && ortalama<25)
                //     sınavNotu = 0;
                // else if (ortalama>=25 && ortalama<45)
                //     sınavNotu = 1;
                // else if (ortalama>=45 && ortalama<55)
                //     sınavNotu = 2;
                // else if (ortalama>=55 && ortalama<70)
                //     sınavNotu = 3;
                // else if (ortalama>=70 && ortalama<85)
                //     sınavNotu = 4;
                // else if (ortalama>=85 && ortalama<100)
                //     sınavNotu = 5;
                // else 
                //     Console.WriteLine("yanlış sınavNotu");

                // Console.WriteLine($"sınavNotu ortalamalası: {ortalama} ve sınavNotuunuz: {sınavNotu}");
                
        
            // 4- Trafiğe çıkış tarihi alınan bir aracın servis zamanını 
            //    aşağıdaki bilgilere göre hesaplayınız.
            //    1. Bakım => 1. yıl     
            //    2. Bakım => 2. yıl      
            //    3. Bakım => 3. yıl     
            //    ** Süre hesabını alınan gün, ay, yıl bilgisine göre gün bazlı hesaplayınız..

                    Console.Write("yıl: ");
                    int yil = int.Parse(Console.ReadLine());

                    Console.Write("ay: ");
                    int ay = int.Parse(Console.ReadLine());

                    Console.Write("gün: ");
                    int gun = int.Parse(Console.ReadLine());

                    var toplamGun = new DateTime(yil,ay,gun).Day;

                    if (toplamGun<=365)
                        Console.WriteLine("1.servis");
                    else if(toplamGun>365 && toplamGun<=365*2)
                        Console.WriteLine("2.servis");
                    else if(toplamGun>365*2 && toplamGun<=365*3)
                        Console.WriteLine("3.servis");
                    else
                        Console.WriteLine("yanlış bilgi");

        }
            
    }
}

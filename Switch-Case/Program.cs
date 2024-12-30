using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Switch_Case
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // C# programlama dilinde switch-case ifdesi if-else ifadesi ile aynı işlemi yapmaktadır. Yani switch-case ifadesi if-else ifadesi gibi akış denetimini kontrol etmektedir.
            //C# programlama dilinde switch-case komutu if ile yapılacak işlemlerin karışık olduğu durumlarda daha sade ve anlaşılır bir kod yapısı oluşturmak için kullanılmaktadır. 
            //Switch -case komutunda:
            // switch : Switch ifadesine koşul için gerekli olan değişken girilir.
            //case : Case ifadesi durumları kontrol etmek için kullanılır ve karşılaşılacak durumlar girilir
            //break : Break komutu döngüyü kırmak için yani döngüden çıkmak için kullanılır.
            //default: Default ifadesi durumlardan herhangi biri yok ise yapılacak işlemler

            //Switch -case komutu program akışında verilen şarta uygun değer olup olmadığına bakar ve buna göre işlem yapmaktadır.Eğer uygun değer yok ise kendi içerisinde bulunan default değerini aktif eder ve oradaki komutları devreye sokar.

            //Bilgi: İf -else komutu ile yapılan işlemlerin hepsi switch-case komutu ile yapılamamaktadır.Fakat switch-case ile yapılan işlemlerin hepsini if-else komutu ile yapabilirsiniz.

            // C# Switch-Case Kullanımı:
            // İlk olarak switch komutunun içindeki koşul alınır ve switch-case ifadesinin içine girilir.
            // Program akışında verilen case içindeki değerlere bakılır.
            // Verilen koşul ile case içindeki değer eşleşiyorsa, eşleşen case içindeki işlemler yapılır.
            // İşlem yapıldıysa break komutu ile işlem kırılır ve switch-case den çıkılır.
            //Eğer switch komutunda verilen koşul hiçbir case değerinde yok ise default komutu çalıştırılır ve döngüden çıkılır.

            ////ÖRNEK: Klavyeden girilen sayının hangi güne ait olduğunu bulan program.

            //Console.WriteLine("Lütfen bir sayı giriniz: ");
            //int sayi = Int32.Parse(Console.ReadLine());

            //switch (sayi)
            //{

            //    case 1: Console.WriteLine("Pazartesi"); break;
            //    case 2: Console.WriteLine("Salı"); break;
            //    case 3: Console.WriteLine("Çarşamba"); break;
            //    case 4: Console.WriteLine("Perşembe"); break;
            //    case 5: Console.WriteLine("Cuma"); break;
            //    case 6: Console.WriteLine("Cumartesi"); break;
            //    case 7: Console.WriteLine("Pazar"); break;

            //    default: Console.WriteLine("Hata Böyle bir gün yok"); break;
            //}

            //Console.ReadLine();


            ////ÖRNEK: Klavyeden girilen sayının hangi aya ait olduğunu bulan C# programını Switch-case kullanarak yazın.

            //Console.WriteLine("Lütfen bir sayı giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());

            //switch (sayi)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;

            //    default: Console.WriteLine("Hata Böyle bir ay yok"); break;
            //}
            //Console.WriteLine();


            //SORU_1: Klavyeden 1 ve 7 arasında bir sayı isteyen, girilen sayı sırasındaki haftanın gününü veren C# konsol uygulamasının kodları switch-case yapısını kullanarak aşağıdaki boşluğa yazın.
            //CEVAP:

            //Console.Write("1-7 arasında bir sayı girin: ");
            //int a = int.Parse(Console.ReadLine());

            //switch (a)
            //{
            //    case 1: Console.WriteLine("Haftanın 1.günü: Pazartesi"); break;
            //    case 2: Console.WriteLine("Haftanın 2.günü:Salı"); break;
            //    case 3: Console.WriteLine("Haftanın 3.günü:Çarşamba"); break;
            //    case 4: Console.WriteLine("Haftanın 4.günü:Perşembe"); break;
            //    case 5: Console.WriteLine("Haftanın 5.günü:Cuma"); break;
            //    case 6: Console.WriteLine("Haftanın 6.günü:Cumartesi"); break;
            //    case 7: Console.WriteLine("Haftanın 7.günü:Pazar"); break;

            //    default: Console.WriteLine("HATA! Böyle bir gün yoktur."); break;

            //}
            //Console.WriteLine();


            ////SORU_2: Aşağıdaki ekran çıktısı verilen soruyu switch-case yapısını kullanarak yapın. Her aritmetik işlem, geriye değer döndüren parametreli metotlar ile yapılsın.
            ////Programın sonunda 0 girişi yapıldığı durumda program başa dönerek tekrar çalışmalıdır. 0 girişi yapılmadığında ise program başa dönmeyip “Devam etmek için 0’a basın” ifadesi tekrar edilmelidir.
            ////Ayrıca “Seçiminiz”  kısmında 5’e basılırsa program sonlanmalıdır. Programa ait tüm metotları aşağıdaki boşluğa yazın.
            ////CEVAP:

            //Islem();
            //Console.WriteLine();


            //SORU_3: 20 elemanlı bir tam sayı dizisine 7’den itibaren 7’nin katlarını ekleyen ve bu sayıları yan yana ekrana yazdıran void metodu yazın kodunu yazın.
            //CEVAP:

            //YedininKatlari();
            //Console.WriteLine();


            ////SORU_4: 15 elemanlı bir diziyi en küçük asal sayıdan itibaren, asal sayılar ile dolduran kodu yazın.
            ////CEVAP_1:

            //int[] asalDizi = new int[15];
            //int index = 0;
            //int sayi = 2;

            //for (int i = 0; i < asalDizi.Length;)
            //{

            //    if (asalKontrol(sayi))
            //    {

            //        asalDizi[i] = sayi;
            //        i++;
            //    }
            //    sayi++;

            //}
            //for (int i = 0; i < asalDizi.Length; i++)
            //{
            //    Console.WriteLine(asalDizi[i]);
            //}

            ////CEVAP_2:

            //AsalSayilarDizisi();



            //SORU_5:Rastgele değerde 10 elemanlı bir sayı dizisi oluşturun. Bu dizi içerisindeki tek sayıları başka bir diziye ekleyip, çift sayıları da bambaşka bir diziye ekleyen programı yazın.  
            //Bir dizinin elemanını aralarına boşluk koyarak yan yana yazdıran metodu yazın. Bu metot ile bu sorudaki 3 diziyi de ekrana yazdırın.
            //CEVAP_1:

            //rastgeleDizi();
            //Console.WriteLine();

            //CEVAP_2:




         //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        
        
        }


        //SORU_2:

        static int toplama(int a, int b)
        {
            int sonuc = a + b;
            return sonuc;
        }

        static int cikarma(int a, int b)
        {
            int sonuc = a - b;
            return sonuc;
        }

        static int carpma(int a, int b)
        {
            int sonuc = a * b;
            return sonuc;
        }

        static float bölme(int a, int b)
        {
            float sonuc = a / b;
            return sonuc;
        }

        static void Islem()
        {
        Bas:
            Console.Write("1. Sayıyı girin: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("2. Sayıyı girin: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Toplama için 1'e basın");
            Console.WriteLine("Çıkarma için 2'e basın");
            Console.WriteLine("Çarpma için 3'e basın");
            Console.WriteLine("Bölme için 4'e basın");
            Console.WriteLine("Çıkış için 5'e basın");

            Console.Write("Seçiminiz: ");
            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1: Console.WriteLine("İşlem sounucu: " + toplama(a, b)); break;
                case 2: Console.WriteLine("İşlem sounucu: " + cikarma(a, b)); break;
                case 3: Console.WriteLine("İşlem sounucu: " + carpma(a, b)); break;
                case 4: Console.WriteLine("İşlem sounucu: " + bölme(a, b)); break;
                case 5: Console.WriteLine("Çıkış yapıldı."); Environment.Exit(0); break;

                default: Console.WriteLine("Geçersiz giriş"); break;

            }
            Console.WriteLine();

            int sonuc = 0;
            Console.WriteLine();
            Console.Write("Devam etmek için 0'a basın: ");
            int devam = int.Parse(Console.ReadLine());

            Console.Clear();
            goto Bas;



            //SORU_3:

            static void YedininKatlari()
            {
                int sayac = 0;
                int[] dizi = new int[20];
                for (int i = 0; i < dizi.Length; i++)
                {
                    sayac++;
                    dizi[i] = 7 * sayac;
                    Console.Write(dizi[i] + " ");
                }

            }




            //SORU_4: 

            //CEVAP_1:

            static bool asalKontrol(int sayi)
            {

                for (int i = 2; i <= sayi / 2; i++)
                {
                    if (sayi % i == 0)
                    {
                        return false;

                    }

                }
                return true;
            }

            ////CEVAP_2:

            static bool AsalMi(int sayi)
            {
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            static void AsalSayilarDizisi()
            {
                int[] dizi = new int[15];
                int index = 0;
                int sayi = 2; //en küçük asal sayı
                while (index < dizi.Length)
                {
                    bool sonuc = AsalMi(sayi);
                    if (sonuc == true)
                    {
                        dizi[index] = sayi;
                        index++;
                    }

                    sayi++;

                }
                DiziYazdir(dizi);
            }

            static void DiziYazdir(int[] dizi)
            {
                for (int i = 0; i < dizi.Length; i++)
                {
                    Console.Write(dizi[i] + " ");
                }
                Console.WriteLine();
            }


            //SORU_5:
            //CEVAP_1:

            static void rastgeleDizi()
            {

                int[] dizi = new int[10];
                Random rnd = new Random();
                int cift = 0;
                int tek = 0;
                int[] c = new int[dizi.Length];
                int[] t = new int[dizi.Length];


                Console.Write("\nRastgele oluşan dizi: ");
                for (int i = 0; i < dizi.Length; i++)
                {
                    dizi[i] = rnd.Next(1, 100);
                    Console.Write(dizi[i] + " ");
                }


                for (int i = 0; i < dizi.Length; i++)
                {
                    if (dizi[i] % 2 == 0)
                    {
                        c[cift] = dizi[i];
                        cift++;

                    }
                    else
                    {
                        t[tek] = dizi[i];
                        tek++;
                    }

                }

                Console.Write("\nçift sayılar dizisi: ");
                for (int i = 0; i < cift; i++)
                {
                    Console.Write(c[i] + " ");
                }

                Console.Write("\nTek sayılar dizisi: ");
                for (int i = 0; i < tek; i++)
                {
                    Console.Write(t[i] + " ");
                }


                //CEVAP_2:

                static int[] RastgeleDiziOlustur (int kapasite)
        {
            int[] dizi = new int[kapasite];
            Random rnd = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rnd.Next(10,100);
            }
            return dizi;
        }

        static int TekCiftSayiAdediGetir(int[] dizi, string tip)
        {
            int tekAdet = 0;

            for(int i =0; i < dizi.Length; i++)
            {
                if (dizi[i] %2 == 1)
                {
                   tekAdet++; 
                }
            }

            if(tip == "tek")
            {
                return tekAdet;
            }
            else
            {
                return dizi.Length - tekAdet;
            }
        }

        static void TekCiftSayilarDizisi()
        {
            int[] tumSayilar = RastgeleDiziOlustur(10);
            int[] tekSayilar = new int[TekCiftSayiAdediGetir(tumSayilar, "tek")];
            int[] ciftSayilar = new int[TekCiftSayiAdediGetir(tumSayilar, "cift")];

            int tekIndex = 0;
            int ciftIndex = 0;

            for (int i = 0; i < tumSayilar.Length; i++)
            {
                if (tumSayilar[i] % 2 == 0)
                {
                    ciftSayilar[ciftIndex] = tumSayilar[i];
                    ciftIndex++;
                }
                else
                {
                    tekSayilar[tekIndex] = tumSayilar[i];
                    tekIndex++;

                }
            }
            DiziYazdir(tumSayilar);
            DiziYazdir(tekSayilar);
            DiziYazdir(ciftSayilar);
            }































            }
        }









    }
}


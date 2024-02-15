namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Otomobil oto;
            //oto= new Otomobil();
            //oto.Marka = "Renault";
            //oto.Model = "Clio 4";
            //oto.ModelYili = 2020;
            //oto.Renk = "Beyaz";
            //oto.VitesTipi = "Manuel";


            //toplamaYap(5, 7);
            //Console.WriteLine("İşlemin Sonucu: "+ toplamaYap(5, 7));

            int sayi1;
            int sayi2;
            Console.Write("Bir sayı giriniz:");
            sayi1 = int.Parse(Console.ReadLine());
            Console.Write("Bir sayı giriniz:");
            sayi2 = int.Parse(Console.ReadLine());
            BuyukKucuk(sayi1, sayi2);



            //TekCift(sayi);
            //if (KareAl(sayi)<25)
            //{
            //    Console.WriteLine("Sayının değeri:"+ KareAl(sayi)+" 25'den küçüktür.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayının değeri:"+ KareAl(sayi)+"  25'den büyüktür.");
            //}

            Console.ReadLine();
        }
        static int toplamaYap(int sayi1, int sayi2)
        {
            int sonuc1=sayi1+sayi2;
            return sonuc1;
        }

        static int KareAl(int sayi)
        {
            return sayi * sayi;
        }

        static void TekCift(int sayi)
        {
            if (sayi%2==0)
            {
                Console.WriteLine("Girmiş olduğunuz sayi("+sayi+") çifttir...");
            }
            else
            {
                Console.WriteLine("Girmiş olduğunuz sayi(" + sayi + ") tektir...");
            }
        }
        static void BuyukKucuk(int sayi1,int sayi2)
        {
            if (sayi1>sayi2)
            {
                Console.WriteLine("Birinci sayı("+sayi1+") ikinci sayıdan("+sayi2+") büyüktür.");
            }
            else if (sayi1 < sayi2)
            {
                Console.WriteLine("Birinci sayı(" + sayi1 + ") ikinci sayıdan(" + sayi2 + ") küçüktür.");
            }
            else
            {
                Console.WriteLine("Birinci sayı(" + sayi1 + ") ikinci sayıya(" + sayi2 + ") eşittir.");
            }
        }
    }
}

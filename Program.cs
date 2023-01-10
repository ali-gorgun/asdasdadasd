using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** atama ve islemli atama operatorleri *****");
            // atama ve işlemli atama
            int x = 3;
            int y = 3;
            y = y+2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /=1;
            Console.WriteLine(y);
            x *=2; 
            Console.WriteLine(x);

            Console.WriteLine("***** mantiksal operatorler *****");
            // mantıksal operatorler
            //, ||(veya), &&(ve), ! (neyin başına gelirse değilini(tersi) alırız)
            
            
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect!");

            if(isSuccess || isCompleted)
                Console.WriteLine("Great!");

            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine!");


            Console.WriteLine("***** iliskisel operatorler *****");
            //ilişkisel operatorler
            // >, >, <=, >=, ==, !=

            int a =3;
            int b =4;
            bool sonuc = a<b;

            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

            Console.WriteLine("***** aritmetik operatorler*****");
            // /, *, +, - 

            int sayi1 =10;
            int sayi2 =5;
            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            Console.WriteLine(sayi1);

            // % mod almak ıcın kullanılır
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);

            // alı gorgun


        }
    }
}

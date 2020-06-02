using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Metotlar1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metotlar
            //Bir program geliştirirken, aynı kod bloklarını defalarca kullanmamız gerekebilir. Yazdığımız bir kodu birden fazla yerde kullanmak istediğimizde, kullanacağımız her alan altına çalışmasını istediğimiz kod bloklarını yazmamız gerecektir. Böyle durumlarda yazılımcı aynı kodları yazarken vakit kaybetmiş olur. Aynı zamanda birden fazla yerde kullandığımız kodlarda bir değişiklik yaptığımızda her yerde bu değişikliği yapmamız gerekecektir. Bu tip durumlarda metotları kullanabiliriz. 

            //Birden fazla yerde kullanacağımız kodları tek bir yapı içerisinde toplarız. Bu yapıyı istediğimiz yerden çağırarak kullanabiliriz. 

            //Metotlar ikiye ayrılır;
            //Geriye değer döndüren metotlar
            //Geriye değer döndürmeyen metotlar


            //Geriye değer döndürmeyen metotlar (void anahtar kelimesi)

            //Console.WriteLine("Merhaba");
            //Console.Read();

            //void Karsilama()
            //{
            //    Console.WriteLine("Merhaba");
            //}

            //Karsilama();
            //Karsilama();
            //Karsilama();
            //Console.Read();

            //Parametre alan metot
            //Bir metot dışardan parametrelerde alabilir. Bunun için metot adından sonra açıp kapattığımız (parantez) ler içerisinde parametrelerimizi belirleyebiliriz. Metot yanında açılan bu parantezlere ‘Metot Parantezleri’ denir. Eğer metot bir parametre almayacaksa  metot parantezleri açılır ve kapanır. İçerisine herhangi bir parametre tanımlaması yapılmaz. Bir metot sınırsız sayıda parametre alabilir. 

           //void Karsilama(string deger)
           // {
           //     Console.WriteLine("Merhaba " + deger);
           // }

           // Karsilama("Fatih");
           // Console.WriteLine("Lütfen adınızı yazın:");
           // string ad = Console.ReadLine();
           // Karsilama(ad);
           // Console.Read();

            void Topla(int s1,int s2)
            {
                int toplam = s1 + s2;
                Console.WriteLine("Toplam= " + toplam);
            }
            Console.WriteLine("Sayı1: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayı2: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Topla(sayi1, sayi2);
            Console.Read();
        }
    }
}

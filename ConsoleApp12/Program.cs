namespace ConsoleApp12
{
    public class Sayac
    {
        public int i;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Programın Instance ı alındı çünkü çağıralacak fonksiyonlar static değil.
            //Program p = new();   //ByValue : Değerin kendisi gider
            //int i = 5;
            //p.func2(i);
            //Console.WriteLine(i);

            Sayac sayac = new Sayac { i=5}; //ByRef : Heapteki referans gider, kendisi değil
            Program p = new();
            p.funcSayac1(sayac);
            Console.WriteLine(sayac.i);

            
        }
        void funcSayac1(Sayac sayac)
        {
            sayac.i++;
            Console.WriteLine(sayac.i);
        }
        void func1(int i)
        {
            i++;
            Console.WriteLine(i);
            func1_1(i);
        }
        void func1_1(int i)
        {
            i++;
            Console.WriteLine(i);
            func1_2(i);
        }
        void func1_2(int i)
        {
            i++;
            Console.WriteLine(i);
            func1_3(i);
        }
        void func1_3(int i)
        {
            i++;
            Console.WriteLine(i);
        }
        void func2(int i)
        {
            i--;
            Console.WriteLine(i);
        }

    }
}
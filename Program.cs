using System;

namespace FP_SETUL_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pb1();
            //Pb2();
            //Pb3();
            //Pb4();
            //Pb5();
            //Pb6();
            //Pb7();
            //Pb8();
            //Pb9();
            //Pb10();
            //Pb11();
            //Pb12();
            Pb1212();
            
        }

        private static void Pb1212()
        {
            Console.WriteLine("Introduceti secventa de numere separate prin spatii:");
            string input = Console.ReadLine();

            int count = 0; // Contorul pentru grupurile consecutive diferite de zero
            int currentGroup = 0; // Variabila pentru a ține evidența grupului curent

            foreach (char c in input)
            {
                int num = c - '0'; // Convertim caracterul într-un număr

                if (num != 0)
                {
                    // Dacă numărul este diferit de zero, suntem într-un grup
                    currentGroup = 1; // Setăm lungimea grupului curent la 1
                    count++; // Creștem numărul total de grupuri
                }
                else
                {
                    // Dacă numărul este zero, nu mai suntem într-un grup
                    currentGroup = 0; // Setăm lungimea grupului curent la 0
                }
            }

            Console.WriteLine($"Numarul de grupuri consecutive diferite de zero este: {count}");
        }

        private static void Pb12()
        {
            int temp = 0;
            int s = 0
            Console.WriteLine("Introduceti lungimea sirului");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numerele");
            for (int i = 0;i<n;i++)
            {
                if (k != 0)
                {
                    temp = 1;
                    s++;
                }
                else
                {
                   temp = 0;
                }
            }
        }

        private static void Pb11()
        {
            int temp = 0;
            int s = 0;
            Console.WriteLine("Introduceti lungimea secventei de numere");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti numerele :");
            for (int i = 1; i <= n; i++)
            {
                int k = int.Parse(Console.ReadLine());
                while (k!=0)
                {
                    temp = temp * 10 + k % 10;
                    k = k / 10;
                }
                s = s + temp;
                temp = 0;
            }
           Console.WriteLine($"Suma inverselor numerelor din secventa este de {s}");
        }

        private static void Pb10()
        {
            int temp = 1;
            int p = 1;
            int max = 0;
            Console.WriteLine("Introduceti lungimea secventei");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numerele");
            int ant = int.Parse(Console.ReadLine());
            for (int i = 1;i<n;i++)
            {
                int k = int.Parse(Console.ReadLine());
                if (i > 0)
                {
                    
                    if (k == ant)
                    {
                     
                        temp++;

                    }
                    else
                    {
                        temp = 1;
                    }
                    if (temp > max)
                    {
                        max = temp;
                    }
                    ant = k;
                }        
            }
            
            Console.WriteLine($"Lungimea maxima de numere consecutive egale este de {max}");
        }

        private static void Pb9()
        {
            Console.WriteLine("Introduceti lungimea secventei:");
            int n = int.Parse(Console.ReadLine());

            int anterior = 0;
            bool esteCrescatoare = true;
            bool esteDescrescatoare = true;

            Console.WriteLine("Introduceti elementele secventei:");

            for (int i = 0; i < n; i++)
            {
                int curent = int.Parse(Console.ReadLine());

                if (i > 0)
                {
                    if (curent > anterior)
                    {
                        esteDescrescatoare = false;
                    }
                    else if (curent < anterior)
                    {
                        esteCrescatoare = false;
                    }
                }

                anterior = curent;
            }

            if (esteCrescatoare)
            {
                Console.WriteLine("Secventa este monoton crescatoare.");
            }
            else if (esteDescrescatoare)
            {
                Console.WriteLine("Secventa este monoton descrescatoare.");
            }
            else
            {
                Console.WriteLine("Secventa nu este monotona.");
            }

            Console.WriteLine("Seceventa nu este nici monoton crescatoare nici monoton descrescatoare");
        }

        private static void Pb8()
            {
            int n, i, x, y, z = 0;
            Console.WriteLine("Introduceti lungimea secventei");
            n = int.Parse(Console.ReadLine());

            if (n == 1 || n == 2)
                Console.WriteLine("1");
            else
            {
                x = 1;
                y = 1;
                for (i = 3; i <= n; i++)
                {
                    z = x + y;
                    x = y;
                    y = z;

                }
               
            }
            Console.WriteLine($"f_{n} este egal cu {z}");
            
            }
        private static void Pb7()
            {
            int min = 0;
            int max = 0;
            Console.WriteLine("Introduceti lungimea secventei de numere");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti numerele :");
            int x = int.Parse(Console.ReadLine());
            min = x;
            max = x;
            for (int i = 0; i < n-1; i++)
            {

                int k = int.Parse(Console.ReadLine());
                if (k > max)
                {
                    max = k;
                }
                else
                
                if(k<min)
                {
                    min = k;
                }
            }
            Console.WriteLine($"Cea mai mica valoarea a sirului este {min} , iar cea mai mare valoare este {max}");

        }
        private static void Pb6()
            {

            int x = 0;
            int check = 0;
            Console.WriteLine("Introduceti lungimea secventei de numere");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Introduceti numerele :");
            for (int i = 1; i <= n; i++)
            {

                int k = int.Parse(Console.ReadLine());
                if (x < k)
                { 
                    check = 1;
                    x = k;
                }
                else
                {
                    check = 0;
                }
            }
            if (check == 1)
            {
                Console.WriteLine("Numere din secventa sunt in ordine crescatoare");
            }
            else 
            {
                Console.WriteLine($"Numerele nu sunt in ordine crescatoare");
            }
        }
        private static void Pb5()
           {
            int s = 0;

            Console.WriteLine("Introduceti lungimea secventei de numere");
            int n = int.Parse(Console.ReadLine());
           // Console.Write("Introduceti numarul a=");
            //int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numerele :");
            for (int i = 0; i < n; i++)
            {
                int k = int.Parse(Console.ReadLine());
                if (i == k)
                    s++;
                
            }
            Console.WriteLine($"Sunt {s} numere care se afla pe aceasi pozitie cu valoarea lor");
           }
        private static void Pb4()
            {
            int s = 0;
            
            int ok;            Console.WriteLine("Introduceti lungimea secventei de numere");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numarul a=");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numerele :");
            for (int i = 1; i <= n; i++)
            {
                int k = int.Parse(Console.ReadLine());  
                if (a == k)
                    ok = k;
                else
                    s++;
            }
            Console.WriteLine($"Numarul a se alfa pe pozitia {s}");

            }
        private static void Pb3()
            {
            
            int s = 0;
            Console.WriteLine("Introduceti suma a cator numere vor fi calculate");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numerele :");
            for (int i = 1;  i<=n; i++)
            {
                int k = int.Parse(Console.ReadLine());
                s = s + k;
            }
            Console.WriteLine($"Suma numerelor introduse este suma = {s}");
            }

        private static void Pb2()
            {
            int neg = 0;    
            int zero = 0;   
            int poz = 0;
            int k = 0;
            Console.WriteLine("Introduceti cate numere vor fi verificat");
                int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numerele");
            for(int i=1; i <= n; i++)
            {
                k = int.Parse(Console.ReadLine());
                if (k < 0)
                    neg++;
                else
                    if (k == 0)
                    zero++;
                else
                if (k > 0)
                    poz++;
            }
            Console.WriteLine($"Sunt {neg} numere mai mici decat 0 , {zero} numere egale cu 0 si {poz} numere mai mari decat 0");

            }

        private static void Pb1()
        {
            int contor = 0;
            int k;
            Console.WriteLine("Introduceti cate numere vor fi verificate");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Introduce numerele");
            for (int i = 1; i <= n; i++)
            {
                k = int.Parse(Console.ReadLine());
                if (k % 2 == 0)
                {
                    contor++;
                }
            }
            Console.WriteLine($"Sunt {contor} numere pare ");
        }  
    }
}

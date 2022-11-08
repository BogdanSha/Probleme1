using System.Threading.Channels;

namespace Probleme1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EcGr1();
            //EcGr2();
            //DivizibilK();
            //AnBisect();
            //UltimaKCifra();
            //LaturiTriunghi();
            //Swap1();
            //Swap2();
            //DivizoriN();
            //NrPrim();
            //CifreInverse();
            //NrAniBisecti();
            //Palindrom();
            //TreiNrCrescator();
            //CMMDC_Si_CMMMC();
            //DescompunereFactPrimi();
            //VerificareDouaCifre();
            GhiciNr();
        }
        /// <summary>
        /// Se ghiceste un numar sub intrebari de forma "nr este mai mic, mai mare sau egal cu x"
        /// </summary>
        private static void GhiciNr()
        {
            bool cont = true;
            Random rand = new Random();
            int num = rand.Next(1, 1024);
            int guess;
            Console.WriteLine("Guess a number between 10 and 100");
            while (cont == true)
            {

                guess = int.Parse(Console.ReadLine());
                if (guess == num)
                {
                    Console.WriteLine("Congrats Champ, you guessed right!!!");
                    cont = false;
                    break;
                }
                if (guess > num)
                {
                    Console.WriteLine("Your number is higher, Guess Again!");
                }
                if (guess < num)
                {
                    Console.WriteLine("Your number is lower, Guess Again!");
                }
            }

        }
        /// <summary>
        /// Se verifca daca numarul dat este o secventa de 2 cifre care se pot repeta
        /// </summary>
        private static void VerificareDouaCifre()
        {
            int n, c1, c2,ok=1;
            n = int.Parse(Console.ReadLine());
            c1 = n % 10;
            while (n % 10 == c1)
            {
                n /= 10;
            }
            c2 = n % 10;
            while (n > 0)
            {
                int cif = n % 10;
                if (cif != c1 && cif != c2)
                {
                    ok = 0;
                    break;
                }
                n /= 10;
            }
            if (ok != 0)
            {
                Console.WriteLine("Numarul este o secventa formata din doar 2 cifre care se pot repeta");
            }
            else
            {
                Console.WriteLine("Numarul nu este o secventa formata din doar 2 cifre care se pot repeta");
            }
        }

        /// <summary>
        /// Se imparte un numar dat in factori primi
        /// </summary>
        private static void DescompunereFactPrimi()
        {
            int n, d  = 2, p;
            n=int.Parse(Console.ReadLine());
            while (n > 1)
            {
                p = 0;
                while (n % d == 0)
                {
                    p++;
                    n /= d;
                }
                if (p > 0)
                {
                    Console.Write($"{d}^{p}  ");
                }
                ++d;
                if (d * d > n && n > 1)
                {
                    d = n;
                }
            }
        }

        /// <summary>
        /// Se determina cmmdc si cmmmc dintre doua numere
        /// </summary>
        private static void CMMDC_Si_CMMMC()
        {
            int a, b, cl1, cl2;
            a=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            cl1 = a;
            cl2 = b;
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            Console.WriteLine($"Cel mai mare divizor comun al numerelor {cl1} si {cl2} este {a}");
            int cmmmc;
            cmmmc = (cl1 * cl2) / a;
            Console.WriteLine($"Cel mai mare multiplu comun al numerelor {cl1} si {cl2} este {cmmmc}");
        }

        /// <summary>
        /// Se ordoneaza 3 numere crescator
        /// </summary>
        private static void TreiNrCrescator()
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            c=int.Parse(Console.ReadLine());
            if(a>b && b > c)
            {
                Console.WriteLine($"{c} {b} {a}");
            }
            if(a>c && b > a)
            {
                Console.WriteLine($"{c} {a} {b}");
            }
            if(b>c && c > a)
            {
                Console.WriteLine($"{a} {c} {b}");
            }
            if (a > b && a > c && b<c)
            {

                Console.WriteLine($"{b} {c} {a}");
            }
        }

        /// <summary>
        /// Se determina daca un numar este palindrom
        /// </summary>
        private static void Palindrom()
        {
            int nr, pal = 0;
            Console.WriteLine("Introduceti un numar de doua sau mai multe cifre");
            nr=int.Parse(Console.ReadLine());
            int clone = nr;
            while (clone > 0)
            {
                pal = pal * 10 + clone % 10;
                clone /= 10;
            }
            if (nr == pal)
            {
                Console.WriteLine($"Numarul {nr} este palindrom");
            }
            else
            {
                Console.WriteLine($"Numarul {nr} nu este palindrom");
            }
        }

        /// <summary>
        /// Se determina numarul de ani bisecti dintr-un interval dat
        /// </summary>
        private static void NrAniBisecti()
        {
            int year1, year2,count=0;
            Console.WriteLine("Introduceti 2 ani respectand conditia ca an1<an2");
            year1 = int.Parse(Console.ReadLine());
            year2 =  int.Parse(Console.ReadLine());
            for(int i = year1; i <= year2; i++)
            {
                if (i % 4 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Numarul de ani bisecti intre {year1} si {year2} este de {count}");
        }

        /// <summary>
        /// Se afiseaza cifrele unui numar dat in ordine inversa
        /// </summary>
        private static void CifreInverse()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                Console.Write($"{n % 10} ");
                n /= 10;
            }
        }

        /// <summary>
        /// Se determina daca un numar este sau nu prim
        /// </summary>
        private static void NrPrim()
        {
            int n,ok=1;
            n=int.Parse(Console.ReadLine());
            if (n < 2)
            {
                ok=0;
            }
            else if(n%2==0 && n != 2)
            {

                ok=0;
            }
            for(int d = 3; d * d <= n; d += 2)
            {
                if (n % d == 0)
                {
                    ok = 0;
                    break;
                }
            }
            if (ok > 0)
            {
                Console.WriteLine($"Numarul {n} este prim");
            }
            else
            {
                Console.WriteLine($"Numarul {n} nu este prim");
            }
        }

        /// <summary>
        /// Se afiseaza toti divizorii unui nr dat
        /// </summary>
        private static void DivizoriN()
        {
            int n;
            Console.WriteLine("Introduceti un numar natural");
            n=int.Parse(Console.ReadLine());
            for (int d = 1; d <= n; d++)
            {
                if (n % d == 0)
                {
                    Console.Write($"{d} ");
                }
            }
        }

        private static void Swap2()
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b=  int.Parse(Console.ReadLine());
            Console.WriteLine($"Valorile neschimbate sunt {a}, respectiv {b}");
            a += b;
            b = a - b;
            a -= b;
            Console.WriteLine($"Valorile interschimbate sunt {a}, respectiv {b}");
        }

        /// <summary>
        /// Se interschimba valorile a 2 numere(Cu varialbila auxiliara)
        /// </summary>
        private static void Swap1()
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Valorile neschimbate sunt {a}, respectiv {b}");
            int aux;
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine($"Valorile interschimbate sunt {a}, respectiv {b}");
        }
        /// <summary>
        /// Se determina daca 3 valori date pot fi laturile unui triunghi
        /// </summary>

        private static void LaturiTriunghi()
        {
            int l1, l2, l3;
            l1 = int.Parse(Console.ReadLine());
            l2 = int.Parse(Console.ReadLine());
            l3 = int.Parse(Console.ReadLine());
            if (l1 < l2 + l3 && l2 < l3 + l1 && l3 < l1 + l2)
            {
                Console.WriteLine($"Numerele {l1}, {l2}, {l3} pot fi laturile unui triunghi");
            }
            else
            {
                Console.WriteLine($"Numerele {l1}, {l2}, {l3} nu pot fi laturile unui triunghi");
            }
        }

        /// <summary>
        /// Se determina ultima cifra a unui numar de pe pozitia k
        /// </summary>
        private static void UltimaKCifra()
        {
            int nr, k;
            nr = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            int clone = k;
            while (nr > 0 && k > 1)
            {
                nr /= 10;
                k--;
            }
            if (nr == 0 && k > 1)
            {
                Console.WriteLine("Numarul 'k' dat este mai mare decat numarul de cifre al lui n");
            }
            else
            {
                Console.WriteLine($"Cifra de pe pozitia {clone} este {nr % 10}");
            }
        }

        /// <summary>
        /// Se afiseaza daca un an dat este bisect
        /// </summary>
        private static void AnBisect()
        {
            int year;
            year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("Anul este bisect");
            }
            else
            {
                Console.WriteLine("Anul nu este bisect");
            }
        }

        /// <summary>
        /// Se verifica daca un numar dat 'n' este divizibil cu al numar dat 'k'
        /// </summary>
        private static void DivizibilK()
        {
            int n, k;
            Console.WriteLine("Introduceti un numar natural 'n', respectiv 'k'");
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            if (n % k == 0)
            {
                Console.WriteLine($"Numarul {n} este divizibil cu {k}");
            }
            else
            {
                Console.WriteLine($"Numarul {n} nu este divizibil cu {k}");
            }
        }

        /// <summary>
        /// Se rezolva o ecuatie de gradul 2
        /// </summary>
        private static void EcGr2()
        {
            int a, b, c, delt;
            float sol1, sol2;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            delt = b * b - c * a * 4;
            if (delt > 0)
            {
                sol1 = (float)((-b + Math.Sqrt(delt)) / (a * 2));
                sol2 = (float)((-b - Math.Sqrt(delt)) / (a * 2));
                Console.WriteLine($"Solutia 1: {sol1} \nSolutia 2: {sol2}");
            }
            else if (delt == 0)
            {
                sol1 = (float)(-b / (a * 2));
                Console.WriteLine($"Solutia este: {sol1}");
            }
            else
            {
                Console.WriteLine("Ecuatia nu are solutii");
            }

        }

        /// <summary>
        /// Se rezolva o ecuatie de gradul 1
        /// </summary>
        private static void EcGr1()
        {
            int a, b;
            float sol;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            sol = -b / a * 2;
            Console.WriteLine(sol);
        }
    }
}
    
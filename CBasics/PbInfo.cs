using System;
using System.Collections.Generic;
using System.Text;

namespace CBasics
{
    class PbInfo
    {  
        /*Se citește numărul natural n. Să se afișeze următoarea piramidă de numere:

            1
            1 2
            1 2 3
             .......
            1 2 3 ... n*/
        public static void Piramida351(int nr)
        {
            int n = 4;
           
            for (int i = 1; i <= n; i++)
            {
              
                for (int j = 1; j <= i; j++)
                    Console.Write(j + " ");
                Console.WriteLine();
            }

        }

        /*  i=1   |     i<=n      |  j = 1   |      j<= i  
         *  T            T            T              T
            -            T            -               T 1
                         T  2+ " "
            i     |     j       |
            1     |     1       |   1 + " "
            1           2       
            2           1           1 + " "
            2           2           2 + " "
            
        */             
        /*     Se dă un număr natural n. Afișați pe o linie primele n numere naturale nenule în ordine crescătoare,
        *      iar pe linia următoare aceleași numere, dar în ordine descrescătoare.
               Exemplu pt 5: 1 2 3 4 5 
                             5 4 3 2 1 */
        public static void AfisareNumere3231(int nr)
        {
            int n = 5;
           
            
            for (int i = 1; i <= n; i++)
            {
               
                 Console.Write(i + " ");
                
            }
            Console.Write("\n");    
            for (int i = n; i >= 1; i--)
            {
                Console.Write(i +" ");
            }
        }


        /*Se citește un număr natural n. Să se afișeze o figură similară cu cea din exemplu.
         3

        Ieșire

        1
        22
        22
        333
        333
        333

        Explicație

       Cifra 1 s-a afisat o singura data, pe un singur rand. Cifra 2 s-a afista de 2 ori, pe 2 randuri. Cifra 3 s-a afisat de 3 ori, pe 3 randuri.*/

        public static void ScaraNumerelor1569(int nr)
        {
            for (int i = 1; i <= nr; i++)
            {
                for (int j = 1; j <= nr; j++)
                {
                   
                }
            }
            
          
        }

        /*Se dă n. Să se afișeze 10n.
        Date de intrare

        Programul citește de la tastatură numărul n.
        Date de ieșire

        Programul va afișa pe ecran numărul P, reprezentând 10n.
        Intrare 5
        Iesire 100000*/
        public static void p1362(int n)
        {
            Console.Write(1);
            for (int i = 1; i <= n; i++)
            {
                Console.Write(0);
              
            }
          
        }

        /*Se dă un număr natural n. Afișați în ordine descrescătoare numerele naturale impare mai mici sau egale cu n.
         Programul afișează pe ecran în ordine descrescătoare numerele naturale impare mai mici sau egale cu n, separate prin exact un spațiu.
         Input 10 Output 9 7 5 3 1  */

        public static void AfisareNrImpare3233(int n)
        {
            if (n % 2 == 0)
                n--;
            for (int i = n ; i >= 1; i -= 2)
            {
                Console.Write(i + " ");
            }


        }

        /*Sa se afiseze numerele din interval care au 7 la sfarsit*/
        public static void Afisare7Sfarsit(int n)
        {
            for (int i = 7; i <= n; i += 10)
            {
                    Console.Write(i + " ");
            }
        }

        /*Se dau două numere naturale nenule n și p. Afișați în ordine crescătoare puterile lui n mai mici sau egale cu p.
         * Programul citește de la tastatură numerele n și p.
         Programul afișează pe ecran, în ordine crescătoare, puterile lui n mai mici sau egale cu p, separate prin câte un spațiu.
        Input  3 100
        Output 1 3 9 27 81*/

        public static void AfisarePuteri348(int puterea, int numarul)
        {
            for (int puterileNumarului = 1; puterileNumarului <= numarul; puterileNumarului *= puterea)
            {
                Console.Write(puterileNumarului + " ");
            }
        }

        public static void CatePareN1261()
   
        {
            int k = 0;
            int numarDeCitit;
            Console.Write("Insert a number to check " );

            numarDeCitit = int.Parse(Console.ReadLine());

            while(numarDeCitit != 0)
            {
                if (numarDeCitit % 2 == 0)
                    k++;
                Console.Write("Insert the next number to check ");
                numarDeCitit = int.Parse(Console.ReadLine());

            }
            if (k == 0)
            {
                Console.Write("NU EXISTA");
            }
            else//if (k!=0)
            {
                Console.Write("The total nr. of even numbers = " + k);
            }
            

        }

        public static void AfisareNumere327(int nr)
        {
         
            for (int i = 1; i <= nr; i++)
            {
                Console.Write(i + " ");
                
            }
            Console.WriteLine();
            for (int i = nr; i>=1; i--)
            {
                Console.Write(i+ " ");
            }
        }

        public static void AfisarePare3232(int nr)
        {
            for(int i=2; i<=nr; i += 2)
            {
                Console.Write(i +" ");
            }
        }

        //afisare primele nr impare pana la n
        public static void AfisareImpare331(int nr)
        {
            for(int i=2*nr-1; i>=1; i--)
                if(i%2==1)
                    Console.Write(i + " ");
        }

        public static void AfisareImpare3231Modificata(int nr)
        {
            if (nr % 2 == 0)//nr de la care plec e par, nu trebuie scris
                nr--;//scadem
            for(int i =nr; i>=1; i-=2)
                Console.Write(i+ " ");

        }
        public static void AfisareImpare3231Test(int nr)
        {
            for (int i = nr; i >= 1; i--)
            if (i % 2 == 1)
            Console.Write(i+" ");
        }
        public static void p10V2(int nr)
        {
            int numarulBaza = 10;
            for (int puterea = 0; puterea <=nr; puterea++)
            {
                Console.WriteLine($"{numarulBaza}^{puterea}= { (long)Math.Pow(numarulBaza, puterea):N0}");

            }
        }

        public static void p10V3(int nr, int numarulBaza)
        {
            
            int numarFinal = 1;
            for (int i = 1; i <=nr ; i++)
            {
                numarFinal = numarFinal * numarulBaza;

            }
            Console.Write(numarFinal);
        }


        public static float InversatulUnuiNr(int nr)
        {
            float n;
            n = 1.0f / (float)nr;
            return(n);
        }


        public static void MediaArmonica2949(int n)
        {
            //Media armonica se calculeaza: 
            //Nr. de numere pe care le am in sir/suma Inverselor numerelor din sir
          
            int numereDeCitit;
            float suma = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Insert a number to check ");
                numereDeCitit = int.Parse(Console.ReadLine());
                float invers = InversatulUnuiNr(numereDeCitit);
                suma += invers;
            }
            float medieArmonica = n / suma*100;
            medieArmonica = (int) medieArmonica / 100.0f;
            //Console.WriteLine(medieArmonica);
            Console.Write(String.Format("{0:0.00}", medieArmonica));
        }//2.189*100 = 218.9 => 218/100 =>2.18

        //Input 3, 100.
        //Output 1, 3, 9, 27, 81 => Puterile lui 3 mai mici ca 100
        //Cand nu stim nr. de repetitii, se foloseste while
        public  static void PuterileLuiN348(int n, int nrDeVerificat)
        {
            int puterea = 1;
            while (puterea <= nrDeVerificat)
            {
                Console.Write(puterea + " ");             //3^2 = 3^1 * 3; 3^3 = 3^2 * 3; 3^0 = 1; 3^1 = 3^0 *3
                puterea = puterea * n;
            }
        }
         
        // TODO: Afisarea nu e ordonata. 
        public static void PatratPerfect2572(int numarulDeNumere)
        {
            int numereDeVerificat;
            for (int i = 0; i < numarulDeNumere; i++)
            {

                Console.Write("Insert a number to check ");
                numereDeVerificat = int.Parse(Console.ReadLine());
 
                if(Math.Sqrt(numereDeVerificat)  == (int)Math.Sqrt(numereDeVerificat))
                {
                    Console.WriteLine("DA ");
                }
                else Console.WriteLine("NU ");
            }

        }

        //Input: 5 produse cu preturile: 30,6 ; 12,4; 13,9; 10; 20,6
        //Output: suma totala a preturilor dupa aplicarea TVA-ului pe fiecare produs.
       
        public static void ExercitiuTVA(int nrDeProduse)
        {
            double pret;
            double suma = 0;

            for (int i = 1; i <= nrDeProduse; i++)
            {
                Console.Write("Introduceti pretul ");
                pret = double.Parse(Console.ReadLine());
                double tva4916 = pret *(19.0f/100);
                double tva4914 = pret *(16.0f/100);
                double tva4912 = pret *(9.0f/100);
                if (pret >= 100)
                    pret = tva4916 + pret;
                else if (pret >= 50)
                    pret = tva4914 + pret;
                else
                    pret = tva4912 + pret;

                suma += pret;
                Console.Write(String.Format("{0:0.00}",pret )+ " Pret cu tva.. dupa fiecare produs ");
                Console.WriteLine();
                //  Console.Write(String.Format("{0:0.00}", medieArmonica));

            }
            Console.Write(suma + " Suma finala ");
            Console.WriteLine();
            

        }

        public static void Patrat457(int numarul, char caracter1, char caracter2)
        {
            for (int j = 0; j < numarul; j++)
            {
                Console.Write(caracter1);

            }
            Console.WriteLine();
            for (int i = 1; i < numarul-1; i++)
            {
                for (int j = 0; j < numarul; j++)
                {
                    if (j == 0 || j == numarul - 1) Console.Write(caracter1);
                    else
                        Console.Write(caracter2);
                }
                Console.WriteLine();
            }
            for (int j = 0; j < numarul; j++)
            { 
                Console.Write(caracter1);
            }
        }

        public static void PuterileLuiN2699(int numarul, int numarulDeVerificat)
        {
            int puterea = 1;
            while(puterea <= numarulDeVerificat)
            {
                Console.Write(puterea+" ");
                puterea *= numarul;
            }

        }

        public static void SumaN2(int nrCifre)
        {
            int suma = 0;
            int numarulDeLaTastatura;
            for (int i = 0; i < nrCifre; i++)
            {
                Console.Write("Insert a number to be added ");
                numarulDeLaTastatura = int.Parse(Console.ReadLine());
                suma += numarulDeLaTastatura;            
            }
            Console.Write("Suma este: " + suma );
        }

        public static void Suma51()
        {
            int suma = 0;
            int numarulDeLaTastatura;
            Console.Write("Introduceti primul numar ");
            numarulDeLaTastatura = int.Parse(Console.ReadLine());
            while (numarulDeLaTastatura != 0)
            {
                suma += numarulDeLaTastatura;
                Console.Write("Introduceti un numar ");
                numarulDeLaTastatura = int.Parse(Console.ReadLine());
            }
            Console.Write(suma);

        }

        public static void Suma459()
        {
            int suma = 0;
            int primulNr;
            int alDoileaNr;
            Console.Write("Introduceti primul numar ");
            primulNr = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al doilea ");
            alDoileaNr = int.Parse(Console.ReadLine());
            suma += primulNr;
            while(primulNr != alDoileaNr)
            {
                primulNr = alDoileaNr;
                suma += alDoileaNr;
                Console.Write("Introduceti un nr de adunat ");
                alDoileaNr = int.Parse(Console.ReadLine());
            }
            suma += alDoileaNr;
            Console.Write("Suma este " + suma);
        }

        public static void PrintElements(int [] number)
        {
            Console.WriteLine("Values ");
            for (int i = 0; i < number.Length; i++)
                Console.Write(number[i] + " ");
        }
        public static void Ordonare509(int [] nr)
        {
            int flagIsOrdered = 0;
            do
            {
                flagIsOrdered = 0;
                for (int i = 0; i < nr.Length - 1; i++)
                {
                    if (nr[i] > nr[i + 1])
                    {
                        int aux = nr[i];//90
                        nr[i] = nr[i + 1];//50
                        nr[i + 1] = aux;
                        flagIsOrdered = 1;
                    }

                }
            } while (flagIsOrdered == 1);
            PrintElements(nr);
           
        }
        
    } 
}

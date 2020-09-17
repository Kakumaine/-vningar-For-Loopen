using System;

namespace Övningar_For_Loopen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriv ett program som loopar igenom numren 1-10 och skriver
            //ut dem på skärmen.

            int[] nummer = new int[10];
            nummer[0] = 1;
            nummer[1] = 2;
            nummer[2] = 3;
            nummer[3] = 4;
            nummer[4] = 5;
            nummer[5] = 6;
            nummer[6] = 7;
            nummer[7] = 8;
            nummer[8] = 9;
            nummer[9] = 10;

            for (int i = 0; i < nummer.Length; i++)
            {
                Console.WriteLine(nummer[i]);
            }

            // Skriv ett program som räknar baklänges från 40-30 och skriver
            // ut det på skärmen.

            int[] numberTwo = new int[11];
            numberTwo[0] = 40;
            numberTwo[1] = 39;
            numberTwo[2] = 38;
            numberTwo[3] = 37;
            numberTwo[4] = 36;
            numberTwo[5] = 35;
            numberTwo[6] = 34;
            numberTwo[7] = 33;
            numberTwo[8] = 32;
            numberTwo[9] = 31;
            numberTwo[10] = 30;

            for (int i = 0; i < numberTwo.Length; i++)
            {
                Console.WriteLine(numberTwo[i]);
            }

            // Skriv ett program som ber användaren att mata in två tal. Efter
            // det räknas den ut summan av alla de tal som är mellan de
            // inmatade talen. Om jag tex matar in 3 & 5 får jag svaret 12
            // (3+4+5=12).



            Console.WriteLine("Mata in första talet: ");
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mata in andra talet: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            //???

            int resultat = input + input2;

            // Skriv en for-loop i en for-loop som ritar ut en tabell med x antal
            // kolumner och y antal rader.

            string[] rowX = new string[10];
            rowX[0] = "Kolumner ";
            rowX[1] = "Kolumner ";
            rowX[2] = "Kolumner ";
            rowX[3] = "Kolumner ";
            rowX[4] = "Kolumner ";
            rowX[5] = "Kolumner ";
            rowX[6] = "Kolumner ";
            rowX[7] = "Kolumner ";
            rowX[8] = "Kolumner ";
            rowX[9] = "Kolumner ";

            string[] rowY = new string[10];
            rowY[0] = "Rader ";
            rowY[1] = "Rader ";
            rowY[2] = "Rader ";
            rowY[3] = "Rader ";
            rowY[4] = "Rader ";
            rowY[5] = "Rader ";
            rowY[6] = "Rader ";
            rowY[7] = "Rader ";
            rowY[8] = "Rader ";
            rowY[9] = "Rader ";

            for (int i = 0; i < rowX.Length; i++)
            {
                for (int x = 0; x < rowY.Length; x++)
                {
                    Console.Write(rowY[x]);
                }
                Console.WriteLine(rowX[i]);
            }
        }
    }
}

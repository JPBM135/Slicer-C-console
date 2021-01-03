using System;

namespace Slicer
{
    class Program
    {
        static void Main(string[] args)
        {
            //(User:) User interactive int/string
            //(Sys:) Used only by the program, generaly deppends on (User:) int/string
            
            string Frase; //User: Where the frase is beeing stored
            string Slice; //Sys: Where the slices are beeing stored, reset after every loop

            int TamSlice; //User: The lenght of the slice
            int EspSlice; //User: The space between every slice
            int TamFrase; //Sys: Lenght of the "Frase" in characters
            
            //Colects the "Frase"
            Console.WriteLine("Word or Frase:");
            Frase = Console.ReadLine();

            //Colects the "TamSlice"
            Console.WriteLine("Lenght of each slices (Numbers Only): ");
            TamSlice = int.Parse(Console.ReadLine());

            //Colects the "EspSlice"
            Console.WriteLine("Lenght between each slice (Numbers Only): ");
            EspSlice = int.Parse(Console.ReadLine());

            //Defines "TamFrase" as the "Frase" lenght
            TamFrase = Frase.Length;

            //Jump 3 lines just for aesthetic
            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine();

            //Creates a loop
            //If "i" is lower than "TamFrase" continues the loop
            //Adds "EspSlice" to "i"
            for (int i = 0;i < TamFrase; i += EspSlice)
            {
                //Defines "Slice" as a substring, using "i" as spaceIndex and "TamSlice" as Lenght
                Slice = Frase.Substring(i, TamSlice);

                //Prints the result, "i" is divided by "EspSlice" beacuse of "i" += "EspSlice"
                Console.WriteLine("Slice {0}: {1}", i / EspSlice, Slice);

                //Frase: output1output2output3
                //TamSlice = 7
                //EspSlice = 7
                //Output:
                //Slice 0: output1
                //Slice 1: output2
                //Slice 2: output3
            }

        }
    }
}

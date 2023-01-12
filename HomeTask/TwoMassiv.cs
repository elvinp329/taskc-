using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    internal class TwoMassiv
    {
        internal int[,] EnterArray()
        {
            Console.WriteLine("Setirlerin en boyuyu");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Sutunlarin en boyuyunu");
            int n = int.Parse(Console.ReadLine()) ;
            Console.WriteLine("Massivin uzunlugunu daxil edin : ");
            int[,] mass = new int[n, m];



            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.WriteLine($"mass[{i}],[{j}]=");
                    mass[i,j] = int.Parse(Console.ReadLine());  
             
                }

                
            }

            return mass; 

        }
        internal void Print(int[,] mass)
        {

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for(int j=0; j<mass.GetLength(1); j++)
                {

                }  
            }




        }
    }
}

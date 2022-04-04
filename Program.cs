using Basicos;
using System;
namespace exercises
{
     class Program
    {
        
        static void Main(string[] args)
        {                   
            OperacionesBasicas Op=new OperacionesBasicas();               
            
            System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            System.Console.WriteLine(Op.ElNumeroMayor(1,2,3));
            System.Console.WriteLine(Op.ElNumeroMayor(1,3,2));
            System.Console.WriteLine(Op.ElNumeroMayor(56,57,58));
            System.Console.WriteLine(Op.ElNumeroMayor(1,2,2));
            System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            System.Console.WriteLine(Op.MasCercaDe100(78,95));
            System.Console.WriteLine(Op.MasCercaDe100(95,95));
            System.Console.WriteLine(Op.MasCercaDe100(99,70));

            System.Console.WriteLine(Op.EntreDosRangos(78,95));
            System.Console.WriteLine(Op.EntreDosRangos(25,35));
            System.Console.WriteLine(Op.EntreDosRangos(40,50));
            System.Console.WriteLine(Op.EntreDosRangos(55,60));

            System.Console.WriteLine();
            System.Console.WriteLine(Op.EntreUnRango(78,95));
            System.Console.WriteLine(Op.EntreUnRango(20,30));
            System.Console.WriteLine(Op.EntreUnRango(21,25));
            System.Console.WriteLine(Op.EntreUnRango(28,28));

            System.Console.WriteLine();
            System.Console.WriteLine(Op.CuatroZetas("frizz"));
            System.Console.WriteLine(Op.CuatroZetas("zane"));
            System.Console.WriteLine(Op.CuatroZetas("Zazz"));
            System.Console.WriteLine(Op.CuatroZetas("false"));
            System.Console.WriteLine(Op.CuatroZetas("zzzz"));
            System.Console.WriteLine(Op.CuatroZetas("ZZZZ"));
        
            System.Console.WriteLine();
            System.Console.WriteLine(Op.UltimoDigitoIgual(123,146));        
            System.Console.WriteLine(Op.UltimoDigitoIgual(12,512));        
            System.Console.WriteLine(Op.UltimoDigitoIgual(7,87));        
            System.Console.WriteLine(Op.UltimoDigitoIgual(12,45));    

            System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            System.Console.WriteLine(Op.LastThreeToUpper("javascript"));    
            System.Console.WriteLine(Op.LastThreeToUpper("python"));    
            System.Console.WriteLine(Op.LastThreeToUpper("js"));    
            System.Console.WriteLine(Op.LastThreeToUpper("PHP"));    

        }   




       
    }
}
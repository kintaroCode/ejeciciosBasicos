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

           Console.WriteLine(Op.CopiarNVeces("JS",2));
           Console.WriteLine(Op.CopiarNVeces("JS",3));
           Console.WriteLine(Op.CopiarNVeces("JS",1));
                
            Console.WriteLine();

            System.Console.WriteLine(Op.CopiaDeTresCaracteres("Python", 2));
            System.Console.WriteLine(Op.CopiaDeTresCaracteres("Python", 3));
            System.Console.WriteLine(Op.CopiaDeTresCaracteres("JS", 3));
            System.Console.WriteLine();
            System.Console.WriteLine(Op.DobleAA("bbaaccaag"));
            System.Console.WriteLine(Op.DobleAA("jjkiaaaseaaw"));
            System.Console.WriteLine(Op.DobleAA("JSaaakoiaa"));
        }   




       
    }
}
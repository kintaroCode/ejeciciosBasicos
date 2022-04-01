using Basicos;
using System;
namespace exercises
{
     class Program
    {
        static void Main(string[] args)
        {
            OperacionesBasicas Op=new OperacionesBasicas();
            Console.WriteLine(Op.suma(6,6));
            System.Console.WriteLine(Op.DiferenciaAmboluta(53));
            System.Console.WriteLine(Op.DiferenciaAmboluta(30));
            System.Console.WriteLine(Op.DiferenciaAmboluta(51));
            
            System.Console.WriteLine(Op.EsTreinta(30,0));
            System.Console.WriteLine(Op.EsTreinta(25,5));
            System.Console.WriteLine(Op.EsTreinta(20,30));
            System.Console.WriteLine(Op.EsTreinta(25,20));

            System.Console.WriteLine(Op.AgregarIf("if else"));
            System.Console.WriteLine(Op.AgregarIf("else"));
            System.Console.WriteLine(Op.AgregarIf("arroz"));
            System.Console.WriteLine(Op.AgregarIf("ifigenia"));


            System.Console.WriteLine(Op.RemoverCaracter("python",1));
            System.Console.WriteLine(Op.RemoverCaracter("python",0));
            System.Console.WriteLine(Op.RemoverCaracter("python",4));

            System.Console.WriteLine(Op.CambiarPrimeraYUltimaLetra("arroz"));

        }   




       
    }
}
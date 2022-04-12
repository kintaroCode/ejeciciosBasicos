using Basicos;
using System;
using UsoDirectory;
namespace exercises
{
     class Program
    {
        
        static void Main(string[] args)
        {                   
            OperacionesBasicas Op=new OperacionesBasicas();               
            UsodeDirec direc= new UsodeDirec();

            System.Console.WriteLine(Op.LetraSiLetraNo("Python"));
            System.Console.WriteLine(Op.LetraSiLetraNo("PHP"));
            System.Console.WriteLine(Op.LetraSiLetraNo("JS"));
            System.Console.WriteLine();
            System.Console.WriteLine(Op.Aleatoria("abcd"));
            System.Console.WriteLine(Op.Aleatoria("aec"));
            System.Console.WriteLine(Op.Aleatoria("isrrael"));
            System.Console.WriteLine();
            System.Console.WriteLine(Op.WordWithLetters("javascript"));
            System.Console.WriteLine(Op.WordWithLetters("Python"));
            System.Console.WriteLine(Op.WordWithLetters("html"));

            

        }   




       
    }
}
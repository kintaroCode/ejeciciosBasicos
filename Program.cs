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
            

           
            System.Console.WriteLine(Op.TripleCaraters(new int[]{1,1,2,2,1}));
            System.Console.WriteLine(Op.TripleCaraters(new int[]{1,1,2,1,3}));
            System.Console.WriteLine(Op.TripleCaraters(new int[]{1,1,1,2,2,2,1}));

            System.Console.WriteLine();
            System.Console.WriteLine(Op.ReturnThirty(2,17));
            System.Console.WriteLine(Op.ReturnThirty(17,12));
            System.Console.WriteLine(Op.ReturnThirty(22,17));
            System.Console.WriteLine(Op.ReturnThirty(20,0));
            System.Console.WriteLine();
            System.Console.WriteLine(Op.ReturnNumbersFive(1,4));
            System.Console.WriteLine(Op.ReturnNumbersFive(4,5));
            System.Console.WriteLine(Op.ReturnNumbersFive(3,4));
            System.Console.WriteLine();
            System.Console.WriteLine(Op.ReturnMultipleThirteen(13));
            System.Console.WriteLine(Op.ReturnMultipleThirteen(14));
            System.Console.WriteLine(Op.ReturnMultipleThirteen(27));
            System.Console.WriteLine(Op.ReturnMultipleThirteen(41));


        }   




       
    }
}
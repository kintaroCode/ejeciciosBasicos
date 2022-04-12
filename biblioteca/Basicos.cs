namespace Basicos


{
    public class OperacionesBasicas
    {
        
        private List<string> miLista = new List<string>()
            {
                "Andres Pastrana", "juan pedro", "damaso figueredo", "juan esteban", "monica lujan","juanes esteban" 
            };
        //suma dos numeros enteros
        public int suma(int n, int m)
        {
            foreach (var item in miLista)
            {
                System.Console.WriteLine(item);
            }
            return !(n == m )? n+m : (n+m)*3;
        }

        //diferencia absoluta entre dos numeros
        public int DiferenciaAmboluta(int n)
        {
            const int a=51;
            int diferencia=a-n;
            if (n>a)
            {
                return -(diferencia*3);
            }
            return diferencia;
        }

        // ejercico 3

        public bool EsTreinta(int a, int b)
        {
            if (a == 30 || b ==30 || a+b==30)
            {
                return  true;
            }
            return false;

        }

        
        //ejercicio 5
        public string AgregarIf(string s)
        {
            string aux=s.Substring(0,2);           
            return (aux=="if")? s: "if "+s;
        }

        //ejercicio 6

        public string RemoverCaracter(string s, int n)
        {
            string aux = s.Remove(n,1);            
            return aux;
        }

        //ejercicio 7

        public string CambiarPrimeraYUltimaLetra(string s)
        {
            string p=s.Substring(0,1);            
            string u=s.Substring(s.Length-1,1);            
            string aux=s.Remove(0,1);
            string aux2=aux.Remove(s.Length-2,1);
            
            return u+aux2+p;
        }

        //ejercicio 8


        public string CaracteresRepetidos(string s)
        {
            if (s.Length<2)
            {
                return s;
            }
            string aux=s.Substring(0,2);
            return aux+aux+aux+aux;
        }

        //ejercicio 9
        public string UltimoCaracterDosVeces(string s)
        {
            
            string aux=s.Substring(s.Length-1,1);
            return aux+s+aux;
        }

        //ejercicio 10
        public bool MultiploDe3o7(int n)
        {
            if (n%3 == 0 || n%7 == 0)
            {
                return true;
            }
            return false;
        }

        //ejercicio 11

        public string PrimerosTresCaracterTresVeces(string s)
        {  
            string aux;
            if (s.Length<3)
            {
                aux=s.Substring(0,1);
                return aux+s+aux;
            }          
            aux=s.Substring(0,3);
            return aux+s+aux;
        } 

        //Ejercicio 12
        public bool contieneC(string s)
        {
            return s.Contains("C#");
        }


        //ejercicio 13
        public bool Temperaturaentre0y100(int n, int m)
        {
            if ((n >100 || n< 0 ) && (m>100 || m< 0))
            {
                return true;
            }
            return false;
        }

        //ejercicio 14
        public bool Entre100y200(int n, int m)
        {
            if ((n >= 100 && n <= 200 ) || (m >= 100 && m <= 200))
            {
                return true;
            }
            return false;
        }


        //ejercicio 15
        public bool Between20and50(int n, int m, int x)
        {
            if ((n >= 20 && n <= 50 ) || (m >= 20 && m <= 50) || (x>=20 && x<=50))
            {
                return true;
            }
            return false;
        }

        //ejercicio 16
        public bool Between20and50(int n, int m)
        {
            if ((n >= 20 && n <= 50 ) && (m >= 20 && m <= 50) )
            {
                return false;
            }
            if ((n >= 20 && n <= 50 ) || (m >= 20 && m <= 50) )
            {
                return true;
            }
            return false;
        }

        //ejercicio 17

       public string ContainsYT(string s)
        {
            string aux=s.Substring(1,2);
            if (aux=="yt")
            {
                return s.Remove(1,2);
            }            
            return s;
        }

        //ejercicio 18
        public int ElNumeroMayor(int n, int m, int x)
        {
            if (n > m & n > x)
            {
                return n;
            }
            if (m>x)
            {
                return m;
            }
            return x;
        }

        //ejercicio 19

        public int MasCercaDe100(int n,int m)
        {
            int aux=Math.Abs(100-n);
            int aux2=Math.Abs(100-m);
            if (aux>aux2)
            {
                return m;
            }
            if (aux<aux2)
            {
                return n;
            }
            return 0;
        }


        //ejercicio 20

        public bool EntreDosRangos(int n, int m)
        {
            if ((n >= 40 & n <= 50) || (m >= 40 & m <= 50)) 
            {
                return true;       
            }
            if ((n >= 50 & n <= 60) && (m >= 50 & m <= 60))
            {
                return true;
            }
            return false;
        }

        //ejercicio 21
        public int EntreUnRango(int n, int m)
        {
            if ((n >= 20 & n <= 30) && (m >= 20 & m <= 30)) 
            {
                return (n>=m)? n : m;       
            }
           
            return 0;
        }

        //ejercicio 22

        public bool CuatroZetas(string s)
        {
            int aux=0;          
            foreach (var character in s)
            {
                if (character=='z')
                {
                    aux++;
                }
            }
            if (aux>=2)
            {
                return true;
            }
            return false;
        }

        //ejercicio 23
        public bool UltimoDigitoIgual(int n, int m)
        {
            string aux=n.ToString();
            aux=aux.Substring(aux.Length-1,1);
            
            string aux2=m.ToString();
            aux2=aux2.Substring(aux2.Length-1,1);
            
            return (aux==aux2)? true:false;
            
        }

        //Ejercicio 24
        public string LastThreeToUpper(string s)
        {
            string aux, aux2;
            if (s.Length >= 3)
            {
                aux=s.Substring(s.Length-3,3);               
                aux2=s.Remove(s.Length-3,3);
                return aux2+aux.ToUpper();
            }
            return s.ToUpper();
        }

        //Ejercicio 25
        public string CopiarNVeces(string s, int n)
        {
            string aux="";
            for (int i = 0; i < n; i++)
            {
                aux=aux+s;
            }
            return aux;
        }

        //ejercicio 26

        public string CopiaDeTresCaracteres(string s, int n)
        {
            
            string StringResult="";
            if (s.Length<4)
            {
                for (int i = 0; i < n; i++)
                {
                    StringResult=StringResult+s;
                }
                return StringResult;
            }    
            string FirstThreeChar=s.Substring(0,3);
            for (int i = 0; i < n; i++)
            {
                StringResult=StringResult+FirstThreeChar;                
            }
                return StringResult;

        }

        //ejercicio 27
        public int DobleAA(string s)
        {
            int conteo=0;
            string aa="";
            for (int i = 0; i < s.Length-1; i++)
            {
                aa=s.Substring(i,2);               
                if (aa=="aa")
                {
                    conteo++;
                }
            }
            return conteo;
        }

        //ejercicio 28 desde youtube
        public void leerArchivo()
        {
            string FileName;
            String DestFile;
            

            string TargetPath=@"C:\Users\SAP\Desktop\PruebaDirectorio";
            string SourcePath=@"C:\Users\SAP\Desktop\lecturas para el baño";
            if (Directory.Exists(SourcePath))
            {
                string[] Files= System.IO.Directory.GetFiles(SourcePath);
                foreach (var s in Files)
                {
                    System.Console.WriteLine(s);
                    FileName=System.IO.Path.GetFileName(s);
                    DestFile=System.IO.Path.Combine(TargetPath,s);
                    System.IO.File.Copy(s, DestFile, true);
                }     
                
            }else
            {
                System.Console.WriteLine("Source Path does not exist");
            }

            System.Console.WriteLine("press any button to finish");
            System.Console.ReadKey();

            
        }

        //ejercicio 29
        public string LetraSiLetraNo(string s)
        {
            string palabraHecha="";

            for (int i = 0; i < s.Length; i++)
            {
                if ((i+2)%2==0)
                {
                    palabraHecha=palabraHecha+s[i];
                }
            }
            return palabraHecha;
        }

        // ejercicio 30

        public string Aleatoria(string s)
        {
            Random rdm=new Random();
            int indiceAux;
            string PalabraAleatoria="";
            
            for (int i = 0; i < s.Length*2; i++)
            {
                indiceAux= rdm.Next(s.Length);
                PalabraAleatoria=PalabraAleatoria+s[indiceAux];
            }
            return PalabraAleatoria;
        }

        //ejercicio 37

        public string WordWithLetters(string s)
        {
            string newWord="";            

            for (int i = 0; i < s.Length; i = i+4)
            {
                newWord=newWord+s[i]+s[i+1];
            }

            return newWord;

        }

        //ejercicio 38
        public int NumberOfNumbers(int[] a)
        {
            int count=0;
            foreach (var item in a)
            {
                if (item ==5||item==6)
                {
                    count++;
                }
            }
            count =count/2;
            return count;
        }

        //ejercicio 39
        public bool TripleCaraters(int[] a)
        {
            for (int i = 0; i < a.Length-2; i++)
            {
                if (a[i] == a[i+1] && a[i] == a[i+2])
                {
                    return true;
                }
            }

            return false;
        }

        //ejercicio 40
        public int ReturnThirty(int a, int b)
        {
            if (a+b <= 20 && a+b >= 10)
            {
                return 30;
            }

            return a+b;
        }

        //ejercicio 41
        public bool ReturnNumbersFive(int a, int b)
        {
            if (a+b == 5 || b == 5 || a == 5)
            {
                return true;
            }

            return false;
        }

        //ejercicio 42
        public bool ReturnMultipleThirteen(int a)
        {

            if (a % 13 == 0 || (a-1) % 13 == 0)
            {
                return true;
            }

            return false;
        }



    }


}
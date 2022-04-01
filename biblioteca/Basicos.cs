namespace Basicos


{
    public class OperacionesBasicas
    {
        //suma dos numeros enteros
        public int suma(int n, int m)
        {
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

        public bool EsTreinta(int a, int b)
        {
            if (a == 30 || b ==30 || a+b==30)
            {
                return  true;
            }
            return false;

        }


        public string AgregarIf(string s)
        {
            string aux=s.Substring(0,2);           
            return (aux=="if")? s: "if "+s;
        }

        public string RemoverCaracter(string s, int n)
        {
            string aux = s.Remove(n,1);            
            return aux;
        }

        public string CambiarPrimeraYUltimaLetra(string s)
        {
            string p=s.Substring(0,1);
            string u=s.Substring(s.Length-1,1);
            string aux=s.Remove(0,1);
            string aux2=aux.Remove(s.Length-1,1);
            
            return u+aux2+p;
        }




    }


}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prostopadłościan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prostopadloscian i1 = new Prostopadloscian();
            i1.dł=6; i1.sz=8; i1.wy=2; Console.WriteLine(i1.objetosc());
            Prostopadloscian i2=new Prostopadloscian();
            i2.dł=7; i2.sz=3; i2.wy=8; i1.Porobj(i2);
        }
    }
    public class Prostopadloscian
    {
        public float dł {get;set;}
        public float sz {get;set;}
        public float wy {get;set;}
        public float objetosc(){return dł*sz*wy;}
        public void Porobj(Prostopadloscian i)
        {
            if (this.objetosc()>i.objetosc())Console.WriteLine("Pierwszy ma większ obj od drug");
            else if(this.objetosc()<i.objetosc()) Console.WriteLine("Pierwszy ma mniej obj od drug");
            else Console.WriteLine("Oba mają taką samą obj");
        }
    }
}

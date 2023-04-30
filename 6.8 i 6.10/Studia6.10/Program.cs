using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studia6._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KandydatNaStud[] kan = new KandydatNaStud[3];
            kan[0].nazw = "Kot";kan[0].pktMat = 57;kan[0].pktInf = 78;kan[0].pktJO = 66;
            kan[1].nazw = "Ryba";kan[1].pktMat = 77;kan[1].pktInf = 46;kan[1].pktJO = 86;
            kan[2].nazw = "Mak";kan[2].pktMat = 48;kan[2].pktInf = 89;kan[2].pktJO = 91;
            foreach (KandydatNaStud kandydat in kan ){Console.WriteLine("{0}:{1} pkt", kandydat.nazw, kandydat.OblSumPkt());}
            Console.ReadKey();
        }
    }
    struct KandydatNaStud
    {
        public string nazw; public int pktMat, pktInf, pktJO;
        public double OblSumPkt()
        {double sumPkt=0.6*pktMat+0.5*pktInf+0.2*pktJO;return sumPkt;}
    }

}

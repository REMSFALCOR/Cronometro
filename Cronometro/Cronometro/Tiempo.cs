using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cronometro
{
    internal class Tiempo: IHora, IMinuto, ISegundo
    {
        readonly int HorEnSeg = 3600;
        readonly int MinEnSeg = 60;

        /*Calcula cuantoas horas existen*/
        public string hora(int ts)
        {
            int th = 0;
            if (ts > HorEnSeg)
                th = ts / HorEnSeg;
            else
                th = 0;
            if (th < 10)
                return "0" + th.ToString();
            else
                return th.ToString();
        }

        /*Calcula cuantos minutos exsiten*/
        public string minuto(int ts)
        {
            int th=0,tm=0;

            if (ts > HorEnSeg)
                th = ts / HorEnSeg;
            else
                th = 0;
            if (ts >= MinEnSeg)
                tm= (ts - HorEnSeg * th) / 60;
            else
                tm= 0;
            if (tm < 10)
                return "0" + tm.ToString();
            else
                return tm.ToString();
        }

        /*Calcula los segundos que han pasado*/
        public string segundo(int ts)
        {
            int th, tm;
            if (ts > HorEnSeg)
            {
                th = ts / HorEnSeg;
                ts = ts - HorEnSeg * th;
            }
            if (ts >= MinEnSeg)
            {
                tm = ts / MinEnSeg;
                ts = ts - MinEnSeg * tm;
            }

            if (ts < 10)
                return "0" + ts.ToString();
            else
                return ts.ToString();
            //return ts;
        }
    }
}

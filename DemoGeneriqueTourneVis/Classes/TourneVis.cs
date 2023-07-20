using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGeneriqueTourneVis.Classes
{
    internal class TourneVis<T> where T : Vis
    {
        public void Visser(T vis)
        {
            vis.Visser();
        }
    }

    internal class TourneVisAEmbouts
    {
        public void Visser<T>(T vis) where T : Vis
        {
            vis.Visser();
        }
    }
}

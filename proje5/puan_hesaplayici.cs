using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje5
{
    class puan_hesaplayici
    {
        private int puan;

        public int Get_puan()
        {
            return puan;
        }
        public puan_hesaplayici()
        {
            
            
        }
        public void top_yukaridan_cikti() // top yukaridan ciktiysa +10 puan
        {
            puan += 10;
        }

        public void top_asagidan_cikti() // top asagidan ciktiysa -20 puan
        {
            puan += -20;
        }
        public void top_oyuncuya_carpti() 
        {
            puan += 1;
        }
    }
}

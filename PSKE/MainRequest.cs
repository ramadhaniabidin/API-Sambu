using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSKE
{
    public class MainRequest
    {
        public void NotaTimbangKopra()
        {
            string endPoint = "https://apiku.sambu.co.id/isea/eksternal/notatimbang-kopra/11/2023";
            HttpClient client = new HttpClient();
        }
    }
}

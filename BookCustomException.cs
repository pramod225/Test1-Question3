using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tesx3
{
    public class BookCustomException :Exception
    {
      public   string Massage;
         public BookCustomException(string Massage)
        {
            this.Massage = Massage;
        }
    }
}

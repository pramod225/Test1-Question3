using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tesx3
{
    public class BookCustomException :Exception
    {
      public   string massage;
         public BookCustomException(string massage)
        {
            this.massage = massage;
        }
    }
}

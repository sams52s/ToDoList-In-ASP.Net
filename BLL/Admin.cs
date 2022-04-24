using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Admin : IAdmin
    {
        public int GetTotalContact()
        {
            return 10;
        }
    }
}

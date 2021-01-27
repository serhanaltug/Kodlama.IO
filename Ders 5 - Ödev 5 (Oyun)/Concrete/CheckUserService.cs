using Ders_5_Odev_5.Abstract;
using Ders_5_Odev_5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_5_Odev_5.Concrete
{
    class CheckUserService : ICheckUserService
    {
        public bool CheckUser(Player player)
        {
            if (player.Firstname.Length == 0 || player.Lastname.Length == 0) return false;
            return true;
        }
    }
}

using Ders_5_Odev_5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_5_Odev_5.Abstract
{
    public interface ICheckUserService
    {
        bool CheckUser(Player player);
    }
}

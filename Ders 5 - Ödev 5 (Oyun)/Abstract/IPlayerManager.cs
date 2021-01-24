using Ders_5_Odev_5.Entities;

namespace Ders_5_Odev_5.Abstract
{
    public interface IPlayerManager
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
}

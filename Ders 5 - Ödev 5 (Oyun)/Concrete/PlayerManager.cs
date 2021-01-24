using Ders_5_Odev_5.Abstract;
using Ders_5_Odev_5.Entities;
using System;

namespace Ders_5_Odev_5.Concrete
{
    public class PlayerManager : IPlayerManager
    {
        private ICheckUserService _checkUserService;

        public PlayerManager(ICheckUserService checkUserService)
        {
            _checkUserService = checkUserService;
        }

        public void Add(Player player)
        {
            if (_checkUserService.CheckUser(player))
            {
                Console.WriteLine(player.Firstname + " " + player.Lastname + " added.");
            }
            else
            {
                throw new Exception(player.Firstname + " " + player.Lastname + " is not a valid person.");
            }

        }

        public void Delete(Player player)
        {
            Console.WriteLine(player.Firstname + " " + player.Lastname + " deleted.");
        }

        public void Update(Player player)
        {
            Console.WriteLine(player.Firstname + " " + player.Lastname + " updated.");
        }
    }
}

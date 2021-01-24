using Ders_5_Odev_5.Abstract;
using Ders_5_Odev_5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_5_Odev_5.Concrete
{
    public class SalesManager : ISalesManager
    {
        //Buradaki listenin CampaignManager'daki liste ile bir ilgisi yok. İsim benzediği için orada olmalı gibi düşünmeyin.
        //Burada satışa kampanya ekliyoruz.
        List<Campaign> _campaigns;

        public SalesManager()
        {
            _campaigns = new List<Campaign>();
        }

        public void AddCampaign(Campaign campaign)
        {
            _campaigns.Add(campaign);
        }

        public void Buy(Player player)
        {
            foreach (var campaign in _campaigns)
            {
                Console.WriteLine(campaign.CampaignName + " has applied.");
            }

            Console.WriteLine("Thank you for your shopping " + player.Firstname + " " + player.Lastname + ".");
            Console.WriteLine("_____________________________________________________");
        }
    }
}

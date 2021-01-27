using Ders_5_Odev_5.Abstract;
using Ders_5_Odev_5.Adapters;
using Ders_5_Odev_5.Concrete;
using Ders_5_Odev_5.Entities;
using System;

namespace Ders_5_Odev_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player { Id = 1, Firstname = "Serhan", Lastname = "Altuğ", BirthDate = new System.DateTime(1977, 06, 04), NationalIdentity = "27706387112" };
            Player player2 = new Player { Id = 2, Firstname = "Engin", Lastname = "Demiroğ", BirthDate = new System.DateTime(1985, 01, 06), NationalIdentity = "1234567810" };
            Player player3 = new Player { Id = 3, Firstname = "Zeynep", Lastname = "", BirthDate = new System.DateTime(2012, 05, 08), NationalIdentity = "1234567810" };

            IPlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
            playerManager.Add(player1);
            playerManager.Add(player2);
            playerManager.Add(player3);

            player1.NationalIdentity = "12345678910";
            playerManager.Update(player1);

            playerManager.Delete(player2);

            Console.WriteLine("_____________________________________________________");

            Campaign campaign1 = new Campaign { Id = 1, CampaignName = "Campaign 1 - Buy one, get one for free." };
            Campaign campaign2 = new Campaign { Id = 2, CampaignName = "Campaign 2 - Save %20 in your next order." };

            ICampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);

            campaign2.CampaignName = "Campaign 2 (Updated) - Save %25 in your next order.";
            campaignManager.Update(campaign2);
            
            campaignManager.Delete(campaign1);

            Console.WriteLine("_____________________________________________________");

            ISalesManager salesManager = new SalesManager();
            salesManager.Buy(player1);
            //Kampanya 1 silinmişti ancak listeden kontrol etmediğimiz için bir alt satırda satışa ekleyebiliyoruz.
            salesManager.AddCampaign(campaign1);
            salesManager.AddCampaign(campaign2);
            salesManager.Buy(player2);
        }
    }
}

using Ders_5_Odev_5.Abstract;
using Ders_5_Odev_5.Entities;
using System;
using System.Collections.Generic;

namespace Ders_5_Odev_5.Concrete
{
    public class CampaignManager : ICampaignManager
    {
        List<Campaign> _campaigns;

        public CampaignManager()
        {
            _campaigns = new List<Campaign>();
        }

        public void Add(Campaign campaign)
        {
            _campaigns.Add(campaign);
            Console.WriteLine("Campaign " + campaign.Id + " added.");
        }

        public void Delete(Campaign campaign)
        {
            _campaigns.Remove(campaign);
            Console.WriteLine("Campaign " + campaign.Id + " deleted.");
        }

        public void Update(Campaign campaign)
        {
            Campaign campaignToUpdate = _campaigns.Find(x => x.Id == campaign.Id);
            campaignToUpdate.CampaignName = campaign.CampaignName;
            Console.WriteLine("Campaign " + campaign.Id + " updated.");
        }

        public List<Campaign> GetAll()
        {
            return _campaigns;
        }
    }
}

using Ders_5_Odev_5.Entities;
using System.Collections.Generic;

namespace Ders_5_Odev_5.Abstract
{
    public interface ICampaignManager
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
        List<Campaign> GetAll();
    }
}

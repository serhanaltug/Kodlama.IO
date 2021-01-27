using Ders_5_Odev_5.Abstract;
using Ders_5_Odev_5.Entities;
using MernisServiceReference;
using System;

namespace Ders_5_Odev_5.Adapters
{
    public class MernisServiceAdapter : ICheckUserService
    {
        public bool CheckUser(Player player)
        {
            bool returnValue = false;
            try
            {
                KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
                var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.NationalIdentity), player.Firstname.ToUpper(), player.Lastname.ToUpper(), player.BirthDate.Year).Result;
                returnValue = result.Body.TCKimlikNoDogrulaResult;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oyuncu eklenemedi. " + ex.Message);
            }

            return returnValue;
        }

    }
}

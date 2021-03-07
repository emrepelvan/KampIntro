using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using GameProject.Abstract;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1989,
                FirstName = "Emre",
                LastName = "Pelvan",
                IdentityNumber = 22445656420
            });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign 
            { 
                Id = 1, 
                CampaignName = "Mart indirimleri başladı.", 
                CampaignDuration = "01/03/2021", 
                DiscountRate = 50 
            });

            SalesManager salesManager = new SalesManager(new CampaignManager());
            salesManager.CampaignSales(new Sales 
            { 
                Id = 1, 
                GameName = "Counter Strike:GO", 
                Price = 50 
            });
        }
    }
}

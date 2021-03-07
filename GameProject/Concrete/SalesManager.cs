using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class SalesManager : ISalesService
    {
        ISalesService _salesManager;

        public SalesManager(ISalesService salesManager)
        {
            _salesManager = salesManager;
        }

        private CampaignManager campaignManager;
        public SalesManager(CampaignManager campaignManager)
        {
            this.campaignManager = campaignManager;
        }


        public void CampaignSales(Sales sales, Gamer gamer, Campaign campaign)
        {
            _salesManager.CampaignSales(sales, gamer, campaign);
        }

        public void CampaignSales(Sales sales)
        {
            Console.WriteLine("Kampanyalı satış gerçekleştirildi.");
        }
    }
}

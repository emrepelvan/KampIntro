using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;


namespace GameProject.Abstract
{
    interface ISalesService
    {
        void CampaignSales(Sales sales, Gamer gamer, Campaign campaign);
        void CampaignSales(Sales sales);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    class Campaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public string CampaignDuration { get; set; }
        public float DiscountRate { get; set; }

    }
}

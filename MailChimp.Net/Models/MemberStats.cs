using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailChimp.Net.Models
{
    public class MemberStats
    {
        [JsonProperty("avg_open_rate")]
        public decimal AverageOpenRate { get; set; }
        [JsonProperty("avg_click_rate")]
        public decimal AverageClickRate { get; set; }
    }
}

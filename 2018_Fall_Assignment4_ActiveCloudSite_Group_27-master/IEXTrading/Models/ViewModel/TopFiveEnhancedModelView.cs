using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IEXTrading.Models.ViewModel
{
    public class TopFiveEnhancedModelView
    {
        
       public List<GraphData> GraphData { get; set; }
    }

    public class GraphData
    {   [NotMapped]
        public Equity Current { get; set; }
        [Key]
        public string Dates { get; set; }
        public string Prices { get; set; }
        public string Volumes { get; set; }
        public float AvgPrice { get; set; }
        public double AvgVolume { get; set; }

        public GraphData(Equity current, string dates, string prices, string volumes, float avgprice, double avgvolume)
        {

            Current = current;
            Dates = dates;
            Prices = prices;
            Volumes = volumes;
            AvgPrice = avgprice;
            AvgVolume = avgvolume;
        }
    }
}

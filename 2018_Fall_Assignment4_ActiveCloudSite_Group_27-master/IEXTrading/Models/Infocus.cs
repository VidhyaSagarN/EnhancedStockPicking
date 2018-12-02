using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace IEXTrading.Models
{
    public class Infocus
    {
       
        public string symbol { get; set; }
        public string companyName { get; set; }
        public string primaryExchange { get; set; }
        public string sector { get; set; }
        public string calculationPrice { get; set; }
        public string open { get; set; }
        public long openTime { get; set; }
        public float close { get; set; }
        public long closeTime { get; set; }
        public float high { get; set; }
        public double low { get; set; }
        public double latestPrice { get; set; }
        public string latestSource { get; set; }
        public string latestTime { get; set; }
        public long latestUpdate { get; set; }
        public int latestVolume { get; set; }
        public string iexRealtimePrice { get; set; }
        public string iexRealtimeSize { get; set; }
        public string iexLastUpdated { get; set; }
        public double delayedPrice { get; set; }
        public long delayedPriceTime { get; set; }
        public long extendedPrice { get; set; }
        public double extendedChange { get; set; }
        public double extendedChangePercent { get; set; }
        public long extendedPriceTime { get; set; }
        public double previousClose { get; set; }
        public double change { get; set; }
        public double changePercent { get; set; }
        public string iexMarketPercent { get; set; }
        public string iexVolume { get; set; }
        public long avgTotalVolume { get; set; }
        public string iexBidPrice { get; set; }
        public string iexBidSize { get; set; }
        public string iexAskPrice { get; set; }
        public string iexAskSize { get; set; }
        public long marketCap { get; set; }
        public string peRatio { get; set; }
        public float week52High { get; set; }
        public float week52Low { get; set; }
        public double ytdChange { get; set; }
    }
}

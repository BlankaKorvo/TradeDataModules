using System;
using System.Collections.Generic;

namespace MarketDataModules.Candles
{
    //public record CandlesProfileList : CandlesList
    //{
    //    public int CountVolumeProfile { get; }
    //    public List<VolumeProfile> VolumeProfiles { get; }
    //    public CandlesProfileList(string figi, CandleInterval interval, int countVolumeProfile, List<VolumeProfile> volumeProfiles, List<CandleStructure> candles) : base(figi, interval, candles)
    //    {
    //        VolumeProfiles = volumeProfiles;
    //        CountVolumeProfile = countVolumeProfile;
    //    }
    //}
    public class VolumeProfile
    {
        public decimal VolumeGreen { get; set; }
        public decimal VolumeRed { get; set; }
        public int CandlesCount { get; set; }
        public decimal UpperBound { get; }
        public decimal LowerBound { get; }
        public VolumeProfile(decimal volumeGreen, decimal volumeRed, int candlesCount, decimal upperBound, decimal lowerBound)
        {
            VolumeGreen = volumeGreen;
            VolumeRed = volumeRed;
            CandlesCount = candlesCount;
            UpperBound = upperBound;
            LowerBound = lowerBound;
        }
    }
    //public record CandleStructureAvergage : CandleStructure
    //{
    //    public decimal Price { get; }
    //    public CandleStructureAvergage(decimal price, decimal open, decimal close, decimal high, decimal low, decimal volume, DateTime time, CandleInterval interval, string figi) : base(open, close, high, low, volume, time, interval, figi )
    //    {
    //        Price = price;
    //    }

    //}
}

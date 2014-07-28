using System;
using System.Collections.Generic;
using System.Text;

namespace QQWinFarm
{
    public class FarmKey
    {
        public static double NetworkDelay = 0;

        // 获得FarmTime 
        public static string GetFarmTime()
        {
            return Math.Floor((DateTime.Now - new DateTime(1970, 1, 1, 8, 0, 0)).TotalSeconds - NetworkDelay).ToString();
        }

        // 获得FarmKey 
        public static string GetFarmKey(string farmTime)
        {
            return Utils.getMd5Hash2(farmTime + "sdoit78sdopig7w34057".Substring(Convert.ToInt32(farmTime) % 10));
        }
    }
}

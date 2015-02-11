﻿using System;

namespace Vagabond.Things
{
    public static class UnixTimeStamp
    {
        public static DateTime UnixTimeStampToDateTime(this long unixTimeStamp)
        {
            var dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp);
            return dtDateTime;
        }
    }
}

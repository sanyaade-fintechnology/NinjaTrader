﻿using System;
using System.Collections.Generic;
using ExcelLink;

namespace NotifierWebService
{  
   
    public class TradeUpdate
    {
        public static List<xlTradeOrder> Orders = new List<xlTradeOrder>();
        public static List<Boodskap> Messages = new List<Boodskap>();
               
    }

    public class Boodskap
    {
        public DateTime TimeStamp { get; set; }
        public Messages Message { get; set; }
        public string Message_Custom { get; set; }       

        public enum Messages
        {
            isAlive = 0,
            isDead = 1,
            Startup=2,
        }
    }

    public class ManualTrade
    {
        public static bool PositionManuallyClosed { get; set; }
    }
}
﻿using SQLite;

namespace ServiceLib.Models
{
    [Serializable]
    public class ProfileExItem
    {
        [PrimaryKey]
        public string indexId { get; set; }

        public int delay { get; set; }
        public decimal speed { get; set; }
        public int sort { get; set; }
    }
}
﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities.Data.Entities
{
    public partial class SpaceEncounter
    {
        public int ID { get; set; }
        public string Planet { get; set; }
        public int TypeID { get; set; }
        public int Chance { get; set; }
        public int Difficulty { get; set; }
        public int LootTableID { get; set; }

        public virtual LootTable LootTable { get; set; }
    }
}
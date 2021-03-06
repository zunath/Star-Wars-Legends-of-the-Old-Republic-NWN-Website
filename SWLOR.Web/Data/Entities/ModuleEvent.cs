﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities.Data.Entities
{
    public partial class ModuleEvent
    {
        public string ID { get; set; }
        public int ModuleEventTypeID { get; set; }
        public string PlayerID { get; set; }
        public string CDKey { get; set; }
        public string AccountName { get; set; }
        public DateTime DateOfEvent { get; set; }
        public int ClusterID { get; set; }
        public int? BankID { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemTag { get; set; }
        public string ItemResref { get; set; }
        public string PCBaseID { get; set; }
        public string PCBaseStructureID { get; set; }
        public int? BaseStructureID { get; set; }
        public string CustomName { get; set; }
        public string AreaSector { get; set; }
        public string AreaName { get; set; }
        public string AreaTag { get; set; }
        public string AreaResref { get; set; }
        public int? PCBaseTypeID { get; set; }
        public DateTime? DateRentDue { get; set; }
        public string AttackerPlayerID { get; set; }

        public virtual ModuleEventType ModuleEventType { get; set; }
        public virtual Player Player { get; set; }
    }
}
﻿using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class BaseStructure
    {
        public BaseStructure()
        {
            BuildingStyle = new HashSet<BuildingStyle>();
            CraftBlueprint = new HashSet<CraftBlueprint>();
            PCBaseStructure = new HashSet<PCBaseStructure>();
        }

        public int ID { get; set; }
        public int BaseStructureTypeID { get; set; }
        public string Name { get; set; }
        public string PlaceableResref { get; set; }
        public string ItemResref { get; set; }
        public bool IsActive { get; set; }
        public double Power { get; set; }
        public double CPU { get; set; }
        public double Durability { get; set; }
        public int Storage { get; set; }
        public bool HasAtmosphere { get; set; }
        public int ReinforcedStorage { get; set; }
        public bool RequiresBasePower { get; set; }
        public int ResourceStorage { get; set; }
        public int RetrievalRating { get; set; }
        public int FuelRating { get; set; }

        public BaseStructureType BaseStructureType { get; set; }
        public ICollection<BuildingStyle> BuildingStyle { get; set; }
        public ICollection<CraftBlueprint> CraftBlueprint { get; set; }
        public ICollection<PCBaseStructure> PCBaseStructure { get; set; }
    }
}

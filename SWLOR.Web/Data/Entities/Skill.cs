﻿using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Skill
    {
        public Skill()
        {
            CraftBlueprint = new HashSet<CraftBlueprint>();
            PCSkill = new HashSet<PCSkill>();
            PerkLevelSkillRequirement = new HashSet<PerkLevelSkillRequirement>();
        }

        public int ID { get; set; }
        public int SkillCategoryID { get; set; }
        public string Name { get; set; }
        public int MaxRank { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public int Primary { get; set; }
        public int Secondary { get; set; }
        public int Tertiary { get; set; }
        public bool? ContributesToSkillCap { get; set; }

        public virtual Attribute PrimaryAttribute { get; set; }
        public virtual Attribute SecondaryAttribute { get; set; }
        public virtual SkillCategory SkillCategory { get; set; }
        public virtual Attribute TertiaryAttribute { get; set; }
        public virtual ICollection<CraftBlueprint> CraftBlueprint { get; set; }
        public virtual ICollection<PCSkill> PCSkill { get; set; }
        public virtual ICollection<PerkLevelSkillRequirement> PerkLevelSkillRequirement { get; set; }
    }
}
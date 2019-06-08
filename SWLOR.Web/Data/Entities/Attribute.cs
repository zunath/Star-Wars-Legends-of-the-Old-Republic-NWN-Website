﻿using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Attribute
    {
        public Attribute()
        {
            SkillPrimaryNavigation = new HashSet<Skill>();
            SkillSecondaryNavigation = new HashSet<Skill>();
            SkillTertiaryNavigation = new HashSet<Skill>();
        }

        public int ID { get; set; }
        public int NWNValue { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Skill> SkillPrimaryNavigation { get; set; }
        public virtual ICollection<Skill> SkillSecondaryNavigation { get; set; }
        public virtual ICollection<Skill> SkillTertiaryNavigation { get; set; }
    }
}
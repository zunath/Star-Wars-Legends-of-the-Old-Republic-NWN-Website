﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities.Data.Entities
{
    public partial class Spawn
    {
        public Spawn()
        {
            Area = new HashSet<Area>();
            SpawnObject = new HashSet<SpawnObject>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int SpawnObjectTypeID { get; set; }

        public virtual SpawnObjectType SpawnObjectType { get; set; }
        public virtual ICollection<Area> Area { get; set; }
        public virtual ICollection<SpawnObject> SpawnObject { get; set; }
    }
}
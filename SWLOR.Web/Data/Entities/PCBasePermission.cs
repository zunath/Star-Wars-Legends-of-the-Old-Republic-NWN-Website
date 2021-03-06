﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities.Data.Entities
{
    public partial class PCBasePermission
    {
        public string ID { get; set; }
        public string PCBaseID { get; set; }
        public string PlayerID { get; set; }
        public bool CanPlaceEditStructures { get; set; }
        public bool CanAccessStructureInventory { get; set; }
        public bool CanManageBaseFuel { get; set; }
        public bool CanExtendLease { get; set; }
        public bool CanAdjustPermissions { get; set; }
        public bool CanEnterBuildings { get; set; }
        public bool CanRetrieveStructures { get; set; }
        public bool CanCancelLease { get; set; }
        public bool CanRenameStructures { get; set; }
        public bool CanEditPrimaryResidence { get; set; }
        public bool CanRemovePrimaryResidence { get; set; }
        public bool CanChangeStructureMode { get; set; }
        public bool IsPublicPermission { get; set; }
        public bool CanAdjustPublicPermissions { get; set; }
        public bool CanDockStarship { get; set; }
        public bool CanFlyStarship { get; set; }
        public int ClusterID { get; set; }

        public virtual PCBase PCBase { get; set; }
        public virtual Player Player { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JSON = TW.Vault.Lib.Model.JSON;

namespace TW.Vault.Lib.Model.Convert
{
    public static class OutwardSupportConvert
    {
        public static Scaffold.CurrentVillageSupport ToModel(
                long sourceVillageId,
                short worldId,
                int accessGroupId,
                JSON.PlayerOutwardSupport.SupportedVillage villageData,
                DateTime currentTime,
                Scaffold.CurrentVillageSupport existingSupport = null,
                Scaffold.VaultContext context = null
            )
        {
            if (existingSupport == null)
            {
                existingSupport = new Scaffold.CurrentVillageSupport();
                existingSupport.WorldId = worldId;
                existingSupport.AccessGroupId = accessGroupId;
                if (context != null)
                    context.CurrentVillageSupport.Add(existingSupport);
            }

            existingSupport.SourceVillageId = sourceVillageId;
            existingSupport.TargetVillageId = villageData.Id;

            existingSupport.LastUpdatedAt = currentTime;
            existingSupport.SupportingArmy = ArmyConvert.JsonToArmy(villageData.TroopCounts, worldId, existingSupport.SupportingArmy, context);

            return existingSupport;
        }
    }
}

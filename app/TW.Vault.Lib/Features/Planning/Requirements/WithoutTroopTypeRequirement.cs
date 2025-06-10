﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TW.Vault.Lib.Model;
using TW.Vault.Lib.Model.JSON;

namespace TW.Vault.Lib.Features.Planning.Requirements
{
    public class WithoutTroopTypeRequirement : ICommandRequirements
    {
        public static readonly WithoutTroopTypeRequirement WithoutNobles = new WithoutTroopTypeRequirement { TroopType = TroopType.Snob };

        public TroopType TroopType { get; set; }

        public bool MeetsRequirement(decimal worldSpeed, decimal travelSpeed, Coordinate source, Coordinate target, Army army)
        {
            return !army.ContainsKey(this.TroopType) || army[this.TroopType] == 0;
        }
    }
}

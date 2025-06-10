﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TW.Vault.Lib.Features.Simulation;
using TW.Vault.Lib.Model;
using TW.Vault.Lib.Model.JSON;

namespace TW.Vault.Lib.Features.Planning.Requirements
{
    public class MinimumOffenseRequirement : ICommandRequirements
    {
        public static readonly MinimumOffenseRequirement FullNuke = new MinimumOffenseRequirement { MinimumOffense = 500000 };
        public static readonly MinimumOffenseRequirement ThreeQuarterNuke = new MinimumOffenseRequirement { MinimumOffense = 375000 };
        public static readonly MinimumOffenseRequirement HalfNuke = new MinimumOffenseRequirement { MinimumOffense = 250000 };
        public static readonly MinimumOffenseRequirement QuarterNuke = new MinimumOffenseRequirement { MinimumOffense = 125000 };

        public static MinimumOffenseRequirement FractionalNuke(float percent)
        {
            return new MinimumOffenseRequirement { MinimumOffense = (int)(FullNuke.MinimumOffense * percent) };
        }

        public int MinimumOffense { get; set; }
        public TroopType[] AllowedTypes { get; set; }

        public bool MeetsRequirement(decimal worldSpeed, decimal travelSpeed, Coordinate source, Coordinate target, Army army)
        {
            if (AllowedTypes != null)
                army = army.Only(AllowedTypes);

            return BattleSimulator.AttackPower(army).Total >= MinimumOffense;
        }
    }
}

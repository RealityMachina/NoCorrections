using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using BattleTech;

namespace NoCorrectedRoll
{
    class CorrectionPatch
    {
        [HarmonyPatch(typeof(BattleTech.AttackDirector))]
        [HarmonyPatch("GetCorrectedRoll")]
        public static class BattleTech_CorrectedRoll_Prefix
        {
            static bool Prefix(AttackDirector __instance, ref float __result, ref float roll, ref Team team)
            {
                __result = roll;

                return false; //always override
            }
        }
    }
}

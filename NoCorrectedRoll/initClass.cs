using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using System.Reflection;

namespace NoCorrectedRoll
{
    public class InitClass
    {
        public static void Init()
        {
            var harmony = HarmonyInstance.Create("Battletech.realitymachina.NoCorrections");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}

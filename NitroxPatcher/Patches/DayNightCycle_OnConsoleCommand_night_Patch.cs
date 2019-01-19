using Harmony;
using System.Reflection;

namespace NitroxPatcher.Patches
{
    class DayNightCycle_OnConsoleCommand_night_Patch : NitroxPatch
    {
        public static bool Prefix()
        {
            return false;
        }

        public override void Patch(HarmonyInstance harmony)
        {
            PatchPrefix(harmony, typeof(DayNightCycle).GetMethod("OnConsoleCommand_night", BindingFlags.Instance | BindingFlags.NonPublic));
        }
    }
}

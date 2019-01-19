using Harmony;
using System.Reflection;
using NitroxClient.Communication.Abstract;
using NitroxModel.Core;
using NitroxModel.Packets;

namespace NitroxPatcher.Patches
{
    class Bed_EnterInUseMode_Patch : NitroxPatch
    {
        public static void Postfix()
        {
            IPacketSender packetSender = NitroxServiceLocator.LocateService<IPacketSender>();
            packetSender.Send(new BedEnter());
        }

        public override void Patch(HarmonyInstance harmony)
        {
            PatchPostfix(harmony, typeof(Bed).GetMethod("EnterInUseMode", BindingFlags.Instance | BindingFlags.NonPublic));
        }
    }
}

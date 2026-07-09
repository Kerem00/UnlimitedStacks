using BepInEx;
using HarmonyLib;

namespace UnlimitedStacks
{
    [BepInPlugin("lwitw.mods.UnlimitedStacks", "Raises stack count to 9999", "1.0.0")]
    public class UnlimitedStacksMod : BaseUnityPlugin
    {
        private void Awake()
        {
            new Harmony("lwitw.mods.UnlimitedStacks").PatchAll();
            this.Logger.LogInfo((object)"Raises stack count to 9999");
        }
    }
}

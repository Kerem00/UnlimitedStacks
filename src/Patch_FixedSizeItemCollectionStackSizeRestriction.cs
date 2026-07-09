using HarmonyLib;
using Opsive.UltimateInventorySystem.Core;
using SunnySideUp;

namespace UnlimitedStacks
{
    [HarmonyPatch(typeof(FixedSizeItemCollectionStackSizeRestriction), "GetMaxStackSize")]
    public static class Patch_FixedSizeItemCollectionStackSizeRestriction
    {
        [HarmonyPrefix]
        public static bool Prefix(
            FixedSizeItemCollectionStackSizeRestriction __instance,
            ItemDefinition item,
            ref int __result)
        {
            if (item == null)
            {
                __result = 0;
                return false;
            }

            __result = 9999;
            return false;
        }
    }
}

using Engine;
using GameEntitySystem;
using HarmonyLib;
using TemplatesDatabase;

namespace Game {
    // 你可以在你喜欢的地方进行 Harmony.PatchAll，该示例是在 TemplateModLoader.__ModInitialize() 进行的。更多关于 Harmony：https://github.com/BepInEx/HarmonyX/wiki
    // You can call Harmony.PatchAll() anywhere you like. In this template, it is called in TemplateModLoader.__ModInitialize(). More about Harmony: https://github.com/BepInEx/HarmonyX/wiki
    [HarmonyPatch(typeof(ComponentPlayer), nameof(ComponentPlayer.Load))]
    class TemplateHarmonyPatch {
        static void Prefix(ref ValuesDictionary valuesDictionary, ref IdToEntityMap idToEntityMap) {
            int playerIndex = valuesDictionary.GetValue<int>("PlayerIndex");
            Log.Information($"Survivalcraft Template Mod: ComponentPlayer ({playerIndex}) is loading. 来自生存战争示例模组：ComponentPlayer ({playerIndex}) 正在加载。");
        }
    }
}
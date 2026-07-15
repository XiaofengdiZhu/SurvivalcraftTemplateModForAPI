using System;
using System.Collections.Generic;
using Engine;
using HarmonyLib;

namespace Game {
    public class TemplateModLoader : ModLoader {
        public const string PackageName = "xfdz.SurvivalcraftTemplateMod";
        public override void __ModInitialize() {
            ModsManager.RegisterHook("OnLoadingFinished", this);

            // 你可以在此处进行 Harmony 的 Patch
            // You can do Harmony Patch at here.
            Harmony harmony = new Harmony(PackageName);
            harmony.PatchAll();
        }

        // 必须在 __ModInitialize() 方法中注册，否则无效
        // You must register it at __ModInitialize(), otherwise it will not work.
        public override void OnLoadingFinished(List<Action> actions) {
            ModSettingsManager.TryGet(out bool setting, PackageName, "TemplateModSettingsGroup1", "TemplateModSettingsItem1");
            Log.Information($"Survivalcraft Template Mod: Game Loaded. A setting: {setting} 来自生存战争示例模组：游戏已加载。一个设置：{setting}");
        }
    }
}
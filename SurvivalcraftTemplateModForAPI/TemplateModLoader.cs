using System;
using System.Collections.Generic;
using Engine;

namespace Game {
    public class TemplateModLoader:ModLoader {
        public override void __ModInitialize() {
            ModsManager.RegisterHook("OnCameraChange", this);
        }

        public override void OnLoadingFinished(List<Action> actions) {
            Log.Information("Survivalcraft Template Mod: Game Loaded. 来自生存战争示例模组：游戏已加载。");
        }
    }
}
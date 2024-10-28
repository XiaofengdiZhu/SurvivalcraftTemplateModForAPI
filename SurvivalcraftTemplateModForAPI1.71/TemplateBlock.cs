using Engine;

namespace Game {
    public class TemplateBlock : CubeBlock {
        public const int Index = 987;

        public override void Initialize() {
            base.Initialize();
            Log.Information("Survivalcraft Template Mod: Template Block Loaded. 来自生存战争示例模组：示例方块已加载。");
        }
    }
}
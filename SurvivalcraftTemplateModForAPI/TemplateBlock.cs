using Engine;

namespace Game {
    public class TemplateBlock : CubeBlock {
        public override void Initialize() {
            base.Initialize();
            int contents = BlocksManager.GetBlockIndex<TemplateBlock>();
            Log.Information($"Survivalcraft Template Mod: Template Block Loaded (Contents: {contents}). 来自生存战争示例模组：示例方块已加载（ID：{contents}）。");
        }
    }
}
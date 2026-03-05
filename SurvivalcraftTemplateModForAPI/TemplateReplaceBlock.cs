using Game;

// The namespace cannot be Game
// 命名空间不能是 Game
namespace YourModNamespace {
    // Replace the original DirtBlock with your own
    // 替换原版 DirtBlock 为你的
    public class DirtBlock : Game.DirtBlock {
        public new static int Index = 2;
        public const string fName = "TemplateReplaceBlock";
        public override string GetDisplayName(SubsystemTerrain subsystemTerrain, int value) => LanguageControl.Get(fName, "1");
        public override string GetDescription(int value) => LanguageControl.Get(fName, "2");
        public override bool IsSuitableForPlants(int value, int plantValue) => false;
    }
}
using Game;

namespace YourModNamespace {
    public class DirtBlock : Game.DirtBlock {
        public new static int Index = 2;
        public new const string fName = "TemplateReplaceBlock";
        public override string GetDisplayName(SubsystemTerrain subsystemTerrain, int value) => LanguageControl.Get(fName, "1");
        public override string GetDescription(int value) => LanguageControl.Get(fName, "2");
    }
}
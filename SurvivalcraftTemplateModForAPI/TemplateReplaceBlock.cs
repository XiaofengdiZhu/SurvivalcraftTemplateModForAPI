using Game;

namespace YourModNamespace {
    public class DirtBlock : Game.DirtBlock {
        public new static int Index = 2;
        public override string GetDisplayName(SubsystemTerrain subsystemTerrain, int value) => "Replaced Dirt";
        public override string GetDescription(int value) => "This Dirt Block has been replaced";
    }
}
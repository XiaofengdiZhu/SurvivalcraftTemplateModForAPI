using Engine;
using GameEntitySystem;
using TemplatesDatabase;

namespace Game {
    // All subsystems must be registered in a .xdb file. Subsystems not only can control block behaviors, but also can implement many other functions, please refer to the API source code in /Survivalcraft/Subsystem
    // 子系统都需要在一个 .xdb 文件中注册。子系统除了能控制方块行为，还能实现很多其他功能，请参考插件版源码/Survivalcraft/Subsystem
    public class SubsystemTemplateBlockBehavior : SubsystemBlockBehavior {
        public SubsystemPlayers m_subsystemPlayers;
        public override int[] HandledBlocks => [BlocksManager.GetBlockIndex<TemplateBlock>()];

        public override void Load(ValuesDictionary valuesDictionary) {
            m_subsystemPlayers = Project.FindSubsystem<SubsystemPlayers>();
            Log.Information("Survivalcraft Template Mod: Template Subsystem Loaded. 来自生存战争示例模组：示例子系统已加载。");
        }

        public override void OnBlockAdded(int value, int oldValue, int x, int y, int z) {
            foreach (ComponentPlayer componentPlayer in m_subsystemPlayers.ComponentPlayers) {
                componentPlayer.ComponentGui.DisplaySmallMessage($"{x}, {y}, {z}", Color.White, false, false);
            }
        }
    }
}
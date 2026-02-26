using Engine;
using GameEntitySystem;
using TemplatesDatabase;

namespace Game {
    // 子系统都需要在一个 .xdb 文件中注册
    // All subsystems must be registered in a .xdb file.
    public class SubsystemTemplate : Subsystem {
        public override void Load(ValuesDictionary valuesDictionary) {
            Log.Information("Survivalcraft Template Mod: Template Subsystem Loaded. 来自生存战争示例模组：示例子系统已加载。");
        }
    }
}
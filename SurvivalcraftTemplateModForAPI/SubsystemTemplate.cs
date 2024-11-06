using Engine;
using GameEntitySystem;
using TemplatesDatabase;

namespace Game {
    public class SubsystemTemplate : Subsystem {
        public override void Load(ValuesDictionary valuesDictionary) {
            Log.Information("Survivalcraft Template Mod: Template Subsystem Loaded. 来自生存战争示例模组：示例子系统已加载。");
        }
    }
}
using Engine;
using GameEntitySystem;
using TemplatesDatabase;

namespace Game {
    public class ComponentTemplate : Component, IUpdateable {
        public ComponentPlayer m_componentPlayer;

        public bool m_templateWidgetNotInserted = true;

        public UpdateOrder UpdateOrder => UpdateOrder.Default;

        public override void Load(ValuesDictionary valuesDictionary, IdToEntityMap idToEntityMap) {
            m_componentPlayer = Entity.FindComponent<ComponentPlayer>(true);
            Log.Information("Survivalcraft Template Mod: Template Component Loaded. 来自生存战争示例模组：示例子系统已加载。");
        }

        public void Update(float dt) {
            if (m_templateWidgetNotInserted) {
                m_componentPlayer.GuiWidget.AddChildren(new TemplateWidget());
                m_templateWidgetNotInserted = false;
            }
        }
    }
}
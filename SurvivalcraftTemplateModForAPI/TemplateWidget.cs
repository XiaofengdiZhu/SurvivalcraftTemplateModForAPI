using System.Xml.Linq;
using Engine;

namespace Game {
    // 该部件是在 ComponentTemplate 中创建并添加到界面中的
    // This widget is instantiated in ComponentTemplate and added to the GUI.
    public class TemplateWidget : CanvasWidget {
        public TemplateWidget() {
            LoadContents(this, ContentManager.Get<XElement>("Widgets/TemplateWidget"));
            Log.Information("Survivalcraft Template Mod: Template Widget Instantiated. 来自生存战争示例模组：示例部件已实例化。");
        }
    }
}
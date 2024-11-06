using System.Xml.Linq;
using Engine;

namespace Game {
    public class TemplateWidget : CanvasWidget {
        public TemplateWidget() {
            LoadContents(this, ContentManager.Get<XElement>("Widgets/TemplateWidget"));
            Log.Information("Survivalcraft Template Mod: Template Widget Instantiated. 来自生存战争示例模组：示例部件已实例化。");
        }
    }
}
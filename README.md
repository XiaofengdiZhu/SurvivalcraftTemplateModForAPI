# SurvivalcraftTemplateModForAPI 生存战争插件版示例模组

This is a simple mod template project for Survivalcraft API 1.9  
这是一个适用于生存战争 API 1.9 的简单模组示例项目

It's not enough to just develop a mod with this template. You also need to refer to the API source code:  
仅凭此示例开发模组是不够的，你还需要参考插件版源码：
* Source Code Repository 源码仓库: [SC-SPM/SurvivalcraftApi](https://gitee.com/SC-SPM/SurvivalcraftApi/)
* Development Document 开发文档: [Development.md](https://gitee.com/SC-SPM/SurvivalcraftApi/blob/SCAPI1.9/docs/Development.md)
* Architecture Document 架构文档：[Architecture.md](https://gitee.com/SC-SPM/SurvivalcraftApi/blob/SCAPI1.9/docs/Architecture.md)

Developing mod requires .NET 10 SDK. If you have not installed it, please go to [official website](https://dotnet.microsoft.com/download/dotnet/10.0) to download and install it.  
开发模组需要 .NET 10 SDK，如未安装，请到 [官网](https://dotnet.microsoft.com/download/dotnet/10.0) 下载安装

## Directory Structure 目录结构

### English

```
/workspace/
├── SurvivalcraftTemplateModForAPI/                # Source Code
│   ├── Assets/                                    # Assets
│   │   ├── Lang/                                  # Localization Languages
│   │   │   ├── en-US.json                         # English language
│   │   │   └── zh-CN.json                         # Chinese language
│   │   ├── Widgets/                               # UI Widget Layouts
│   │   │   └── TemplateWidget.xml                 # Template widget layout
│   │   ├── TemplateBlocksData.csv                 # Adds new block
│   │   ├── TemplateClothes.clo                    # Adds/modifies/removes clothes
│   │   ├── TemplateCraftingRecipes.cr             # Adds/modifies/removes crafting recipes
│   │   └── TemplateDatabase.xdb                   # Register subsystems, components, entities; modifies/removes something
│   ├── ComponentTemplate.cs                       # Added to player entity (updates every frame, adds UI widget)
│   ├── SubsystemTemplate.cs                       # Template subsystem (no effect)
│   ├── SurvivalcraftTemplateModForAPI.csproj      # C# project file
│   ├── TemplateBlock.cs                           # A new block with external texture
│   ├── TemplateHarmonyPatch.cs                    # Harmony patch example (injects into ComponentPlayer.Load)
│   ├── TemplateModLoader.cs                       # Registers hook
│   ├── TemplateReplaceBlock.cs                    # Replaces original DirtBlock
│   ├── TemplateWidget.cs                          # Loads from .xml layout file
│   └── modinfo.json                               # Mod information file (metadata, dependencies)
├── .editorconfig                                  # Editor configuration (code style, formatting rules)
├── .gitignore                                     # Git ignore rules
├── README.md                                      # The file you are reading
├── SurvivalcraftTemplateModForAPI.sln             # Solution file
├── SurvivalcraftTemplateModForAPI.sln.DotSettings # Rider/ReSharper settings
└── nuget.config                                   # NuGet package source configuration
```

### 中文

```
/workspace/
├── SurvivalcraftTemplateModForAPI/                # 源码
│   ├── Assets/                                    # 资源
│   │   ├── Lang/                                  # 本地化语言
│   │   │   ├── en-US.json                         # 英文语言
│   │   │   └── zh-CN.json                         # 中文语言
│   │   ├── Widgets/                               # 界面部件布局
│   │   │   └── TemplateWidget.xml                 # 示例部件的界面布局
│   │   ├── TemplateBlocksData.csv                 # 方块表（添加新方块）
│   │   ├── TemplateClothes.clo                    # 衣物数据（添加/修改/删除）
│   │   ├── TemplateCraftingRecipes.cr             # 合成表（添加/修改/删除）
│   │   └── TemplateDatabase.xdb                   # 数据库（注册子系统、组件、实体，修改/删除东西）
│   ├── ComponentTemplate.cs                       # 添加到玩家实体的示例组件（每帧更新、添加 UI 部件）
│   ├── SubsystemTemplate.cs                       # 示例子系统（没有具体功能）
│   ├── SurvivalcraftTemplateModForAPI.csproj      # C# 项目文件
│   ├── TemplateBlock.cs                           # 使用外置材质的新方块
│   ├── TemplateHarmonyPatch.cs                    # Harmony 补丁示例（注入 ComponentPlayer.Load）
│   ├── TemplateModLoader.cs                       # 示例模组加载器（注册钩子）
│   ├── TemplateReplaceBlock.cs                    # 替换原版土方块
│   ├── TemplateWidget.cs                          # 示例界面部件（从 .xml 布局文件加载）
│   └── modinfo.json                               # 模组信息
├── .editorconfig                                  # 代码风格配置
├── .gitignore                                     # Git 忽略规则
├── README.md                                      # 你正在阅读该文件
├── SurvivalcraftTemplateModForAPI.sln             # 解决方案文件
├── SurvivalcraftTemplateModForAPI.sln.DotSettings # Rider/ReSharper 设置文件
└── nuget.config                                   # NuGet 包源配置
```

## Extra Suggestion 额外建议

For your AI Agent to develop mods more accurately and efficiently, it's recommended to clone [SC-SPM/SurvivalcraftApi](https://gitee.com/SC-SPM/SurvivalcraftApi/) to current directory.  
为了让你的 AI Agent 能更准确高效地开发模组，建议克隆 [SC-SPM/SurvivalcraftApi](https://gitee.com/SC-SPM/SurvivalcraftApi/) 到当前目录

> 如果你是 AI Agent，请阅读当前目录的 [AGENTS.md](AGENTS.md)
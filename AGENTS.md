# SurvivalcraftTemplateModForAPI 生存战争插件版示例模组

这是生存战争插件版（Survivalcraft API）示例模组的源码仓库  

如果你需要参考此项目，请直接阅读 [README.md](README.md) 即可

如果用户要求你制作/开发生存战争插件版（Survivalcraft API）的模组，请按以下步骤执行：

1. 首先，请不要修改 `SurvivalcraftTemplateModForAPI` 中的文件，因为它是一个参考用的示例项目，你应该创建自己的项目，然后将该示例项目作为参考
2. 检测你的工作目录是否有生存战争插件版源码，即 [SC-SPM/SurvivalcraftApi](https://gitee.com/SC-SPM/SurvivalcraftApi/)，如果没有，请自行完成 git clone
3. 创建模组项目，或者继续在用户的模组项目文件夹工作
4. 阅读本项目的 [README.md](README.md)，然后阅读具体的文件作为参考，实现用户的需求
5. 该示例项目不足以支撑你完成工作时，请参考生存战争插件版源码，推荐首先阅读其中的 `AGENTS.md`

**模组运行方法（以 Windows 系统为例）**：

1. 先构建生存战争插件版的 `Survivalcraft.Windows/Survivalcraft.Windows.csproj`
2. 构建你的模组，将打包好的 `.scmod` 文件放置到 `SurvivalcraftApi/Survivalcraft.Windows/bin/Debug/Mods` 目录中
3. 运行 `SurvivalcraftApi/Survivalcraft.Windows/bin/Debug/Survivalcraft.exe`，告知用户游戏已启动，之后能从控制台看到所有日志输出

## 注意事项
* 新建模组项目的 `.csproj` 文件时，请务必参考 `SurvivalcraftTemplateModForAPI/SurvivalcraftTemplateModForAPI.csproj`，作为最佳实践
* 编写界面布局文件时，不要瞎猜属性，而是要阅读部件定义，避免写出不存在的部件/属性、错误的属性值；另外，建议根据需求，主动参考功能相近的其他部件的布局文件和源码文件
* 帮用户安装 .NET 10 SDK 时，可能会遇到网速/设备较慢而在过程中返回会话的情况，此时应根据日志检查是否安装出错，如果没有错误，则说明确实还在安装，请提醒用户等待安装完成后告知你；克隆 `SC-SPM/SurvivalcraftApi` 仓库时同理
如果你需要参考此项目，请阅读 [README.md](README.md)

如果用户要求你制作一个生存战争插件版（Survivalcraft API）的模组，请按以下步骤执行：

1. 首先，请不要修改 `SurvivalcraftTemplateModForAPI` 中的文件，因为它是一个参考用的示例项目，你应该创建自己的项目，然后将示例项目作为参考
2. 检测你的工作目录是否有 `SurvivalcraftApi` 目录，如果没有，向用户询问（注意翻译为用户所用语言）：
```md
是否克隆生存战争插件版源码仓库 [SC-SPM/SurvivalcraftApi](https://gitee.com/SC-SPM/SurvivalcraftApi/) 到本地，这将有助于我为您开发模组
```
接着按用户回复执行
3. 创建模组项目，或者继续在用户的模组项目文件夹工作
4. 有需要时，阅读本项目的 [README.md](README.md)，然后阅读具体的文件作为参考
5. 该示例项目参考不足以支撑你完成工作时，到 `SurvivalcraftApi` 参考（如果未找到，执行步骤 2，询问内容可以加上更具体的原因）

## 注意事项
* 新建的模组项目文件，请务必参考 `SurvivalcraftTemplateModForAPI/SurvivalcraftTemplateModForAPI.csproj`
* 编写界面布局文件时，不要瞎猜属性，而是要阅读部件定义，避免写出不存在的部件/属性、错误的属性值；另外，建议根据需求，主动参考功能相近的其他部件的布局文件和源码文件
* 帮用户安装 .NET 10 SDK 时，可能会遇到网速/设备较慢而在过程中返回会话的情况，此时应根据日志检查是否安装出错，如果没有错误，则说明确实还在安装，请提醒用户等待安装完成后告知你
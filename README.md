联系QQ: 2925856889

 **简介** 
------------
YouYou Framework 是一个开源的客户端游戏框架（基于Unity3d）.<br>
YouYouServer服务端框架, 现已独立到另外仓库, 支持单客户端使用或双端同时使用<br>


 **原作者: 搜狐畅游-饭饭**<br>
 **框架开源迭代: Chen** 
 
在最新的 YouYou Framework 版本中, 包含以下内置模块. 

 **YouYouEditor(Odin可视化编辑界面)**
------------------------------------
{
>宏配置(Macro) - 选择资源加载模式,如AssetBundle加载,AssetDatabase加载,Resource加载

>全局配置(Config) - 支持设备等级参数（高 中 低 配机）,如Http失败重试次数，不同等级设备匹配相应参数值

>调试器 (Debugger) - 选择开启<br>
1.可在打包APK后,出现调试器窗口，便于查看运行时日志、调试信息等<br>
2.每次启动后会生成日志记录文本,可设置日志缓存数量,单文件最大存储数量

>资源打包配置(AssetBundle) - 支持配置 资源包版本号, 资源包加密:<br>
1.设置文件夹内容打整包或散包,如Excel,Lua脚本可以打成整包，角色、场景、特效、UI可以打成散包<br>
2.打包到【对应版本号/平台】文件夹内,生成"依赖关系文件"和"版本信息文件"，加载时自动读取

>对象池分析(Pool Analyze) - 方便查看项目里各个池中的资源的资源计数和剩余释放时间:<br>
1.类对象池<br>
2.AssetBundle池<br>
3.Asset池

}

 **GameEntry(游戏框架入口)** 
------------------------------------
{
>数据 (Data) - 将任意类型的数据进行全局保存，用于管理游戏运行时的各种数据。

>数据表 (Data Table) - 将游戏数据以表格（Excel）的形式进行配置后，可以使用此模块读取数据表。数据表的格式是支持自定义的。

>下载 (Download) - 提供下载文件的功能，支持断点续传，并可指定允许几个下载器进行同时下载。更新资源时会主动调用此模块。

>事件 (Event) - 观察者模式思想, YouYouFramework 中的很多模块在完成操作后会抛出内置事件,用户也可以定义自己的游戏逻辑事件。

>有限状态机 (FSM) - 提供创建、使用和销毁有限状态机的功能。方便管理多个状态机.

>本地化 (Localization) - 提供本地化功能，也就是我们平时所说的多语言。支持Text和Image的本地化

>对象池 (Object Pool) - 提供对象缓存池的功能，避免频繁地创建和销毁各种游戏对象，提高游戏性能。除了 YouYouFramework 自身使用了对象池，用户还可以很方便地创建和管理自己的对象池。目前支持类对象池,变量池,GameObject对象池,AssetBundle池,Asset池等(如Prefab).

>流程 (Procedure) - 是贯穿游戏运行时整个生命周期的有限状态机。通过流程，将不同的游戏状态进行解耦将是一个非常好的习惯。对于网络游戏，你可能需要如检查资源流程、更新资源流程、检查服务器列表流程、选择服务器流程、登录服务器流程、创建角色流程等流程，而对于单机游戏，你可能需要在游戏选择菜单流程和游戏实际玩法流程之间做切换。如果想增加流程，只要派生自 ProcedureBase 类并实现自己的流程类即可使用。

>资源 (Resource) - 使用了一套完整的异步加载资源体系。不论简单的数据表、本地化字典，还是复杂的实体、场景、界面，都可使用异步加载。同时，YouYouFramework 提供了默认的内存管理策略（当然，你也可以定义自己的内存管理策略, 甚至切换Resource加载模式）。

>场景 (Scene) - 提供场景管理的功能，可以同时加载多个场景，也可以随时卸载任何一个场景，从而很容易地实现场景的分部加载。

>声音 (Sound) - 提供管理声音和声音组的功能，支持全局音量调节, 音效音量单独配表

>界面 (UI) - 提供管理界面和界面组的功能，如 激活界面、改变界面层级等。界面使用结束后可以不立刻销毁(UI池)，从而等待下一次重新使用。

>Web 请求 (Web Request) - 提供使用短连接的功能，可以用 Get 或者 Post 方法向服务器发送请求并获取响应数据，可指定允许几个 Web 请求器进行同时请求。

>本地数据存档 (PlayerPrefs) - 提供了基于Unity官方PlayerPrefs的本地数据存档, 支持数据更新派发事件, 支持存Object对象

>代码热更新 (HybridCLR) - 提供了基于HybridCLR的代码热更新, 可调用YouYouFramework的任意模块.

>新手引导 (Guide) - 提供了新手引导框架, 拆分多模块和多步骤(在模块内), 支持存档, 支持单模块重复引导

>定时器 (Time) - 提供了定时功能，支持多种定时需求, 如复活倒计时, 技能CD等, 用于管理游戏运行时的各种定时器。

>画质设置 (Quality) - 提供了Quality设置, 分辨率设置, 帧率设置等, 支持存档和画质切换时的事件派发。

>输入系统 (Input) - 提供了跨平台的Input封装, 支持PC(键盘鼠标)和手机(触屏)实时切换, 并实现输入方和监听方的代码解耦合。

}
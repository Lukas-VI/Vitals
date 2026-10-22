using Godot;

namespace GodotAls.Locomotion;

// 仅启用 ALS 的模板入口：不创建 ALS/Lyra 切换器，也不加载任何 Lyra 资源。
public partial class AlsOnlyDemoEntry : Node
{
    public override void _Ready()
    {
        // ConfigureBeforeReady 非空时，AlsDemoEntry 会跳过 Lyra 切换器和 Lyra 地面标记。
        AddChild(new AlsDemoEntry { ConfigureBeforeReady = _ => { } });
    }
}

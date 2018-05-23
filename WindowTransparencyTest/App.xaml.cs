using Avalonia;
using Avalonia.Markup.Xaml;

namespace WindowTransparencyTest
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

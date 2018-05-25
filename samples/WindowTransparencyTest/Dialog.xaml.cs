using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace WindowTransparencyTest
{
    public class Dialog : Window
    {
        public Dialog()
        {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

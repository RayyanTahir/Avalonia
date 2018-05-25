// Copyright (c) The Avalonia Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace WindowTransparencyTest
{
    public class MainWindow : Window
    {
        Button btnOpen;
        public MainWindow()
        {
            this.InitializeComponent();
            this.AttachDevTools();
            btnOpen = this.FindControl<Button>("btnOpen");
            btnOpen.Click += (s, e) => 
            {
                Dialog dlg = new Dialog();
                dlg.Owner = this;
                dlg.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                dlg.Show();
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

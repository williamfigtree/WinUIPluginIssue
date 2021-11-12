using Microsoft.UI.Xaml.Controls;

namespace Plugin
{
    public sealed partial class PluginUserControl : UserControl
    {
        public PluginUserControl()
        {
            // This line throws XamlParsingException - Cannot locate resource from 'ms-appx:///Plugin/PluginUserControl.xaml'
            this.InitializeComponent();
        }
    }
}

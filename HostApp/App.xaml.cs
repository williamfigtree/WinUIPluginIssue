using Microsoft.UI.Xaml;
using System;
using System.IO;

namespace HostApp
{
    public partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();

            // Attempt to load a UserControl from a plugin dll
            // PluginUserControl throws an XamlParsingExcpetion during instantiation

            // Locate plugin dll in the Plugin project bin directory
            var rootPath = Path.GetFullPath(@"..\..\..\..\..\..\..\..\", typeof(Program).Assembly.Location);
            var pluginDllPath = Path.Combine(rootPath, @"Plugin\bin\x86\Debug\net5.0-windows10.0.19041.0\Plugin.dll");

            // Instantiate PluginUserControl
            var pluginLoadContext = new PluginLoadContext(pluginDllPath);
            using (pluginLoadContext.EnterContextualReflection())
            {
                var assembly = pluginLoadContext.LoadFromAssemblyPath(pluginDllPath);
                var pluginUserControl = Activator.CreateInstance(assembly.GetType("Plugin.PluginUserControl"));
            }
        }
    }
}

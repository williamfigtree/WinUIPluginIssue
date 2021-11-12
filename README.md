# WinUIPluginIssue
An application that attempts to instantiate a UserControl from an unpackaged assembly.

Throws XamlParseException from the PluginUserControl constructor

```
Exception thrown at 0x773B35D2 (KernelBase.dll) in HostApp.exe: WinRT originate error - 0x80004005 : 'Cannot locate resource from 'ms-appx:///Plugin/PluginUserControl.xaml'.'.
Exception thrown: 'Microsoft.UI.Xaml.Markup.XamlParseException' in WinRT.Runtime.dll
WinRT information: Cannot locate resource from 'ms-appx:///Plugin/PluginUserControl.xaml'.
XAML parsing failed.
```

## Build Instructions
1. Build Plugin.csproj
2. Build and Deploy HostApp.csproj

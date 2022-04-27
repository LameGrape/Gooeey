# Gooeey
Gooeey is a Stick Fight UI helper plugin for BepInEx. It is intended to help other plugins easily add UI elements, such as text and overlays.

This plugin does not do anything by itself. It is only designed to be included in plugins as a dependency.

## Installation
To download the latest version of Gooeey, go to the releases tab on the right and download `Gooeey.dll`. Once it finishes downloading, put it into the BepInEx Plugins folder (located at `%STICK FIGHT FOLDER%/BepInEx/plugins`). If the plugin that requires Gooeey already has it packaged in the download, you do not need to download Gooeey seperately.

### For developers
If you want to use Gooeey in your plugins, follow the same steps as above to download Gooeey. Then, in your plugin's .csproj file, add it as a reference in an ItemGroup (if you already reference Assemly-CSharp or Unity libraries, this should be in the same ItemGroup):
```xml
<Reference Include='Gooeey'>
	<HintPath>%STICK FIGHT FOLDER%\BepInEx\plugins\Gooeey.ddl</HintPath>
</Reference>
```
and add it as a dependency in the main .cs file:
```cs
[BepInDependency("raisin.plugins.gooeey", BepInDependency.DependencyFlags.HardDependency)]
```

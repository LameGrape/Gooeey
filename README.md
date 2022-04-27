# Gooeey
Gooeey is a Stick Fight UI helper plugin for BepInEx. It is intended to help other plugins easily add UI elements, such as text and overlays.

This plugin does not do anything by itself. It is only designed to be included in plugins as a dependency.

## Installation
To download the latest version of Gooeey, go to the releases tab on the right and download `Gooeey.dll`. Once it finishes downloading, put it into the BepInEx Plugins folder (located at `%STICK FIGHT FOLDER%/BepInEx/plugins`). If the plugin that requires Gooeey already has it packaged in the download, you do not need to download Gooeey seperately.

### For developers
If you want to use Gooeey in your plugins, follow the same steps as above to download Gooeey. Then, in your plugin's .csproj file, add it as a reference in an ItemGroup (if you already reference Assemly-CSharp or Unity libraries, this should be in the same ItemGroup). TextMeshPro and UnityEngine.UI should be imported as well:
```xml
<Reference Include='Gooeey'>
	<HintPath>%STICK FIGHT FOLDER%\BepInEx\plugins\Gooeey.dll</HintPath>
</Reference>
<Reference Include='TextMeshPro-1.0.55.56.0b9'>
	<HintPath>%STICK FIGHT FOLDER%\StickFight_Data\Managed\TextMeshPro-1.0.55.56.0b9.dll</HintPath>
</Reference>
<Reference Include='UnityEngine.UI'>
	<HintPath>%STICK FIGHT FOLDER%\StickFight_Data\Managed\UnityEngine.UI.dll</HintPath>
</Reference>
```
add it as a dependency in the main .cs file:
```cs
[BepInDependency("raisin.plugins.gooeey", BepInDependency.DependencyFlags.HardDependency)]
```
and finally, add using directives:
```cs
using Gooeey;
using TMPro;
```
Gooeey should now be imported into the project.

Due to the way Gooeey is made, the Gooeey class must be declared before the functions can be used. Therefore, it is suggested to make a global UI variable for Gooeey:
```cs
Gooeey UI = new Gooeey();
```

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
and finally, add a using directive:
```cs
using Gooeey;
```
All the Gooeey functions should now be available in your plugin.

# Documentation

## Functions

### Gooeey.CreateText(string name, string text) : TextMeshProUGUI
Creates a text object and returns it. The text object is also saved to Gooeey.textObjects.

* _name_ : The name of the GameObject to be created. The name is used to search for the text object in Gooeey.FindText.
* _text_ : The text to be displayed. This can be changed at any time by saving the returned TextMeshProUGUI as a variable, or fetching the text object with Gooeey.FindText.

#### Example
```cs
TextMeshProUGUI text = Gooeey.CreateText("Example", "This is a Gooeey example.")
text.fontSize = 50;
text.color = Color.green;
```

using BepInEx;
using UnityEngine;
using TMPro;
using System.Collections.Generic;

namespace Gooeey
{
    [BepInPlugin("raisin.plugins.gooeey", PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            Logger.LogInfo($"raisin.plugins.gooeey v{PluginInfo.PLUGIN_VERSION} - Gooeey successfully loaded.");
        }
    }
    public class Gooeey
    {
        public List<TextMeshProUGUI> textObjects = new List<TextMeshProUGUI>();
        public TextMeshProUGUI CreateText(string name, string text){ // Create a new text object
            GameObject textObject = new GameObject(name);
            textObject.AddComponent<Canvas>().renderMode = RenderMode.ScreenSpaceOverlay;
            TextMeshProUGUI tmp = textObject.AddComponent<TextMeshProUGUI>();

            tmp.text = text;
            tmp.fontSize = 30;
            tmp.color = Color.white;
            tmp.fontStyle = FontStyles.Bold;
            tmp.alignment = TextAlignmentOptions.Center;

            textObjects.Add(tmp);
            return tmp;
        }
        public TextMeshProUGUI FindText(string name){ // Find a text object by name
            foreach(TextMeshProUGUI tmp in textObjects){
                if(tmp.gameObject.name == name){
                    return tmp;
                }
            }
            return null;
        }
    }
}
using BepInEx;
using UnityEngine;
using TMPro;
using System;
using System.Collections.Generic;

namespace Gooeey
{
    [BepInPlugin("raisin.plugins.gooeey", PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        public List<TextMeshProUGUI> textObjects = new List<TextMeshProUGUI>();
        private void Awake()
        {
            Logger.LogInfo($"raisin.plugins.gooeey v{PluginInfo.PLUGIN_VERSION} - Gooeey successfully loaded.");
        }

        public TextMeshProUGUI CreateText(string name, string text){ // Create a new Text object
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
        public TextMeshProUGUI FindText(string name){
            foreach(TextMeshProUGUI tmp in textObjects){
                if(tmp.gameObject.name == name){
                    return tmp;
                }
            }
            return null;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof(MapGenerator))]
public class MapGeneratorEditor : Editor {

    public override void OnInspectorGUI()
    {
        MapGenerator mapGen = (MapGenerator)target;

        //if changes are made in editor and autoUpdate is true, update map
        if (DrawDefaultInspector())
        {
            if (mapGen.autoUpdate)
            {
                mapGen.GenerateMap();
            }
        }
        //On button generate, update map with given values
        if (GUILayout.Button("Generate"))
        {
            mapGen.GenerateMap();
        }
    }
}

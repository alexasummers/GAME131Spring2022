using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class InspectorUI : MonoBehaviour
{

    Vector2 scrollPosition;
    Texture tex;
    int toolbarInt = 0;
    string[] toolbarStrings = { "Button 1", "Button 2", "Button 3" };

    string longString = "This is a longer string";

    void OnGUI()
    {
        //GUILayout.BeginArea(new Rect(10, 10, 100, 100));
        //GUILayout.Button("Click me!");
        //GUILayout.Button("Or me!");
        //GUILayout.EndArea();

        //GUILayout.BeginHorizontal("box");

        //GUILayout.Button("I am the first button!");
        //GUILayout.Button("I am the second button!");

        //GUILayout.EndHorizontal();

        //scrollPosition = GUILayout.BeginScrollView(
        //    scrollPosition, GUILayout.Width(100), GUILayout.Height(100));

        //GUILayout.Label(longString);

        //if (GUILayout.Button("Clear"))
        //    longString = "";

        //GUILayout.EndScrollView();

        //if (GUILayout.Button("Add More Text"))
        //    longString += "\nHere is another line";

        //if(!tex)
        //{
        //    Debug.LogError("Missing texture, assign a texture in the inspector");
        //}
        //GUILayout.Box(tex);
        //GUILayout.Box("This is a sized label");

        toolbarInt = GUILayout.Toolbar(toolbarInt, toolbarStrings);
    }
}

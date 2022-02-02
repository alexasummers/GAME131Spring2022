using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class IntroToEditor
{
    [MenuItem ("GameObject/Create IntroToEditor")]

    private static void CreateIntroToEditorGameObject () {
    if(EditorUtility.DisplayDialog(
        "Intro to Editor!",
        "Do you really want to do this?",
        "Create",
        "Cancel"
    )) {
        new GameObject("IntroToEditor");
        }
    }
}

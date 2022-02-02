using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Demo.LevelCreator {
    public static class EditorUtils {

    public static void NewScene () {
        EditorApplication.SaveCurrentSceneIfUserWantsTo ();
        EditorApplication.NewScene ();
    }

    public static void CleanScene () {
        GameObject[] allObjects = Object.FindObjectsOfType<GameObject>();

        foreach (GameObject go in allObjects) {
        GameObject.DestroyImmediate (go);
        }
    }

    public static void NewLevel () {
        NewScene ();
        CleanScene ();
        GameObject levelGO = new GameObject ("Level");
        levelGO.transform.position = Vector3.zero;
        levelGO.AddComponent<DemoScript> ();
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Cubes))]

public class CubeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        SerializedProperty cubeStatsSP = serializedObject.FindProperty("cube");
        if (cubeStatsSP.objectReferenceValue == null)
        {
            EditorGUILayout.PropertyField(cubeStatsSP);
        }
        else
        {
            CubeStats cube = cubeStatsSP.objectReferenceValue as CubeStats;

            EditorGUILayout.LabelField("Name:", cube.displayName);
            EditorGUILayout.PropertyField(cubeStatsSP);
            EditorGUILayout.Space();
            cube.strength = EditorGUILayout.IntField("Strength: ", cube.strength);
            cube.body = EditorGUILayout.IntField("Body: ", cube.body);
            cube.will = EditorGUILayout.IntField("Will: ", cube.will);
            EditorGUILayout.Space();
            int health =((cube.strength + cube.body + cube.will) /3) * 4;
            EditorGUILayout.LabelField("Calculated Stats: ");
            EditorGUILayout.LabelField("Health: " + health);
        }
    }
}

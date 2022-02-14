using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code from (https://docs.unity3d.com/Manual/editor-CustomEditors.html)
[ExecuteInEditMode]
public class LookAtPoint : MonoBehaviour
{
    public Vector3 lookAtPoint = Vector3.zero;

    void Update()
    {
        transform.LookAt(lookAtPoint);
    }
}


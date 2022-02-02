using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoExample : MonoBehaviour
{   
    private void OnDrawGizmos () {
        Gizmos.color = Color.white;
        Gizmos.DrawCube (
        transform.position, Vector3.one);
    }

    private void OnDrawGizmosSelected () {
        Gizmos.color = Color.red;
        
        Gizmos.DrawWireCube (
            transform.position, Vector3.one);
    }
}

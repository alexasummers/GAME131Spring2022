using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Source: Beginning Editor Scripting || Benny Kok (ISBN 1-4842-7166-1)

[HelpURL("https://github.com/alexasummers/GAME131Spring2022")]
//[AddComponentMenu("ClickMe/ClickMeAgain!")]
[AddComponentMenu("")]

//[ExecuteAlways]

[RequireComponent(typeof(Rigidbody))]
public class InspectorAttributes : MonoBehaviour
{
    [Header("Player Stats")]
    [Range(0, 100)]
    public float health;
    [Range(0, 50)]
    public float attackPt;

    [Header("Player Description")]
    [Multiline(4)]
    public string shortDescription;
    [TextArea(4, 6)]
    public string longDescription;

    [Tooltip("Should I choose true or false?")]
    public bool checkForTrue;

    [HideInInspector]
    public bool hiddenBool;

    [Space, SerializeField]
    private bool privateSerialiedField;

    [ContextMenu("Randomize Player Stats")]
    public void RandomizePlayerStats()
    {
        health = Random.Range(0, 101);
        attackPt = Random.Range(0, 51);
    }

    void Update()
    {
        Debug.Log("I am printing because I always execute!");
    }

    private void OnValidate()
    {
        //Example validation use case
        if (attackPt > health)
        {
            Debug.Log("Hp can't be larger than attack point.");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, 5);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawSphere(transform.position, 2);
    }

    private void Reset()
    {
        health = 10;
        attackPt = 5;
        shortDescription = "Default Description";
    }
}


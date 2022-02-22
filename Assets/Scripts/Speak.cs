using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speak : MonoBehaviour
{

    public Dialogue dialogue;
    public Text dialogueText;

    void Start()
    {
        dialogueText.text = dialogue.characterName + ": " + dialogue.characterDialogue;
    }
}

using UnityEngine;
using Yarn.Unity;


public class ClickDialog : MonoBehaviour
{
    public string nazwaDialogu;
    public DialogueRunner dialogueRunner;

    public void OnMouseDown()
    {
        dialogueRunner.StartDialogue(nazwaDialogu);
    }

}

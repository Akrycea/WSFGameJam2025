using UnityEngine;
using Yarn.Unity;

public class hollyseconddialogue : MonoBehaviour
{
    public DialogueRunner dialogueRunner;
    public ScaryRadio scaryRadio;

    private void Start()
    {
        scaryRadio = GetComponent<ScaryRadio>();
    }

    public void OnMouseDown()
    {
        if(scaryRadio.done == true)
        {
            dialogueRunner.StartDialogue("_1POST2");
        }
    }
}

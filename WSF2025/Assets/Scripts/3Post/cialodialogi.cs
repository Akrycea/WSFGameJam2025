using UnityEngine;
using Yarn.Unity;

public class cialodialogi : MonoBehaviour
{
    public string nazwaDialogu;
    public DialogueRunner dialogueRunner;
    public bool bbb = true;

    public void OnMouseDown()
    {
        if (bbb == true) {
        dialogueRunner.StartDialogue(nazwaDialogu);
            bbb = false;
        }
    }

}

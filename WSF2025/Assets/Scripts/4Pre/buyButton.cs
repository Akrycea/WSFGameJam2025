using UnityEngine;
using Yarn.Unity;

public class buyButton : MonoBehaviour
{
    public GameObject clothesArt;
    public string nazwaDialogu;
    public DialogueRunner dialogueRunner;

    private void OnMouseDown()
    {
        dialogueRunner.StartDialogue(nazwaDialogu);
        clothesArt.SetActive(false);
        gameObject.SetActive(false);
    }
}

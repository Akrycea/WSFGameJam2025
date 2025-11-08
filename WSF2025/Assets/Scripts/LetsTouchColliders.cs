using UnityEngine;
using Yarn.Unity;

public class LetsTouchColliders : MonoBehaviour
{
    public string ObjectName;
    public PuzzleMinigierka puzzleMinigierka;
    public bool jestNaObiekcie = false;
    public bool ptakDoKlatki;
    public bool ziarna;
    public string nazwaDialogu;
    public DialogueRunner dialogueRunner;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == ObjectName)
        {
            jestNaObiekcie = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == ObjectName)
        {
            jestNaObiekcie = false;
        }
    }

    void Update()
    {
        if (jestNaObiekcie == true && Input.GetMouseButton(0) == false)
        {
            if (ptakDoKlatki == true)
            {
                puzzleMinigierka.Puzzle();
                dialogueRunner.StartDialogue("_2PRE1");
            }

            if (ziarna == true)
            {
                gameObject.SetActive(false);
                dialogueRunner.StartDialogue("_2PRE2");
            }
        }
    }

}

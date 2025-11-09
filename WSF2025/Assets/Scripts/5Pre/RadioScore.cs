using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class RadioScore : MonoBehaviour
{
    public float score = 0;

    public ClerkAI ai;
    public DialogueRunner dialogueRunner;
    public string nazwaDialogu;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (score < 0)
        {
            score = 0;
        }

        score = score - Time.deltaTime/6;

    }

    private void OnMouseDown()
    {
        if (!ai.lookingAtPlayer)
        {
            score++;
            Debug.Log("score: " + score);
        }
        else
        {
            score--;
        }

        if (score > 20)
        {
            Debug.Log("win");
            dialogueRunner.StartDialogue(nazwaDialogu);
            
        }
    }
}

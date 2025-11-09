using UnityEngine;
using Yarn.Unity;

public class Candies : MonoBehaviour
{
    public DestroyingClothes destroyingClothes;

    public DialogueRunner dialRunner;

    public GameObject[] candies;

    private bool playedPalto = false;

    public int clothesScore = 0;
    void Start()
    {
        foreach (GameObject c in candies)
        {
            c.SetActive(false);
        }
    }

    
    void Update()
    {
        if (clothesScore == 4)
        {
           foreach (GameObject c in candies)
            {
                c.SetActive(true);
            }
            if (!dialRunner.IsDialogueRunning && !playedPalto)
            {
                dialRunner.StartDialogue("_4POST");
                playedPalto=true;
            }
        }
    }
}

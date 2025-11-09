using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class DragCandy : MonoBehaviour
{
    public DialogueRunner dialogueRunner;

    private void Start()
    {
        
    }


    [SerializeField] public static int points;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bag")
        {
            Debug.Log("dodany punkt");
            points++;
        }
    }

    private void Update()
    {
        if (points == 3)
        {
            Debug.Log("wygrana");
            dialogueRunner.StartDialogue("_4POST1");
            //po skoñczeniu dialogu cut do nastepnej sceny
        }
    }


    

}



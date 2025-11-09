using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class DragCandy : MonoBehaviour
{
    public DialogueRunner dialogueRunner;
    private AudioSource audioSource;
    private bool playedEnd = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    [SerializeField] public static int points;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bag")
        {
            Debug.Log("dodany punkt");
            points++;
            audioSource.Play();
        }
    }

    private void Update()
    {
        if (points == 3)
        {
            Debug.Log("wygrana");
            
            if (!dialogueRunner.IsDialogueRunning && !playedEnd)
            {
                dialogueRunner.StartDialogue("_4POST1");
                playedEnd = true;
            }
            //po skoñczeniu dialogu cut do nastepnej sceny
        }
    }

    private void OnMouseDown()
    {
        audioSource.Play();
    }




}



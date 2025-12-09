using System.Collections;
using UnityEngine;
using Yarn.Unity;

public class RadioTuning : MonoBehaviour
{
    public GameObject radioMinigame;
    public CameraManager cameraManager;

    private AudioSource audioSource;
    public DialogueRunner dialogueRunner;

    public GameObject blackout;
    public AudioSource blackAudio;

    public Knob1 knob1;
    public Knob2 knob2;

    public bool won = false;
    void Start()
    {
        radioMinigame.SetActive(false);
        audioSource = GetComponent<AudioSource>();
        blackout.SetActive(false);
        audioSource.volume = 0f;
    }


    void Update()
    {
        
        if(knob1.Knob1isRight && !knob2.Knob2isRight || knob2.Knob2isRight && !knob1.Knob1isRight)
        {
            audioSource.volume = 0.03f;
        }
        else if (knob1.Knob1isRight && knob2.Knob2isRight)
        {
            audioSource.volume = 0.2f;
        }
        else
        {
            audioSource.volume= 0f;
        }
    }

    private void OnMouseDown()
    {
       radioMinigame.SetActive(true);
       cameraManager.canMoveCamera = false;
    }

    public void WinRadio()
    {
        won = true;
        Debug.Log("Win puszczaj muzyke maciek");
        dialogueRunner.StartDialogue("_5POSTra");
        blackout.SetActive(true);
        blackAudio.Play();
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(15);
        Application.Quit();
    }


}

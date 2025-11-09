using UnityEngine;
using Yarn.Unity;

public class RadioTuning : MonoBehaviour
{
    public GameObject radioMinigame;
    public CameraManager cameraManager;

    private AudioSource audioSource;
    public DialogueRunner dialogueRunner;

    public bool won = false;
    void Start()
    {
        radioMinigame.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }


    void Update()
    {


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
        audioSource.Play();
        dialogueRunner.StartDialogue("_5POSTra");
    }


}

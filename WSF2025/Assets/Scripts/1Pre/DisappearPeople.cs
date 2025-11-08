using System.Collections;
using UnityEngine;
using UnityEngine.Audio;
using Yarn.Unity;

public class DisappearPeople : MonoBehaviour
{
    [HideInInspector]
    public SpriteRenderer spriteRenderer;
    //poziom naszego znikania
    float alphaLevel;
    //czy couroutine isrunning, nwm bez tego robi kilka naraz
    bool isRunning = false;
    public string nazwaDialogu;
    public DialogueRunner dialogueRunner;

    private AudioSource audioSource;
    public AudioClip[] clipList;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
        alphaLevel = 1f;
    }


    void Update()
    {
        //to kontroluje przezroczystosc naszego obiektu
        spriteRenderer.color = new Color(1f, 1f, 1f, alphaLevel);

        //jesli przezroczystosc jest mniejsza lub rowna zera usun obiekt
        if (alphaLevel <= 0f)
        {
            Destroy(gameObject);
            dialogueRunner.StartDialogue(nazwaDialogu);
        }
    }


    //jak jest myszka na obiekcie to zaczyna couroutine
    private void OnMouseDown()
    {
        if (!isRunning) StartCoroutine(Wait());

        if (!audioSource.isPlaying)
        {
            audioSource.clip = clipList[Random.Range(0, clipList.Length)];
            audioSource.Play();
        }
    }

    //couroutina odpowiadajaca za powolne znikanie obiektu
    IEnumerator Wait()
    {
        isRunning = true;
        alphaLevel = alphaLevel - 0.4f;
        yield return new WaitForSeconds(0.1f);
        isRunning = false;
    }
}

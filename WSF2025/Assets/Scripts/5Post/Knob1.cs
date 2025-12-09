using System.Collections;
using UnityEngine;
using UnityEngine.Audio;

public class Knob1 : MonoBehaviour
{
    public RadioTuning radioTuning;
    public Knob2 knob2;
    public bool Knob1isRight;
    [SerializeField]private float turningPoint;
    public float turningModifier;

    private AudioSource audioSource;
    public AudioClip[] clipList;


    private SpriteRenderer spriteRenderer;
    void Start()
    {
        turningPoint = 1;
        Knob1isRight = false;
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = new UnityEngine.Color(1.0f, 1.0f, 1.0f, 0f);
    }

    
    void Update()
    {
        if (!audioSource.isPlaying && Knob1isRight == false)
        {
            audioSource.clip = clipList[Random.Range(0, clipList.Length)];
            StartCoroutine(Wait());
        }

    }

    private void OnMouseDown()
    {
        turningPoint++;
        if (!radioTuning.won)
        {
            if ((turningPoint / turningModifier) % 2 == 0)
            {
                Debug.Log(gameObject.name + " is set right.");
                Knob1isRight = true;
            }
            else
            {
                Knob1isRight = false;
            }
        }

        if (Knob1isRight && knob2.Knob2isRight)
        {
            radioTuning.WinRadio();
        }



    }

    private void OnMouseOver()
    {
        spriteRenderer.color = new UnityEngine.Color(1.0f, 1.0f, 1.0f, 0.2f);
    }

    private void OnMouseExit()
    {
        spriteRenderer.color = new UnityEngine.Color(1.0f, 1.0f, 1.0f, 0f);
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
        audioSource.Play();
    }
}

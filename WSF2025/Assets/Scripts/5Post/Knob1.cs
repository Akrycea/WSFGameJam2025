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
    void Start()
    {
        turningPoint = 1;
        Knob1isRight = false;
        audioSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        
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

        if (!audioSource.isPlaying)
        {
            audioSource.clip = clipList[Random.Range(0, clipList.Length)];
            audioSource.Play();
        }

    }
}

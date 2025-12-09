using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;
using UnityEngine.UI;

public class RadioScore : MonoBehaviour
{
    public Slider slider;
    public GameObject sliderRadia;
    public float score = 0;

    public ClerkAI ai;
    public DialogueRunner dialogueRunner;
    public string nazwaDialogu;

    public bool startRadio = false;

    void Start()
    {
        slider.maxValue = 20;
        slider.minValue = 0;
        sliderRadia.SetActive(false);
        
    }

    
    void Update()
    {
        if (score < 0)
        {
            score = 0;
        }

        if (startRadio)
        {
            score = score - Time.deltaTime / 6;
            sliderRadia.SetActive(true);

        }

        slider.value = score;
    }

    public void KnobTurned()
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

using UnityEngine;

public class Knob2 : MonoBehaviour
{
    public RadioTuning radioTuning;
    public Knob1 knob1;
    public bool Knob2isRight;
    [SerializeField] private float turningPoint;
    public float turningModifier;
    void Start()
    {
        turningPoint = 1;
        Knob2isRight = false;
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
                Knob2isRight = true;
            }
            else
            {
                Knob2isRight = false;
            }
        }

        if (Knob2isRight && knob1.Knob1isRight)
        {
            radioTuning.WinRadio();
        }
    }
}

using UnityEngine;

public class Knob1 : MonoBehaviour
{
    public RadioTuning radioTuning;
    public Knob2 knob2;
    public bool Knob1isRight;
    [SerializeField]private float turningPoint;
    public float turningModifier;
    void Start()
    {
        turningPoint = 1;
        Knob1isRight = false;
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

    }
}

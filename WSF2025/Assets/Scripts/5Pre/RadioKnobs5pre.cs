using System.Drawing;
using UnityEngine;

public class RadioKnobs5pre : MonoBehaviour
{
    public RadioScore radioScore;
    private SpriteRenderer spriteRenderer;
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = new UnityEngine.Color(1.0f, 1.0f, 1.0f, 0f);
    }

    
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        radioScore.KnobTurned();
    }

    private void OnMouseOver()
    {
        spriteRenderer.color = new UnityEngine.Color(1.0f, 1.0f, 1.0f, 0.2f);
    }

    private void OnMouseExit()
    {
        spriteRenderer.color = new UnityEngine.Color(1.0f, 1.0f, 1.0f, 0f);
    }
}

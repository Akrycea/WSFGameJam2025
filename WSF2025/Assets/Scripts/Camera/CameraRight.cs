using UnityEngine;
using UnityEngine.EventSystems;

public class CameraRight : MonoBehaviour
{
    public bool mouseRover = false;

    public CameraManager cameraManager;
    private SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = new UnityEngine.Color(1.0f, 1.0f, 1.0f, 1f);
    }
    private void OnMouseDown()
    {
        if (cameraManager.canMoveCamera)
        {
            mouseRover = true;
        }
    }


    private void OnMouseUp()
    {
        mouseRover = false;
    }

    private void OnMouseOver()
    {
        spriteRenderer.color = new UnityEngine.Color(1.0f, 1.0f, 1.0f, 0.5f);
    }

    private void OnMouseExit()
    {
        spriteRenderer.color = new UnityEngine.Color(1.0f, 1.0f, 1.0f, 1f);
    }
}

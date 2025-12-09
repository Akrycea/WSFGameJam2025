using UnityEngine;
using UnityEngine.EventSystems;

public class CameraLeft : MonoBehaviour
{
    public bool mouseLover = false;

    public CameraManager cameraManager;
    private SpriteRenderer spriteRenderer;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = new UnityEngine.Color(1.0f, 1.0f, 1.0f, 0f);
    }

    private void OnMouseDown()
    {
        if (cameraManager.canMoveCamera)
        {
            mouseLover = true;
        }
    }


    private void OnMouseUp()
    {
        mouseLover = false;
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

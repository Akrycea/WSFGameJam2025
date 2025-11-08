using UnityEngine;
using UnityEngine.EventSystems;

public class CameraLeft : MonoBehaviour
{
    public bool mouseLover = false;

    public CameraManager cameraManager;
    void Update()
    {

    }

    private void OnMouseOver()
    {
        if (cameraManager.canMoveCamera)
        {
            mouseLover = true;
        }
    }


    private void OnMouseExit()
    {
        mouseLover = false;
    }

}

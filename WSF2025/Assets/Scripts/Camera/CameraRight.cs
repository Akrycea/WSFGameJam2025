using UnityEngine;
using UnityEngine.EventSystems;

public class CameraRight : MonoBehaviour
{
    public bool mouseRover = false;

    public CameraManager cameraManager;

    void Update()
    {

    }

    private void OnMouseOver()
    {
        if (cameraManager.canMoveCamera)
        {
            mouseRover = true;
        }
    }


    private void OnMouseExit()
    {
        mouseRover = false;
    }
}

using UnityEngine;
using UnityEngine.EventSystems;

public class CameraRight : MonoBehaviour
{
    public bool mouseRover = false;

    void Update()
    {

    }

    private void OnMouseOver()
    {
        mouseRover = true;
    }


    private void OnMouseExit()
    {
        mouseRover = false;
    }
}

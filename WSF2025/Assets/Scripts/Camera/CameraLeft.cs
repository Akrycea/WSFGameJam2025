using UnityEngine;
using UnityEngine.EventSystems;

public class CameraLeft : MonoBehaviour
{
    public bool mouseLover = false;

    void Update()
    {

    }

    private void OnMouseOver()
    {
        mouseLover = true;
    }


    private void OnMouseExit()
    {
        mouseLover = false;
    }

}

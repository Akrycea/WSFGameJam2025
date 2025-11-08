using UnityEngine;

public class Dragging : MonoBehaviour
{
    //dodac pozniej ze jak upuszczasz to wraca na orginalne miejsce

    private Vector3 screenPoint;
    private Vector3 offset;

    public bool ZezwolPrzenoszenie = true;
    void OnMouseDown()
    {
        if (ZezwolPrzenoszenie == true)
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

            offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
    }


    void OnMouseDrag()
    {
        if (ZezwolPrzenoszenie == true)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);

            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
    }
}

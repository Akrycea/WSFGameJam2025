using System.Collections;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public CameraLeft CameraMovL;
    public CameraRight CameraMovR;
    public Transform targetL;
    public Transform targetR;

    public bool canMoveCamera;




    void Start()
    {
        canMoveCamera = true;
    }



    void Update()
    {
        CheckLeft();
        CheckRight();
    }

    //sprawdza czy gracz leci w lewo
    private void CheckLeft()
    {
        //scrolluj do lewej
        if (CameraMovL.mouseLover)
        {
            scrollToLeft();
        }

    }


    //sprawdza czy gracz leci w prawo
    private void CheckRight()
    {
        //scolluj do prawej
        if (CameraMovR.mouseRover)
        {
            scrollToRight();
        }

    }

    public void scrollToLeft()
    {
        transform.position = Vector3.Lerp(transform.position, targetL.position, 0.002f);
        StartCoroutine(WaitForCameraL());
    }

    public void scrollToRight()
    {
        transform.position = Vector3.Lerp(transform.position, targetR.position, 0.002f);
        StartCoroutine(WaitForCameraR());
    }

    IEnumerator WaitForCameraL()
    {
        yield return new WaitForSeconds(1);

    }

    IEnumerator WaitForCameraR()
    {
        yield return new WaitForSeconds(1);

    }
}

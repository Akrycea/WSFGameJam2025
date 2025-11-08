using UnityEngine;

public class Brick : MonoBehaviour
{
    public GameObject targetRight;

    public bool windowBroken = false;


    private bool grabbed = false;

    private Camera mainCamera;


    void Start()
    {
        mainCamera = Camera.main;

    }


    void Update()
    {
        //jesli obiekt jest klikniety to ciagnie go za myszka
        if (grabbed)
        {
            Vector2 mousepos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousepos;
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bag")
        {
            Debug.Log("włożona cegła do wora");
            targetRight.GetComponent<Transform>();
            targetRight.transform.position = new Vector3(12, -0.02f, -10);
            Destroy(gameObject);
        }
    }

    //sprawdza czy klikniety i wylacza fizyke jesli tak
    private void OnMouseDown()
    {
        grabbed = true;
        gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;

    }

    private void OnMouseUp()
    {
        grabbed = false;
        gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }

}

using System.Collections;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public GameObject targetRight;

    public bool windowBroken = false;


    private bool grabbed = false;

    private Camera mainCamera;

    private AudioSource audioSource;

    public BlackOut blackOut;


    void Start()
    {
        mainCamera = Camera.main;
        audioSource = GetComponent<AudioSource>();
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
            targetRight.transform.position = new Vector3(20, -0.02f, -10);
            //nwm czy dawać bo ten sam dźwięk szybko po sobie jest
            //audioSource.Play();
            blackOut.BlackOutStart();
            StartCoroutine(Wait());
        }
        else
        {
            audioSource.Play();
        }
    }

    //sprawdza czy klikniety i wylacza fizyke jesli tak
    private void OnMouseDown()
    {
        grabbed = true;
        gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        audioSource.Play();

    }

    private void OnMouseUp()
    {
        grabbed = false;
        gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}

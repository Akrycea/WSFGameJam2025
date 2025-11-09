using System.Collections;
using UnityEngine;

public class DestroyingClothes : MonoBehaviour
{

    public Candies candiesScript;
    private bool grabbed = false;

    private AudioSource audioSource;

    private Camera mainCamera;


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
        if (other.tag == "Floor")
        {
            Debug.Log("upad³o na ziemie i zepsu³o sie");
            candiesScript.clothesScore++;
            StartCoroutine(Wait());
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

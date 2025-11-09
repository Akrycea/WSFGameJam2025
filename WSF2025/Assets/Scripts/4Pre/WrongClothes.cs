using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class WrongClothes : MonoBehaviour
{
    public DialogueRunner dialRunner;
    public GameObject rightClothes;
    private AudioSource audioSource;
    void Start()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }

        audioSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bag")
        {
            dialRunner.StartDialogue("_4PRE1");

            dialRunner.StartDialogue("_4PRE1");

        }
    }

    private void OnMouseDown()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
            audioSource.Play();
        }
    }

}

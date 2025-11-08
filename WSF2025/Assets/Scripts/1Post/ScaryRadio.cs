using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScaryRadio : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip[] clips;
    public bool done = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        audioSource.clip = clips[1];
        audioSource.Play();
        done = true;
        StartCoroutine(Wait());
        
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        audioSource.Stop();
    }

    //IEnumerator Wait()
    //{
    //    yield return new WaitForSeconds(2);
    //    SceneManager.LoadScene("2PRE");
    //}
}

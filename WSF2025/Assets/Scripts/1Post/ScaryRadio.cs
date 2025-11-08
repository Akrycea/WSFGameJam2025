using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScaryRadio : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip[] clips;
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
        //audioSource.Stop();
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("2PRE");
    }
}

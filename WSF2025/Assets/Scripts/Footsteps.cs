using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseOver()
    {
        if (!audioSource.isPlaying)
        { 
            audioSource.Play();
        }
    }

}

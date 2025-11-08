using UnityEngine;
using UnityEngine.Audio;

public class SFXmixed : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip[] clipList;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = clipList[Random.Range(0, clipList.Length)];
            audioSource.Play();
        }
    }
}

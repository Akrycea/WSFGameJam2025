using UnityEngine;
using UnityEngine.Audio;

public class SFXmixed : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip[] clipList;
    public RadioScore radioScore;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (!audioSource.isPlaying && radioScore.startRadio)
        {
            audioSource.clip = clipList[Random.Range(0, clipList.Length)];
            audioSource.Play();
        }
    }
}

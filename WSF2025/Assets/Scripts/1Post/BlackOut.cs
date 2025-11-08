using System.Collections;
using UnityEngine;

public class BlackOut : MonoBehaviour
{
    private AudioSource audioSource;
    private SpriteRenderer spriteRenderer;
    //poziom naszego znikania
    float alphaLevel;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        alphaLevel = 0f;
    }

    
    void Update()
    {
        spriteRenderer.color = new Color(0f, 0f, 0f, alphaLevel);
    }

    public void BlackOutStart()
    {
        alphaLevel = 1f;
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        audioSource.Play();
        yield return new WaitForSeconds(2);
        alphaLevel = 0f;
    }
}

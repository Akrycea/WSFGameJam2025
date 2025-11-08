using UnityEngine;
using Yarn.Unity;
using UnityEngine.SceneManagement;
using System.Collections;

public class YarnSceneManager : MonoBehaviour
{
    public GameObject blackout;
    public GameObject OST;
    private AudioSource audioSource;
    public AudioClip[] clips;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    [YarnCommand("momChangeScene")]
    public void changeScene()
    {
        SceneManager.LoadScene("1Post");
    }

    [YarnCommand("2PREChangeScene")]
    public void changeScene2()
    {
        SceneManager.LoadScene("2POST");
    }

    [YarnCommand("2POSTChangescene")]
    public void changeScene3()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        blackout.SetActive(true);
        OST.SetActive(false);
        audioSource.Play();
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("3PRE");


    }

    [YarnCommand("ScreamSund1")]
    public void ScreamSound()
    {
        audioSource.clip = clips[0];
        audioSource.Play();
    }
    [YarnCommand("SeedSund1")]
    public void SeedSound1()
    {
        audioSource.clip = clips[1];
        audioSource.Play();
    }
    [YarnCommand("SeedSund2")]
    public void SeedSound2()
    {
        audioSource.clip = clips[2];
        audioSource.Play();
    }


}

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
    public RadioScore radioScore;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    //glos mamy
    [YarnCommand("momVoice")]
    public void momVoice()
    {
        audioSource.clip = clips[0];
        audioSource.Play();
    }
    [YarnCommand("momChangeScene")]
    public void changeScene()
    {
        SceneManager.LoadScene("1Post");
    }

    //glos holly
    [YarnCommand("hollyVoice")]
    public void hollyVoice()
    {
        audioSource.clip = clips[0];
        audioSource.Play();
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
        audioSource.clip = clips[1];
        audioSource.Play();
    }
    [YarnCommand("SeedSund1")]
    public void SeedSound1()
    {
        audioSource.clip = clips[2];
        audioSource.Play();
    }
    [YarnCommand("SeedSund2")]
    public void SeedSound2()
    {
        audioSource.clip = clips[3];
        audioSource.Play();
    }



    [YarnCommand("3PREChangeScene")]
    public void changeScene4()
    {
        SceneManager.LoadScene("3POST");
    }


    [YarnCommand("1POSTChangeScene")]
    public void changeScene5()
    {
        SceneManager.LoadScene("2PRE");
    }

    [YarnCommand("4PREangeScene")]
    public void changeScene65()
    {
        SceneManager.LoadScene("4POST");
    }

    [YarnCommand("4POSTChangeScene")]
    public void changeScene6()
    {
        SceneManager.LoadScene("5PRE");
    }

    [YarnCommand("5POSTChangeScene")]
    public void changeScene7()
    {
        SceneManager.LoadScene("5Post");
    }

    [YarnCommand("BLACKSCREEN")]
    public void blackscreen()
    {
        StartCoroutine(Wait2());
    }

    IEnumerator Wait2()
    {
        blackout.SetActive(true);
      
        yield return new WaitForSeconds(10);
        Application.Quit();


    }

    [YarnCommand("startRadio")]
    public void startRadio()
    {
        radioScore.startRadio = true;
    }



}

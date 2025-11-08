using UnityEngine;
using Yarn.Unity;
using UnityEngine.SceneManagement;
using System.Collections;

public class YarnSceneManager : MonoBehaviour
{
    public GameObject blackout;

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
        //dzwiek
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("3PRE");
    }
}

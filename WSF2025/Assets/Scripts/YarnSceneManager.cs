using UnityEngine;
using Yarn.Unity;
using UnityEngine.SceneManagement;

public class YarnSceneManager : MonoBehaviour
{
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
}

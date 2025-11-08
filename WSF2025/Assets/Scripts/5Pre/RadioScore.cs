using UnityEngine;
using UnityEngine.SceneManagement;

public class RadioScore : MonoBehaviour
{
    public float score = 0;

    public ClerkAI ai;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (score < 0)
        {
            score = 0;
        }

        score = score - Time.deltaTime/6;

    }

    private void OnMouseDown()
    {
        if (!ai.lookingAtPlayer)
        {
            score++;
            Debug.Log("score: " + score);
        }
        else
        {
            score--;
        }

        if (score > 20)
        {
            Debug.Log("win");
            SceneManager.LoadScene("5Post");
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class WrongClothes : MonoBehaviour
{
    public GameObject rightClothes;
    void Start()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    
    void Update()
    {
        if (rightClothes == null)
        {
            SceneManager.LoadScene("4POST");
        }
    }

    private void OnMouseDown()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }
    }
}

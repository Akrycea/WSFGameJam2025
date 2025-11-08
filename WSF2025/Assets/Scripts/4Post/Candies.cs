using UnityEngine;

public class Candies : MonoBehaviour
{
    public DestroyingClothes destroyingClothes;

    public GameObject[] candies;

    public int clothesScore = 0;
    void Start()
    {
        foreach (GameObject c in candies)
        {
            c.SetActive(false);
        }
    }

    
    void Update()
    {
        if (clothesScore == 1)
        {
           foreach (GameObject c in candies)
            {
                c.SetActive(true);
            }
        }
    }
}

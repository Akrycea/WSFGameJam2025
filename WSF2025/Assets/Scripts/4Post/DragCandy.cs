using UnityEngine;
using UnityEngine.SceneManagement;

public class DragCandy : MonoBehaviour
{

    private void Start()
    {
        
    }


    [SerializeField] public static int points;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bag")
        {
            Debug.Log("dodany punkt");
            points++;
        }
    }

    private void Update()
    {
        if (points == 3)
        {
            Debug.Log("wygrana");
            SceneManager.LoadScene("5PRE");
            //po skoñczeniu dialogu cut do nastepnej sceny
        }
    }
}

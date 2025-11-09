using UnityEngine;

public class ProductPoints : MonoBehaviour
{
    public GameObject shelfCollider;

    private void Start()
    {
        shelfCollider.SetActive(false);
    }


    [SerializeField]public static int points;
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
        if(points == 4)
        {
            shelfCollider.SetActive(true);
            //po skoñczeniu dialogu cut do nastepnej sceny
        }
    }

}

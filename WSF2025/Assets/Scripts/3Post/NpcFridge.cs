using UnityEngine;

public class NpcFridge : MonoBehaviour
{
    public GameObject fridge;

    private int gonePoints = 0;
    void Start()
    {
        fridge.SetActive(false);
    }

    
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        gonePoints++;

        if(gonePoints == 3)
        {
            fridge.SetActive(true);
            Destroy(gameObject);
        }
    }
}

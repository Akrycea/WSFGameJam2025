using UnityEngine;

public class Fridge : MonoBehaviour
{
    public bool fridgeDestroyed = false;
    private void OnMouseDown()
    {
        fridgeDestroyed = true;
        Destroy(gameObject);
    }


}

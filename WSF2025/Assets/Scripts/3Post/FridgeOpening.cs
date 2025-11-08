using UnityEngine;
using UnityEngine.SceneManagement;

public class FridgeOpening : MonoBehaviour
{
    public NpcFridge npc;
    public Fridge fridge;

    public SpriteRenderer fridgeSprtie;
    public Sprite[] sprites;
    public GameObject water;


    public bool waterTaken = false;
    void Start()
    {

    }

   
    void Update()
    {

        if (fridge.fridgeDestroyed)
        {
            fridgeSprtie.sprite = sprites[1];
            
        }

        if (water == null)
        {
            Debug.Log("yippie");
            SceneManager.LoadScene("4PRE");
        }
    }

}

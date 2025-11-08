using UnityEngine;

public class ClerkAI : MonoBehaviour
{
    public Sprite[] sprites;
    private SpriteRenderer spriteRenderer;

    float randomLookTimer;
    float randomBreakTimer;

    public bool lookingAtPlayer = false;


    void Start()
    {
        randomLookTimer = Random.Range(3f, 8f);  //random float between 3 and 10

        randomBreakTimer = Random.Range(3f, 13f);

        spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.sprite = sprites[0];
    }

    
    void Update()
    {
        randomLookTimer = randomLookTimer - Time.deltaTime;

        if(randomLookTimer <= 0)
        {
            lookingAtPlayer = true;
            spriteRenderer.sprite = sprites[1];
            randomBreakTimer = randomBreakTimer - Time.deltaTime;
        }
        else
        {
            lookingAtPlayer = false;
            spriteRenderer.sprite = sprites[0];
            randomBreakTimer = Random.Range(3f, 13f);
            randomLookTimer = randomLookTimer - Time.deltaTime;
        }

        if (randomBreakTimer <= 0)
        {
            randomLookTimer = Random.Range(3f, 8f);
        }

        //Debug.Log("look timer: " + randomLookTimer);
        //Debug.Log("break timer: " + randomBreakTimer);
        //Debug.Log("is looking at player? - " + lookingAtPlayer);
    }
}

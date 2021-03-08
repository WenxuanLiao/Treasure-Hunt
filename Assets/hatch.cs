using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hatch : MonoBehaviour
{
    public Text text;
    public GameObject textbox;
    public GameObject the_end;
    public static bool have_key;
    public Sprite newSprite;
    public GameObject main_char;
    private SpriteRenderer spriteRenderer;
    bool trigger;
    

    void Start()
    {
        have_key = false;
        spriteRenderer=gameObject.GetComponent<SpriteRenderer>();
        trigger = true; 
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "main_char")
        {
            if (have_key == false)
            {
                text.text = "Hatch, maybe a way for me to escape from here.";
                textbox.SetActive(true);
            }
            else
            {
                text.text = "The hatch is open. Time to get out from here";
                Destroy(main_char);
                textbox.SetActive(true);
                spriteRenderer.sprite = newSprite;
                if (trigger)
                {
                    StartCoroutine(ExampleCoroutine()); 
                }
                trigger = false;
            }
        }
    }
    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5.0f);
        the_end.SetActive(true);
 
       
       
    }
}

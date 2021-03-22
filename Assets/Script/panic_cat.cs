using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panic_cat : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite blood;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
    
      
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "monster")
        {
            GetComponent<SpriteRenderer>().sprite = blood;
            Destroy(GetComponent<show_text>());
        }
        
    }
}

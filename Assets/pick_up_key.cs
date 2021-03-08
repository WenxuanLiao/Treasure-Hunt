using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pick_up_key : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "main_char")
        {

            hatch.have_key = true;
            Destroy(gameObject);

        }

    }
}

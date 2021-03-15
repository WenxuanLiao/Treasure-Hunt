using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tunnel : MonoBehaviour
{
    public GameObject main_char;
    public GameObject t1;
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
            main_char.transform.position = t1.transform.position - new Vector3(0, 3, 0);
        }
    }
}

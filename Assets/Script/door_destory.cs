using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_destory : MonoBehaviour
{
    public GameObject door;
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
            door.SetActive(false);
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bookshelf : MonoBehaviour
{
    public Text text;
    public GameObject textbox;
    public string info;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (walking_controller.energy_level == 1)
        {
            //text.text = "";
            rb = GetComponent<Rigidbody2D>();
            //This locks the RigidBody so that it does not move or rotate in the Z axis.
            rb.mass = 1;
            //rb.constraints = RigidbodyConstraints2D.None;
            //rb.constraints =RigidbodyConstraints2D.FreezeRotation;
            //rb.constraints = RigidbodyConstraints2D.FreezePositionY;

        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "main_char" && walking_controller.energy_level==0)
        {
            text.text = info;
            textbox.SetActive(true);
        }
        else
        {

        }
    }
}

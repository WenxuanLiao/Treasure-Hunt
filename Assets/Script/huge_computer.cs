using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class huge_computer : MonoBehaviour
{
    public Text text;
    public GameObject textbox;
    public string info;
    public GameObject barrier;
    public GameObject path;
    
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (walking_controller.energy_level == 2)
        {
            //text.text = "";
            rb = GetComponent<Rigidbody2D>();
            //This locks the RigidBody so that it does not move or rotate in the Z axis.
            rb.mass = 1;
            //rb.constraints = RigidbodyConstraints2D.None;
            //rb.constraints =RigidbodyConstraints2D.FreezeRotation;
            //rb.constraints = RigidbodyConstraints2D.FreezePositionY;

        }
        if (transform.position.y>=-9.5)
        {
            rb.mass = 1000000000000000;
            Destroy(path);
            Destroy(barrier);
            Destroy(GetComponent<huge_computer>());
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "main_char" && walking_controller.energy_level <2)
        {
            text.text = info;
            textbox.SetActive(true);
        }
        else
        {

        }
    }
}


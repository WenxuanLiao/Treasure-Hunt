using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pass_word_machine : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public GameObject textbox;
    public static bool if_password;
    public GameObject door;
   

    void Start()
    {
        if_password = false;
    }

    // Update is called once per frame
    void Update()
    {
       // textbox.SetActive(false);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "main_char")
        {
            if (if_password==false) {
                text.text = "Need find password";
                textbox.SetActive(true);
            }

            else {
                text.text = "door is unlocked";
                textbox.SetActive(true);
                Destroy(door);
            }
            }
    }
}

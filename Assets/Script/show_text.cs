using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class show_text : MonoBehaviour
{
    public Text text;
    public GameObject textbox;
    public string info;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //text.text = "";
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "main_char")
        {
            text.text = info;
            textbox.SetActive(true);
        }
        else
        {

        }
    }
}

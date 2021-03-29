using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tunnel_1 : MonoBehaviour
{
    public GameObject main_char;
    public GameObject t1;
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

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "main_char" && closed_vent.vent_open == true)
        {
            main_char.transform.position = t1.transform.position - new Vector3(0, 3, 0);
            main_char.transform.position = new Vector3(main_char.transform.position.x, main_char.transform.position.y, -16.8f);
        }
        else if (other.gameObject.name == "main_char" && closed_vent.vent_open == false)
        {
            text.text = info;
            textbox.SetActive(true);
        }
    }
}

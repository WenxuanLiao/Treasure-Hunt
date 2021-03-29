using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class closed_vent : MonoBehaviour
{
    public Text text;
    public GameObject textbox;
    public string info;
    public Text text2;
    public GameObject textbox2;
    public string info2;
    public Sprite open_vent;
    SpriteRenderer spriterender;
    public static bool vent_open;
    // Start is called before the first frame update
    void Start()
    {
        spriterender = GetComponent<SpriteRenderer>();
        vent_open = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "main_char" && door_break.tool_box == false)
        {
            text.text = info;
            textbox.SetActive(true);
        }
        else if (other.gameObject.name == "main_char" && door_break.tool_box == true)
        {
            StartCoroutine(ExampleCoroutine());
            text.text = info2;
            textbox.SetActive(true);
            walking_controller.walk = 0;
        }
    }
    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(4.0f);

        vent_open = true;

        walking_controller.walk = 1;
        spriterender.sprite = open_vent;
        Destroy(GetComponent<BoxCollider2D>());
        Destroy(GetComponent<closed_vent>());
    }
}

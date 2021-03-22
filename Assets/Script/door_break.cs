using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class door_break : MonoBehaviour
{

    public Text text;
    public GameObject textbox;
    public string info;
    public string info2;
    public static bool tool_box;
    public Sprite brokendoor;
    SpriteRenderer spriterender;
    // Start is called before the first frame update
    void Start()
    {
        tool_box = false;
        spriterender = GetComponent<SpriteRenderer>();
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
            if (tool_box == false)
            {
                text.text = info;
                textbox.SetActive(true);
            }
            else {
                text.text = info2;
                textbox.SetActive(true);
                StartCoroutine(ExampleCoroutine());
                walking_controller.walk = 0;
            }
        }
       
    }
    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(3.0f);
        text.text = "";
        Destroy(GetComponent<BoxCollider2D>());
        spriterender.sprite = brokendoor;
        walking_controller.walk = 1;
       

    }
}

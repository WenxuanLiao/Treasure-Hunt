using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tool_box : MonoBehaviour
{
    // Start is called before the first frame update

    public Text text;
    public GameObject textbox;
    public string info;
    public GameObject tool;
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


            StartCoroutine(ExampleCoroutine());
            text.text = info;
            textbox.SetActive(true);
            walking_controller.walk = 0;
        }
        else
        {

        }
    }
    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(4.0f);
       
        
        tool.SetActive(true);
        walking_controller.walk = 1;
        door_break.tool_box = true;

        Destroy(gameObject);
    }
}

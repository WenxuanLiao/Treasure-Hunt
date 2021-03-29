using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class step_desk : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public GameObject textbox;
    public GameObject main_char;
    public GameObject tunnel;
    public string info;
    private bool collided;
    void Start()
    {
        collided = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.y > 22&&collided)
        {
            text.text = info;
            textbox.SetActive(true);

            walking_controller.walk = 0;
            StartCoroutine(ExampleCoroutine());
        }
       
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "main_char")
        {


            collided = true;
            

        }
        
    }
    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(3.0f);
        walking_controller.walk = 1;
        main_char.transform.position = tunnel.transform.position-new Vector3(0,3,0);
        main_char.transform.position = new Vector3(main_char.transform.position.x, main_char.transform.position.y, -16.8f);
        collided = false;
    }
}

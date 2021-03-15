using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class drink_drink : MonoBehaviour
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
        walking_controller.energy_level++;
        Destroy(gameObject);

        walking_controller.walk = 1;

    }
}

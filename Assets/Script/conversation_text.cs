using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class conversation_text : MonoBehaviour
{
    public Text text;
    public GameObject textbox;
    public string info;
    public GameObject profile;
    //public Image image;
    public Sprite rabbit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "main_char")
        {
            text.text = info;
            textbox.SetActive(true);
            profile.SetActive(true);
            profile.GetComponent<Image>().sprite = rabbit;
            walking_controller.walk = 0;
            StartCoroutine(ExampleCoroutine());
        }
    }
    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(3.0f);
        text.text = "";
   

        walking_controller.walk = 1;
        textbox.SetActive(false);
        profile.SetActive(false);
        Destroy(gameObject);

    }
}

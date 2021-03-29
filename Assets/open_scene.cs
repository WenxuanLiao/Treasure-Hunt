using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class open_scene : MonoBehaviour
{
    public Text text;
    public GameObject textbox;
 
    public GameObject profile;
    //public Image image;
    public Sprite rabbit;
    // Start is called before the first frame update
    public GameObject maincharacter;
    void Start()
    {
        text.text = "Yesterday a monster suddenly broke into this factory, it slaughtered my colleagues, I was lucky to survive because I was hiding in this lokcer";
        textbox.SetActive(true);
        profile.SetActive(true);
        profile.GetComponent<Image>().sprite = rabbit;
        walking_controller.walk = 0;
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(7.0f);
        text.text = "I've been hiding for a long time, and it looks like the monster has disappeared. It's time to figure out how to get out of here.";

        StartCoroutine(ExampleCoroutine1());
        
    }
    IEnumerator ExampleCoroutine1()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(7.0f);
        text.text = "";


        walking_controller.walk = 1;
        maincharacter.SetActive(true);
        textbox.SetActive(false);
        profile.SetActive(false);
        Destroy(gameObject);

    }
}

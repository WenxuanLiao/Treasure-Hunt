using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hatch_console : MonoBehaviour
{
    public Text text;
    public Text text2;
    public static bool hatch_open;
    public GameObject textbox;

    public GameObject textbox2;

    public Sprite newSprite;

    private SpriteRenderer spriteRenderer;
  

    public string info;
    public GameObject profile;
    //public Image image;
    public Sprite rabbit;
    // Start is called before the first frame update
    void Start()
    {

        hatch_open = false;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "main_char")
        {
            if (hatch.have_key == false)
            {
                text.text = "It looks like this machine controls the hatch down there. But I will need a key in order to use this machine.";
                textbox.SetActive(true);
            }
            else
            {

                text2.text = info;
                textbox2.SetActive(true);
                profile.SetActive(true);
                profile.GetComponent<Image>().sprite = rabbit;
                walking_controller.walk = 0;
                StartCoroutine(ExampleCoroutine());
                GetComponent<BoxCollider2D>().isTrigger = false;
            }
        }
    }
    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(3.0f);
        text2.text = "";
        spriteRenderer.sprite = newSprite;
        hatch_open = true;
        walking_controller.walk = 1;
        textbox2.SetActive(false);
        profile.SetActive(false);
        Destroy(GetComponent<hatch_console>());

    }
}

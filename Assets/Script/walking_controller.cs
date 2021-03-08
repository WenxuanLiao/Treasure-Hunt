using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class walking_controller : MonoBehaviour
{
    public float speed = 0.01f;
    Animator animator;
    //bool if_collider;
    public Text text;
    public GameObject textbox;
    public int collisions = 0;
    private SpriteRenderer mySpriteRenderer;
   

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (collisions == 0)
        {
            text.text = "";
            textbox.SetActive(false);
            // 
        }
        else {
            
        }
       

        animator.SetFloat("vspeed", 0.0f);
        animator.SetBool("stop", true);
        animator.SetFloat("hspeed", 0.0f);
        float translation_y = Input.GetAxis("Vertical") * speed;
        float translation_x = Input.GetAxis("Horizontal") * speed;
        if (translation_y > 0)
        {
            animator.SetBool("stop", false);
            animator.SetFloat("vspeed",1.0f);
        }
        else if (translation_y < 0)

        {
            animator.SetBool("stop", false);
            animator.SetFloat("vspeed", -1.0f);
        }
        else if (translation_x > 0)
        {
            animator.SetFloat("hspeed", 1.0f);
            mySpriteRenderer.flipX = false;
            animator.SetBool("stop", false);
        } else if (translation_x < 0)
        {
            animator.SetFloat("hspeed", 1.0f);
            mySpriteRenderer.flipX = true;
            animator.SetBool("stop", false);
        }
      
        
        transform.Translate(translation_x, translation_y, 0);

    }
   

    void OnCollisionEnter2D(Collision2D collision)
    {
        collisions++;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        collisions--;
    }
}

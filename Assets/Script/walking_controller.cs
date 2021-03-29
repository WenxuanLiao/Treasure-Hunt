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
    public static int energy_level;
    public GameObject textbox;
    public static int collisions = 0;
    public static int walk;
    private SpriteRenderer mySpriteRenderer;

    public static Transform teleport;

    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject D;
    public GameObject E;
    public GameObject map;

    public Transform[] values;

    // Start is called before the first frame update
    void Start()
    {
        walk = 1;
        energy_level = 0;
        animator = gameObject.GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        values = new Transform[4];
        values[0] = A.transform;
        values[1]= B.transform;
        values[2] = C.transform;
        values[3] = D.transform;
        values[4] = E.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(collisions);
        if (Input.GetKey(KeyCode.M))
        {
            map.SetActive(true);
        }
        else {
            map.SetActive(false);
        }
        if (collisions == 0)
        {
            text.text = "";
            textbox.SetActive(false);
            // 
        }
        else {

        }
       teleport= GetClosestEnemy(values);
        
        animator.SetFloat("vspeed", 0.0f);
        animator.SetBool("stop", true);
        animator.SetFloat("hspeed", 0.0f);
       
            float translation_y = Input.GetAxis("Vertical") * speed * Time.deltaTime*walk;
            float translation_x = Input.GetAxis("Horizontal") * speed * Time.deltaTime*walk;
        
       
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

    Transform GetClosestEnemy(Transform[] enemies)
    {
        Transform tMin = null;
        float minDist = Mathf.Infinity;
        Vector3 currentPos = transform.position;
        foreach (Transform t in enemies)
        {
            float dist = Vector3.Distance(t.position, currentPos);
            if (dist < minDist)
            {
                tMin = t;
                minDist = dist;
            }
        }
       // Debug.Log(tMin);
        return tMin;
 
       
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

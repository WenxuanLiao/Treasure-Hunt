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

    public Transform[] values;

    // Start is called before the first frame update
    void Start()
    {
        walk = 1;
        energy_level = 0;
        animator = gameObject.GetComponent<Animator>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();

        values[1] = A.transform;
        values[2]= B.transform;
        values[3] = C.transform;
        values[4] = D.transform;
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
        Transform bestTarget = null;
        float closestDistanceSqr = Mathf.Infinity;
        Vector3 currentPosition = transform.position;
        foreach (Transform potentialTarget in enemies)
        {
            Vector3 directionToTarget = potentialTarget.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if (dSqrToTarget < closestDistanceSqr)
            {
                closestDistanceSqr = dSqrToTarget;
                bestTarget = potentialTarget;
            }
        }

        return bestTarget;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chasing : MonoBehaviour
{
    public int speed;
    public float ray_distance;
    public GameObject player;
    private SpriteRenderer mySpriteRenderer;
    public int move_vertical;
    public GameObject the_end;
    public LayerMask barrier;


    private void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
       // Vector2 sightDist = (1,0);
    }
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position,Vector2.left,ray_distance,barrier);

        if (hit.collider != null)
        {
            
                move_vertical = 0;
                print("hit barrier");
 
            

        }
        else {
            move_vertical = 1;
            print("hit nothing");
        }

        Vector3 localPosition = player.transform.position - transform.position;
        localPosition = localPosition.normalized; // The normalized direction in LOCAL space
        transform.Translate(localPosition.x * Time.deltaTime * speed*move_vertical, localPosition.y * Time.deltaTime * speed, localPosition.z * Time.deltaTime * speed);


        //   Vector3 fwd = transform.TransformDirection(-1,0,0);
        if (player.transform.position.x < transform.position.x)
        {
            mySpriteRenderer.flipX = false;
        }
        else
        {
            mySpriteRenderer.flipX = true;
        }

        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "main_char")
        {



            Destroy(player);
            StartCoroutine(ExampleCoroutine());
        }
    }
    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5.0f);
        the_end.SetActive(true);



    }
}

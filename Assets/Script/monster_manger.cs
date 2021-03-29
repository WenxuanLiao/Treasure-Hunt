using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_manger : MonoBehaviour
{
    public GameObject monster;
    public GameObject t1;
    public GameObject player;
    bool run_once;
    bool run_once_1;
    // Start is called before the first frame update
    void Start()
    {
        run_once = true;
        run_once_1 = true;
    }

    // Update is called once per frame
    void Update()
    {
        var dist = Vector3.Distance(monster.transform.position, player.transform.position);
       // Debug.Log(dist);
        if (pass_word_machine.if_password == true && run_once_1)
        {
            monster.SetActive(true);
            chasing.mode = 0;
            run_once_1 = false;
        }
        if (hatch.have_key&& run_once)
        {

            monster.SetActive(false);
            monster.transform.position= t1.transform.position - new Vector3(0, 3, 0);
            monster.SetActive(true);
            // chasing.animator.SetTrigger("blink");
            chasing.mode = 1;
            run_once = false;
         
        }
        if (chasing.mode == 2 && dist>=20)
        {
            monster.SetActive(false);
            monster.transform.position = walking_controller.teleport.position;
            monster.SetActive(true);
            //  chasing.animator.SetTrigger("blink");
           
        }
    }
    
}

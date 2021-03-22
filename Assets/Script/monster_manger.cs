using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_manger : MonoBehaviour
{
    public GameObject monster;
    public GameObject t1;
    bool run_once;
    // Start is called before the first frame update
    void Start()
    {
        run_once = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (pass_word_machine.if_password == true)
        {
            monster.SetActive(true);
        }
        if (hatch.have_key&& run_once)
        {

            chasing.animator.SetTrigger("blink");
            monster.transform.position= t1.transform.position - new Vector3(0, 3, 0);
            chasing.mode = 1;
            run_once = false;
         
        }
        if (chasing.mode == 2)
        {
            chasing.animator.SetTrigger("blink");
            monster.transform.position = walking_controller.teleport.position;
            
            run_once = false;
        }
    }
    
}

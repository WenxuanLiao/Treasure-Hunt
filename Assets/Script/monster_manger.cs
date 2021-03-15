using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_manger : MonoBehaviour
{
    public GameObject monster;
    public GameObject t1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pass_word_machine.if_password == true)
        {
            monster.SetActive(true);
        }
        if (hatch.have_key == true)
        {
            monster.SetActive(false);
            monster.transform.position= t1.transform.position - new Vector3(0, 3, 0); 
            monster.SetActive(true);
        }
    }
}

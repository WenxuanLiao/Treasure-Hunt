﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class password_founder : MonoBehaviour
{
    public Text text;
    public GameObject textbox;
    public string info;
    public GameObject profile;
    public GameObject password;
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

    void OnCollisionEnter2D(Collision2D other)
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
        
        pass_word_machine.if_password = true;
        walking_controller.walk = 1;
        textbox.SetActive(false);
        profile.SetActive(false);
        password.SetActive(true);
        Destroy(GetComponent<password_founder>());

    }
}

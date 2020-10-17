using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingState : MonoBehaviour
{
	Animator anima;
    //public AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        anima = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            anima.SetTrigger("celebrate");
            //sound = gameObject.GetComponent<AudioSource>();
            //sound.Play();
        }
        //if (Input.GetKeyDown(KeyCode.F)) anima.SetTrigger("fightsomething");
    }
}


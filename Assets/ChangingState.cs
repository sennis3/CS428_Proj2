using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingState : MonoBehaviour
{
	Animator anima;

    // Start is called before the first frame update
    void Start()
    {
        anima = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) anima.SetTrigger("celebrate");
        //if (Input.GetKeyDown(KeyCode.F)) anima.SetTrigger("fightsomething");
    }
}


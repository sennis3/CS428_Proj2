using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 

public class VBScript : MonoBehaviour
{
    public GameObject vbBtnObj;
    public AudioSource audiosrc;
    public Animator anima;

    // Start is called before the first frame update
    void Start()
    {
        //vbBtnObj = GameObject.Find("VirtualButton");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        audiosrc.GetComponent<AudioSource>();
        //anima = GetComponent<Animator>();
    }

public void OnButtonPressed(VirtualButtonBehaviour vb)
{
         Debug.Log("Button pressed");
         anima.SetTrigger("celebrate");
         audiosrc.Play();
}
public void OnButtonReleased(VirtualButtonBehaviour vb)
{
         Debug.Log("Button released");
}

    // Update is called once per frame
    void Update()
    {
    }
}
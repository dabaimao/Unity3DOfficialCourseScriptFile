using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biker : MonoBehaviour
{
    private int speed=4;
    private Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxisRaw("Vertical");
        anim.SetInteger("Vertical", (int)v);
        if (v > 0)
        {
            transform.Translate(Vector3.forward*Time.deltaTime*speed);
        }
        else if(v<0)
        {
            transform.Translate(Vector3.back*Time.deltaTime*speed);
        }


    }
}

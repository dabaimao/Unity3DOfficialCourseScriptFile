using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator anim;
    private int speedID = Animator.StringToHash("Speed");
    private int isSpeedUpID = Animator.StringToHash("IsSpeedUp");
    private int HorizontalID = Animator.StringToHash("Horizontal");
	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        anim.SetFloat(speedID, Input.GetAxis("Vertical"));
        anim.SetFloat(HorizontalID, Input.GetAxis("Horizontal"));
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            anim.SetBool(isSpeedUpID, true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            anim.SetBool(isSpeedUpID, false);
        }
	}
}

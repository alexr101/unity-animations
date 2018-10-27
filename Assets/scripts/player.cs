using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");

        anim.SetFloat("inputH", inputH);
        anim.SetFloat("inputV", inputV);

        bool jumping = Input.GetKey(KeyCode.Space);
        anim.SetBool("jumping", jumping);


        if(Input.GetKeyDown("1")) {
            anim.Play("WAIT01", 0, 0f);
        }
        if (Input.GetKeyDown("2"))
        {
            anim.Play("WAIT02", 0, 0f);
        }
        if (Input.GetKeyDown("3"))
        {
            anim.Play("WAIT03", 0, 0f);
        }
        if (Input.GetKeyDown("4"))
        {
            anim.Play("WAIT04", 0, 0f);
        }

        if (Input.GetMouseButtonDown(0))
        {
            int random = Random.Range(0, 2);
            if(random == 0)
                anim.Play("DAMAGED00", 0, 0f);
            else if (random == 1)
                anim.Play("DAMAGED01", 0, 0f);

        }

	}
}

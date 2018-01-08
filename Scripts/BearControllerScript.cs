using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float speed = 20f;
    public float jumpPower = 40f;

    public bool grounded;

    private Rigidbody2D rb2d;


	void Start () {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
	}
	
	
	void FixedUpdate ()
    {

        float h = Input.GetAxis("Horizontal");

        rb2d.AddForce((Vector2.right * speed) * h);

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundcheck : MonoBehaviour
{
    private BearController player;

    void Start()
    {
        player = gameObject.GetComponentInParent<BearController>();
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        player.grounded = true;
    }


    void OnTriggerExit2D(Collider2D col)
    {
        player.grounded = false;
    }



}
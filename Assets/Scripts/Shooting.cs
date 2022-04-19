using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        transform.Translate(transform.right*transform.localScale.x* speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            return;
        
        // trigger custom
         if (collision.GetComponent<Shootingact>())
             collision.GetComponent<Shootingact>().Action();
        
        //destroy
        Destroy(gameObject);
    }
}

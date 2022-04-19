using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{

    Vector2 lookDirection;
    float lookAngle;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //calculates the mouse position no matter the direction
    lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;  //position of mouse
    
    //turns the object towards the mouse
    //thus leaving the object to rotate
    lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
    this.transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);//only Z axis is being transformed
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{

    private BoxCollider2D collider;
    private Vector3 moveDelta;
    public float speed = 10f;

    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        
        moveDelta = new Vector3(x, y, 0 );
        
        //sprite rotation 
        if (moveDelta.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }else if (moveDelta.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        
        //movement
        
        transform.Translate(moveDelta * Time.deltaTime * speed);
        
    }
}

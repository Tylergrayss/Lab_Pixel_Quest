using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class GeoController : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed ;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    // Update is called once per frame
    void Update()
    {
        //rb.velocity = Vector2.left;
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);

        /*
        if (Input.GetKeyDown(KeyCode.A))
        {
            
            rb.velocity = new Vector2(-1, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(1, rb.velocity.y);

        }
        
      */
    }
    private void OnTriggerEnter2D(Collider2D colision)
    {
        Debug.Log("Hit");
    }
   
}

using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.AI;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed;
    public string nextLevel = "Scene_2";
    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();    
    }



    // Update is called once per frame
    void Update()
    {
        //rb.velocity = Vector2.left
    
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
     

        /*if (Input.GetKeyDown(KeyCode.A))
        {

            rb.velocity = new Vector2(-1, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(1, rb.velocity.y);
        }

      */
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            sr.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            sr.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            sr.color = Color.red;
        }
    }
    private void OnTriggerEnter2D(Collider2D collison)
    {
        Debug.Log("Hit");
        switch (collison.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager .LoadScene(thisLevel);
                    break;
                }
            case "Finish":
                {
                    Debug.Log("PlayerHasDied");
                    SceneManager.LoadScene(nextLevel);
                    break;
                }

        }
    }
}



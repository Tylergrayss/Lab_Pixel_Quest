using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float CapsuleHeight = 0.25f;
    public float CapsuleRadius = 0.08f;

    // Ground Check
    public Transform feetCollider;
    public LayerMask groundMask;
    private bool _groundCheck;
    private float fullforce ;
    private Vector2 gravityForce;
    // Jump settings
    public float jumpForce = 10f;
    public Rigidbody2D rb;
    private bool _waterCheck;
    private string _waterTag = "Water";

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gravityForce = new Vector2 (0f, Physics2D.gravity.y);
    }

    void Update()
    {
        _groundCheck = Physics2D.OverlapCapsule(feetCollider.position,
            new Vector2(CapsuleHeight, CapsuleRadius), CapsuleDirection2D.Horizontal, 0f, groundMask);
        Debug.Log(_groundCheck);
        if (Input.GetKeyDown(KeyCode.Space) && _groundCheck)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(_waterTag))
        {
            _waterCheck = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(_waterTag))
        {
            _waterCheck = false;
        }
    }
}




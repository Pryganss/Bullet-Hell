using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Dead respawn;

    public float moveSpeed = 1f;
    public Rigidbody2D rb;

    public SpriteRenderer sr;

    public ParticleSystem ps;

    Vector2 movement;

    void Update() 
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void OnCollisionEnter2D(Collision2D col) 
    {  
        if (col.gameObject.tag == "die")
        { 
        respawn.enabled = true;
        var em = ps.emission;
        em.enabled = true;
        ps.Play();
        Destroy(sr);
        Destroy(this);
        }
    }

}

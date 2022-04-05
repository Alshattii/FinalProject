using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    Rigidbody2D RB;
    public float speed;
    public float jump;
    bool canjump;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            canjump = true;
        }
    }
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            canjump = false;
        }
    }
        // Start is called before the first frame update
        void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        RB.velocity = new Vector2(speed * Input.GetAxis("Horizontal"), RB.velocity.y);
        if (Input.GetButtonDown("Jump") && canjump == true) 
        {
            RB.AddForce(new Vector2(RB.velocity.x, jump));
            
        }
    }
}

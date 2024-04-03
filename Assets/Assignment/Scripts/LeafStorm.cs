using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafStorm : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    private Vector2 velocity;
    void Start()
    {
       rb = gameObject.GetComponent<Rigidbody2D>();
        velocity = new Vector2(-5f,0f);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + velocity * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}

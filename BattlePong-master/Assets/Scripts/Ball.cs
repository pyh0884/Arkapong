using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    GameManager GM;
    public Vector2 speed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        GM = FindObjectOfType<GameManager>();
        transform.localScale = new Vector3(GM.ballScale, GM.ballScale, 1f);
        transform.position = Vector3.zero;
        SetRandomVelocity();
    }


    /*public void reflect(GameObject block)
    {
        Vector3 dir = block.transform.position - transform.position;
        dir.Normalize();
        bool reflectionY = (Mathf.Abs(dir.x) < Mathf.Abs(dir.y)) ? true : false;
        if (reflectionY)
        {
            rb.velocity = new Vector2(rb.velocity.x, -(rb.velocity.y - block.GetComponent<Rigidbody2D>().velocity.y));
        }
        else
            rb.velocity = new Vector2(-rb.velocity.x, rb.velocity.y);

    }*/

    void testBounds()
    {
        if (transform.position.x < -GM.WIDTH / 2 || transform.position.x > GM.WIDTH / 2)
        {
            transform.position = new Vector2(transform.position.x - Mathf.Sign(transform.position.x)*0.1f, transform.position.y);
            rb.velocity = new Vector2(-rb.velocity.x, rb.velocity.y);
        }
            
        if (transform.position.y < -GM.HEIGHT / 2 || transform.position.y > GM.HEIGHT / 2)
        {
            rb.velocity = new Vector2(rb.velocity.x, -rb.velocity.y);
            transform.position = new Vector2(transform.position.x, transform.position.y - Mathf.Sign(transform.position.y)*0.1f);
        }
            
    }

    void SetRandomVelocity()
    {
        float tempAngle = Random.Range(Mathf.Deg2Rad * 40f, Mathf.Deg2Rad * 60f);
        int temp = (int)Random.Range(0, 2);
        Vector2 dir = new Vector2((temp == 0 ? 1 : -1) * Mathf.Cos(tempAngle), Mathf.Sin(tempAngle));
        rb.velocity = dir * GM.ballVelocity;
    }

    public void SetParticularVelocity(Vector2 dir)
    {
        dir.Normalize();
        dir *= GM.ballVelocity;
        rb.velocity = dir;
    }

    private void Update() {
        testBounds();
        if (rb.velocity.x <= 2 && rb.velocity.x >= -2) 
        {
            if (rb.velocity.x > 0)
                rb.velocity = new Vector2(rb.velocity.x + 8, rb.velocity.y);
            else
                rb.velocity = new Vector2(rb.velocity.x - 8, rb.velocity.y);
        }
        if (rb.velocity.y <= 2 && rb.velocity.y >= -2)
        {
            if (rb.velocity.y > 0)
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y+5);
            else
                rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y-5);
        }
        speed = rb.velocity;
    }
}

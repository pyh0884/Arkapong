using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBlocks : MonoBehaviour
{
    Collider2D blocksCollider;

    private void Awake() {
        blocksCollider = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject obj = collision.gameObject;
        if (obj.GetComponent<Ball>() != null)
        {
            //obj.GetComponent<Ball>().reflect(gameObject);
            Destroy(gameObject);
        }
    }

}

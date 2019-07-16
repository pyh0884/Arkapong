using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBlocks : MonoBehaviour
{
    Collider2D blocksCollider;

    private void Awake() {
        blocksCollider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        GameObject obj = other.gameObject;
        if(obj.GetComponent<Ball>() != null)
        {
            obj.GetComponent<Ball>().reflect(gameObject);
            Destroy(gameObject);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBlocks : Blocks
{
    public Vector2[] dirs;

    public override void DestroyThis()
    {
        destroying = true;
        GetComponent<BoxCollider2D>().enabled = false;
        foreach (var dir in dirs)
        {
            Ball newBall = Instantiate(Resources.Load("ball"), transform.position, Quaternion.identity) as Ball;
            newBall.SetParticularVelocity(dir);
        }
        Destroy(this);
    }
}

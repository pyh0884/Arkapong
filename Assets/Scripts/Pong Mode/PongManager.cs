using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongManager : MonoBehaviour
{
    public static PongManager instance;

    public int health;

    public float timeCount;

    Bound leftBound, rightBound;

    //public int 

    private void Awake()
    {
        instance = this;
    }

    public void GameEnd(bool right)
    {
        if (right)
            Debug.Log("Right win");
        else
            Debug.Log("Left win");
    }

    IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(timeCount);
        GameEnd(leftBound.score > rightBound.score ? false : true);
    }

}

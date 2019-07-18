using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PongManager : ModeManager
{
    public static PongManager instance;

    float timer;

    public float timeCount;

    Bound leftBound, rightBound;

    Text timerText;

    //public int 


    private void Start() {
        instance = this;
        timer = timeCount;
    }

    public void GameEnd(bool right)
    {
        SetWin(right);
    }

    IEnumerator StartTimer()
    {
        while(timer > 0)
        {
            timerText.text = "" + (int)timer--;
            yield return new WaitForSeconds(1f);
        }
        GameEnd(leftBound.score > rightBound.score ? false : true);
    }

}

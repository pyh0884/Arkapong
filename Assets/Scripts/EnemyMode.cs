using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMode : ModeManager
{

    public void CheckPlayer()
    {
        int num = player1.transform.Find("Blocks").transform.childCount;
        if(num == 0)
            SetWin(false);
        num = player2.transform.Find("Blocks").transform.childCount;
        if(num == 0)
            SetWin(true);
            
    }
    
    private void FixedUpdate() {
        CheckPlayer();
    }
}

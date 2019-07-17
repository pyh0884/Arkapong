using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBlocks : Blocks
{
    public override void DestroyThis()
    {
        if(destroying)
        {
            Destroy(this);
        }
        else
        {
            destroying = true;
            Shield();
        }
    }

    void Shield()
    {
        
    }
}

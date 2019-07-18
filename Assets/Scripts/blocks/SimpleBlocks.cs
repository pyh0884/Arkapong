using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBlocks : Blocks
{
    private void OnDestroy() {
        Instantiate(Resources.Load("BreakEffect"),transform.position,Quaternion.identity);
    }

}

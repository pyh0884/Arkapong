using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBlocks : Blocks
{

    public override void DestroyThis(){ //子类无需再写OnCollision,不同砖块可重写被撞击后的代码
        if(destroying)
            return;
        destroying = true;
        Instantiate(Resources.Load("BreakEffect"),transform.position,Quaternion.identity);
        Destroy(gameObject);
    }

}

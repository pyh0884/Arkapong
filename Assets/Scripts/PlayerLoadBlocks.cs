using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoadBlocks : MonoBehaviour
{
    GameManager GM;
    
    float height;
    float width;
    float posX;

    public bool right;

    /*void loadBlocksAtPoint(Vector2 pos)
    {
        //Debug.Log(pos);
        pos.x += 0.5f;
        pos.y -= 0.5f;
        GameObject childTemp = Instantiate(Resources.Load("BasicBlock"), new Vector3(pos.x, pos.y, 0f) + transform.position, Quaternion.identity) as GameObject;
        childTemp.transform.parent = gameObject.transform;
    }

    void loadBlocks()
    {
        Vector2 pos = new Vector2(-width / 2, height / 2);
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                loadBlocksAtPoint(pos);
                pos += Vector2.right;
            }
            pos.x = -width/2;
            pos += Vector2.down;
        }
    }*/

    private void Awake()
    {
        GM = FindObjectOfType<GameManager>();
        height = GM.PlayerSize.y;
        width = GM.PlayerSize.x;

        posX = GM.PlayerPos;
        //transform.position = new Vector2(right ? posX : -posX, 0);

        //loadBlocks();

    }
   
}

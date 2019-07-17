using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    float widthBound,heightBound;


    public float PlayerVelocity;
    public float ballVelocity;
    public float ballScale=1;


    public Vector2 PlayerSize;
    public float PlayerPos;
    

    public float WIDTH{
        get{
            return widthBound;
        }
    }

    public float HEIGHT{
        get{
            return heightBound;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

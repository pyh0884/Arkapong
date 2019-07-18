﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Vector2[] blendTree = {Vector2.up, Vector2.left, Vector2.down, Vector2.right};

    [Header("Size of play ground")]
    [SerializeField]
    float widthBound,heightBound;


    [Header("Velocity")]
    public float PlayerVelocity;
    public float ballVelocity;

    [Header("Size")]
    public float ballScale=1;
    public Vector2 PlayerSize;
    public float PlayerPos;

    [Header("SpecialBlocks")]
    public float MagnitudeSize;
    public float MagnitudeForce;
    public float ExplodeRadius;
    
    
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

    private void Awake() {
        if(instance == null)
            instance = this;
        DontDestroyOnLoad(gameObject);
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

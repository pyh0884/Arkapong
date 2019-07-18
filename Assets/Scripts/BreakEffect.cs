using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakEffect : MonoBehaviour
{
    public void EndEffect()
    {
        Debug.Log("end");
        //DestroyImmediate(this);
        gameObject.SetActive(false);
    }
}

using UnityEngine;
using System.Collections.Generic;
public class FunctionMemoryController : MonoBehaviour/*功能存储控制器*/
{
    public static List<int> functionKind = new List<int>();//砖块的功能

    private void Start()
    {
        DontDestroyOnLoad(gameObject);//设定不随场景销毁
    }

    //private void Update()
    //{
    //    for (int i = 0; i < functionKind.Count; i++)
    //    {
    //        Debug.Log(i + " " + (CheckBoxController.FunctionKind)functionKind[i]);
    //    }
    //}
}
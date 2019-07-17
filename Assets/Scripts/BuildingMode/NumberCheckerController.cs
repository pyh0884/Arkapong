using UnityEngine;
public class NumberCheckerController : MonoBehaviour/*数量检查器控制器*/
{
    public int[] remainedNumber;//砖块剩余数量

    private void Update()//每帧更新的部分
    {
        if (InstantiateController.confirm)//如果确认了砖块的放置
        {
            if (remainedNumber[(int)CheckBoxController.currentFunction] != 0)//如果砖块的数量没有到0
            {
                remainedNumber[(int)CheckBoxController.currentFunction]--;//砖块的数量自减
            }
        }

        /*测试用*/
        for (int i = 0; i < remainedNumber.Length; i++)
        {
            Debug.Log("Function " + (CheckBoxController.FunctionKind)i + ": "+remainedNumber[i]);
        }
    }
}
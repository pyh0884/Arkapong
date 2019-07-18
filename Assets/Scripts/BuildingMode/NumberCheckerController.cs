using UnityEngine;
public class NumberCheckerController : MonoBehaviour/*数量检查器控制器*/
{
    public int[] remainedNumber;//砖块剩余数量
    public GameObject[] numberPosition;//数量显示的位置

    private void Update()//每帧更新的部分
    {
        if (InstantiateController.confirm)//如果确认了砖块的放置
        {
            if (remainedNumber[(int)CheckBoxController.currentFunction] != 0)//如果砖块的数量没有到0
            {
                remainedNumber[(int)CheckBoxController.currentFunction]--;//砖块的数量自减
            }

            switch (remainedNumber[(int)CheckBoxController.currentFunction])//查看剩余数量并替换相关图片
            {
                case 3://还剩3个
                    numberPosition[(int)CheckBoxController.currentFunction].GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("BuildingMode/3");
                    break;
                case 2://还剩2个
                    numberPosition[(int)CheckBoxController.currentFunction].GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("BuildingMode/2");
                    break;
                case 1://还剩1个
                    numberPosition[(int)CheckBoxController.currentFunction].GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("BuildingMode/1");
                    break;
                case 0://还剩0个
                    numberPosition[(int)CheckBoxController.currentFunction].GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("BuildingMode/0");
                    break;
            }
        }
    }
}
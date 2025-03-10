using UnityEngine;
using Rondo.Tools;
namespace Inferno_Class_15
{
    /// <summary>
    /// 介面
    /// 
    /// </summary>
    public class Class_15_Interface : MonoBehaviour
    {
        public object inventoryFirst;
        private void Awake()
        {
            int random = Random.Range(0, 3);    // 隨機0~3 (但是不會出現右邊那個數字，也就是3)
            Logsystem.LogWithColor($"隨機:{random}", "#f33");

            if (random == 0) inventoryFirst = new Prop();
            if (random == 1) inventoryFirst = new Equipment();
            if (random == 2) inventoryFirst = new Map();
        }

        private void Update()
        {
            //按下數字鍵 1 可以使用第一個道具
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                //如果第一格是道具，就使用道具
                if (inventoryFirst is Prop) ((Prop)inventoryFirst).Use();

                //如果第一格是裝備，就使用裝備
                else if (inventoryFirst is Equipment) ((Equipment)inventoryFirst).Use();

               //如果第一格是地圖，就使用地圖
                else if (inventoryFirst is Map) ((Map)inventoryFirst).Use();

                // 結論 : 只有三個物品 就要寫出三個判斷式
                //        所以當遊戲的物品種類繁多的時候，這邊要寫的東西是很多的。
            }
        }


    }
    

    #region 類別
    public class Prop
    {
        public void Use()
        {
            Logsystem.LogWithColor("使用道具，神性+1", "#f96");
        }
    }
    public class Equipment
    {
        public void Use()
        {
            Logsystem.LogWithColor("使用裝備，裝備武器", "#9f6");          
        }
    }
    public class Map
    {
        public void Use()
        {
            Logsystem.LogWithColor("使用地圖，識圖能力提升", "#96f");
        }
    }
    #endregion
}


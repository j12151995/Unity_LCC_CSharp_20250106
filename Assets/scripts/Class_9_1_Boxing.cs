using Rondo.Tools;
using UnityEngine;
namespace Inferno
{
    /// <summary>
    ///  裝箱 Boxing 與拆箱 Unboxing
    /// </summary>
    public class Class_9_1_Boxing : MonoBehaviour 

    {
        // 實質型別的資料類型
        // 結構、列舉、整數、浮點數、布林值、字元
        // 實質型別的資料會儲存在 Stack 記憶體內
        private int number = 100;

        // 物件資料類型為參考型別 (儲存在 Heap 記憶體內)
        private object box;

        //準備拆箱
        private object boxNumber = 50;
        private int count;
        private void Awake()
        {
            //裝箱動作
            //將實質型別資料放在參考型別資料內
            box = number;
            Logsystem.LogWithColor(box.ToString(), "#f33");

            //拆箱動作  Unboxing
            //將參考型別資料放在實質型別資料內
            // 在前方添加 (要轉換的資料類型)

            //count = boxNumber;   <--在前面沒添加要轉換的資料類型 就會顯示錯誤
            count = (int)boxNumber;
            Logsystem.LogWithColor(count.ToString(), "#f33");


        }
    }

}

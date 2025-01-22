using UnityEngine;

namespace Inferno
{
    /// <summary>
    /// 列舉 : enumernation，C# 內關鍵字為簡寫 enum
    /// </summary>

    public class Class_5_2_Enumernation : MonoBehaviour
    {
        #region 認識列舉基本用法
        // 列舉 : 定義下拉選單的選項(通常都是單選)
        // 語法 :
        // 修飾詞 關鍵字 enum 列舉名稱 {列舉選項}
        // 定義一個列舉，名稱叫做季節
        // 列舉都是數值，預設從0開始 例如 春夏秋冬 就是 0123
        private enum Season
        {
            // 定義列舉的選項
            Spring, Summer, Autumn, Winter, Fucker
        }

        //宣告變數，類行為季節列舉，預設值為夏天
        [SerializeField, Header("季節")]
        private Season season = Season.Summer;

        private void Awake()
        {
            //取得列舉的值(Get) 抓出值
            Debug.Log(season);
            //取得列舉的整數值
            Debug.Log((int)season);

            //設定列舉的值(Set) 修改值
            season = Season.Winter;
            Debug.Log(season);
            //透過數值設定列舉
            season = (Season)4;
            Debug.Log(season);
        }
        #endregion

        //定義列舉的數值
        /// <summary>
        /// 道具
        /// </summary>
        private enum Item
        {
            //列舉如果不寫數字 就是預設 0123
            //後面的單位要比前面的單位還大
            None = 0, Coin = 5, RedPotion = 10, BluePotion = 20, Dick = 69
        }
        [SerializeField, Header("道具")]
        private Item item = Item.Dick;

        //執行順序 : Awake > Start > Update
        //開始事件 : 在喚醒事件後執行一次 (初始化)
        private void Start()
        {
            Debug.Log((int)item);
        }

    }
}






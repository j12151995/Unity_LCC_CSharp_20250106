using UnityEngine;

namespace Inferno
{
    /// <summary>
    /// 陣列 Array
    /// </summary>

    public class Class_6_2_Array : MonoBehaviour
    {

        private int[][] numbers = new int[2][];
        private int[][,] count = new int[2][,];

        #region 一維陣列
        //這是不使用陣列的寫法 :
        // 小火龍、傑尼龜、妙蛙種子
        public string card1 = "小火龍", card2 = "傑尼龜", card3 = "妙蛙種子";


        //這裡是使用陣列的寫法 :
        // 陣列:用來儲存多筆相同類型的資料
        // 第一種寫法 : 不指定值，透過Unity的面板輸入
        // 修飾詞 資料類型 [] 陣列名稱;
        public string[] cards;
        // 第二種寫法 : 直接定義陣列的數量
        // 意思是 定義一個牌組1，可以放五張卡牌
        public string[] deck1 = new string[5];
        //第三種寫法 : 直接定義陣列的值
        public string[] deck2 = { "噴火龍", "水箭龜", "妙蛙花" };
        #endregion

        private void Start()
        {
            #region 一~三維陣列
            // 存取陣列 Set、Get
            // Get 取得陣列的資料
            // 語法 : 陣列名稱 [編號]
            Debug.Log($"<color=#f32>Cards 的第三張卡片 : {cards[2]}</color>");

            // 因為沒有CARDS[3] 超出陣列範圍，會導致錯誤
            // 錯誤會導致當機、閃退、不符合預期的結果或者不執行下方程式
            //Debug.Log($"<color=#f32>Cards 的第三張卡片 : {cards[3]}</color>");

            // Set 設定陣列的資料
            // 語法 : 陣列名稱[編號] 指令值;
            deck2[2] = "水君";
            Debug.Log($"<color=#f32>deck2 的第三張卡片 : {deck2[2]}</color>");
            #endregion

            //不規則陣列 : 基本練習
            numbers[0] = new int[] { 1, 3, 5 };
            numbers[1] = new int[] { 6, 9 };

            //取得數字 3 與 9
            Debug.Log($"<Color=#3ff>不規則陣列的數字 3 : {numbers[0][1]}</color>");
            Debug.Log($"<Color=#3ff>不規則陣列的數字 9 : {numbers[1][1]}</color>");

            //將6改成9
            numbers[1][0] = 9;
            Debug.Log($"<Color=#3ff>第二列第一個  : {numbers[1][0]}</color>");


            //不規則陣列練習:包含多維陣列
            count[0] = new int[,] { { 3, 0 }, { 6, 7 } };
            count[1] = new int[,] { { 1, 5, 9 }, { 7, 5, 3 } };
            Debug.Log($"<Color=#3ff>第二列的[0,0]  : {count[1][0,0]}</color>");




        }

    }
}




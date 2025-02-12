using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace Inferno
{
/// <summary>
///  靜態 Static
/// </summary>


    public class Class_7_2_Static : MonoBehaviour
    {
        //非靜態變數
        public int inventoryWater = 10;
        //靜態變數 : 修飾詞後面添加關鍵字 Static
        //靜態變數不顯示在屬性面板上
        public static int inventoryProp = 20;


        //非靜態屬性
        public string skillMain => "火球術";
        //靜態屬性
        public static string skillSecond => "祕法強化"; 


        private void Awake()
        {
            //inventoryWater = 7;
            //inventoryProp = 15;
            Debug.Log($"<color=#f31>藥水 : {inventoryWater}</color>");
            Debug.Log($"<color=#f31>戰鬥道具 : {inventoryProp}</color>");


            

        }

        public void Punch()
        {
            Debug.Log($"<color=#3f3>使用拳擊</color>");

        }

        public static void Kick()
        {
            Debug.Log($"<color=#3f3>使用踢擊</color>");
        }

        private void Start()
        {
            
            //在 Unity內的差異
            //場景切換時
            //非靜態成員會被釋放(還原成預設值的意思)
            inventoryWater++; //藥水加一    的意思
            Debug.Log($"<color=#1f1>藥水 : {inventoryWater}</color>");
            //靜態成員不會被釋放(不會還原成預設值的意思)
            inventoryProp++;  //道具加一    的意思
            Debug.Log($"<color=#1f1>戰鬥道具 : {inventoryProp}</color>");
        }

        public void Update()
        {
            //在Game 畫面按下數字 1 會重新載入場景(記得切換成英文輸入法)
            //---以下翻譯---
            //如果按下數字1(左邊鍵盤的"ㄅ"鍵)
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                SceneManager.LoadScene("課程_7_屬性與靜態");
            }


        }
    }
}

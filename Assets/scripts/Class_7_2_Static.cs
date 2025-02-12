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

        private float attack = 10;
        private static float mp = 100;

        private void Awake()
        {
            //inventoryWater = 7;
            //inventoryProp = 15;
            Debug.Log($"<color=#f31>藥水 : {inventoryWater}</color>");
            Debug.Log($"<color=#f31>戰鬥道具 : {inventoryProp}</color>");


            

        }

        public void Punch()
        {
            Debug.Log($"<color=#3f3>非靜態方法使用拳擊</color>");
            //非靜態方法內可以存取所有成員 (包含靜態的 跟非靜態的)
            Debug.Log($"<color=#f9e>非靜態攻擊力 : {attack}</color>");
            Debug.Log($"<color=#f9e>靜態魔力 : {mp}</color>");

        }

        public static void Kick()
        {
            Debug.Log($"<color=#3f3>靜態方法 : 使用踢擊</color>");
            //靜態方法內只能夠存取靜態的成員
            //由於attack 是非靜態所以無法存取(會有錯誤)
           // Debug.Log($"<color=#f9e>非靜態攻擊力 : {attack}</color>");   <----錯誤
            Debug.Log($"<color=#f9e>靜態魔力 : {mp}</color>");      // <----MP是靜態的所以可以存取
           

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

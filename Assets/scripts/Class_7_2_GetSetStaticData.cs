using UnityEngine;
namespace Inferno
{

    /// <summary>
    /// 練習取得與設定靜態資料
    /// </summary>
    public class Class_7_2_GetSetStaticData : MonoBehaviour
    {
        //取得非靜態資料(成員)
        //1. 先定義要獲得資料類別的變數
        //2. 透過變數取得非靜態資料(成員)


        public Class_7_2_Static class_7_2;

        private void Awake()
        { 
            //取得非靜態變數
            //變數名稱.非靜態成員
            Debug.Log($"<color=#f3d>非靜態成員 : {class_7_2.inventoryWater}</color>");
            
            //取得非靜態屬性
            Debug.Log($"<color=#3f3>非靜態屬性 : {class_7_2.skillMain}</color>");
            //呼叫非靜態方法
            class_7_2.Punch();
           
            //取得靜態資料(成員)
            //類別名稱.靜態成員
            Debug.Log($"<color=#f3d>靜態成員 : {Class_7_2_Static.inventoryProp}</color>");
            //取得靜態屬性



        }

        public Class_7_2_slime slimeGreen, slimePurple;

        private void Start()
        {
            //非靜態成員  (擁有個別數值 可以個別存取)
            slimeGreen.hp -= 10;
            Debug.Log($"<color=#3f3>綠水靈 Hp : {slimeGreen.hp}</color>");
            slimePurple.hp -= 10;
            Debug.Log($"<color=#3f3>惡魔水靈 Hp : {slimePurple.hp}</color>");

            //靜態成員
            //靜態成員沒有辦法透過個體存取
            // slimeGreen.moveSpeed = 3.5f;   <---會顯示錯誤
            Class_7_2_slime.moveSpeed = 3.5f;
            Debug.Log($"<color=#3f3>史萊姆移動速度 : {Class_7_2_slime.moveSpeed}</color>");

        }

    }
}


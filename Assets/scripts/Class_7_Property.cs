using UnityEngine;


namespace Inferno
{
    /// <summary>
    /// 屬性 Property
    /// </summary>


    public class Class_7_Property : MonoBehaviour
    {

        #region 認識屬性
        //公開的變數 : 可以讓外部讀取與寫入
        public float moveSpeed = 3.5f;

        //私人的變數 : 不允許外部讀取與寫入
        private float rotateSpeed = 12.7f;

        
        //屬性開始
        //公開的屬性 : 允許存取
        public float runSpeed { get; set; }
        //私人的屬性 : 不允許存取
        private float sprintSpeed { get; set; }

        //公開的屬性 : 但只有get 代表唯獨(只能讀取不能寫入)
        public float jumpSpeed { get; }

        //prop+Tab*2 快速完成
        public byte Lv { get; set; } = 1;  //有預設值的屬性


        private void Awake()
        {
            Debug.Log("------Damn 取得變數與屬性-----");
            Debug.Log(moveSpeed);
            Debug.Log(rotateSpeed);
            Debug.Log(runSpeed);
            Debug.Log(sprintSpeed);
            Debug.Log(Lv);
            Debug.Log("------Damn 取得變數與屬性-----");
            moveSpeed = 77.7f;
            rotateSpeed = 45.1f;                      //私人的變數在同一個類別內可以設定 (在其他類別會被拒絕)
            runSpeed = 30;
            sprintSpeed = 70.7f;
            //jumpspeed = 99;                         // 沒有set 的屬性在類別內也無法設定
            Lv = 6;
            
        }
        #endregion


        //屬性簡寫 
        public float Mp { get; set; } = 100;

        //屬性標準寫法
        // 用來裝屬性 mp 的容器
        private float _mp = 50;

        //屬性是給予外部存取權限的窗口
        public float mp
        {
            get 
            {
                return _mp;
            }
            set
            {
                _mp = value;
            }
        }

        private void Start()
        {
            Debug.Log($"<color=#77f>魔力 : {mp}</color>");
            mp = 500;
            Debug.Log($"<color=#77f>魔力 : {mp}</color>");
        }

        //取得屬性的簡寫(箭頭 => lambda)
        //唯獨屬性 防禦值是 30
        public int defense { get; } = 30;
        //唯獨屬性 攻擊力是50
        public int attack => 50;




    }
}
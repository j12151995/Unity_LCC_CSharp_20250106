using UnityEngine;
using UnityEngine.VFX;
/// <summary>
/// 方法
/// 中文 :　方法、函式、函數、功能
/// 英文 : function、method (Untiy)
/// </summary>
public class Class_4_function : MonoBehaviour
{
    private void Awake()
    {
        #region  方法基本語法與參數呼叫練習
        // 呼叫方法 : 方法沒有呼叫不會執行
        // 方法名稱();
        FirstFunction();
        FirstFunction();
        FirstFunction();
        // 呼叫有參數的方法 : 小括號內要放入引數
        // Useskill();  <--錯誤寫法:少了引數
        UseSkill("虎嘯龍吟",30);
        UseSkill("震驚百里",30);
        UseSkill("神龍擺尾",50);
        UseSkill("閃現",0);
        // 呼叫有預設值的參數 : 可以不用填(選填式參數)
        SpwanEnemy();
        SpwanEnemy("史萊姆");

        Fire(700);
        Fire(900, "超威能死亡火箭");
        //有多個選擇性參數時的呼叫
        //買紅色藥水，50個
        BuyItem();
        //買紅色藥水，30個
        //BuyItem(30); <---錯誤。30會直接帶入到 item 參數導致資料類型不符合(資料第一個是string 第二個才是int)
        BuyItem(count: 30);
        //買紅色精煉藥劑，50個
        BuyItem("紅色精煉藥劑");
        //買紅色精煉藥劑，100個
        BuyItem("紅色精煉藥劑",100);
        #endregion

        //呼叫有傳回的方法
        //第一種: 把結果放在區域變數內
        int number9 = Square(9);
        Debug.Log($"<color=#fff>9 的平方{number9}</color>");
        //第二種 : 把傳回方法當作該傳回類型使用
        Debug.Log($"<color=#fff>7 的平方 {Square(7)}</color>");

        BMI(1.68f, 60);
        BMI(1.71f, 70);
        Debug.Log($"<color=#fff>{BMI(1.68f,60)}</color>");
        Debug.Log($"<color=#fff>{BMI(1.71f,70)}</color>");

        Move();
        Move(50.5f);
    }



    //框選要整理的程式 <Ctrl + K + S> #region 快速完成程式碼片段
    #region 方法基本語法與參數
    #region 介紹方法
    // 方法 :
    // 包含一系列城市區塊
    // 方法語法 :
    // 修飾詞 傳回資料類型 方法名稱 (參數1，參數2，....，參數n) { 城市區塊 }
    // 方法命名習慣 : Unity 習慣使用大寫開頭命名方法
    // void 無傳回 : 使用此方法不會有傳回資料
    private void FirstFunction()
    {
        Debug.Log("第一個方法");
    }
    #endregion

    #region 介紹參數語法使用
    // 參數語法:與區域變數相同 資料類型 參數名稱 (習慣用小寫或者加底線開頭)
    private void UseSkill(string skill, float cost)
    {
        Debug.Log($"<color=#f93>施放技能:{skill}</color>");
        Debug.Log($"<color=#00f>技能消耗:{cost}</color>");
    }
    #endregion
    #region 填寫有預設值的參數
    private void SpwanEnemy(string enemy = "哥布林")
    {
        Debug.Log($"<color=#f33>生成敵人:{enemy}</color>");
    }
    #endregion

    #region  必較參數，發射物件方法
    //沒有預設值為:必要參數 ，有預設值稱為選擇性參數
    //選擇性參數要寫在右邊!!!
    //以下為錯誤示範 寫在左邊會出現錯誤
    //private void Fire(string fire = "子彈", int speed)
    //{
    //    Debug.Log($"<color=#fff>發射物件:{fire}</color>");
    //}


    /// <summary>
    /// 發射物件方法
    /// </summary>
    /// <param name="speed">發射速度</param>
    /// <param name="fire">要發射的物件</param>
    private void Fire(int speed, string fire = "慶記")
    {
        Debug.Log($"<color=#fff>發射物件:{fire}</color>");
    }
    // 在方法上面打上///的summary的總結 就會跳出param的紀錄
    // 將上面的參數註解寫在裡面 之後寫到這個參數的時候會跳出提示

    #endregion

    #region 多個選擇性參數的使用方法
    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="item">道具名稱</param>
    /// <param name="count">道具數量</param>
    private void BuyItem(string item = "紅色藥水", int count = 50)
    {
        Debug.Log($"<color=#0F0>購買商品 : {item} ,數量 : {count}</color>");
    }
    #endregion
    #endregion

    #region 傳回方法
    // 傳回方法 : 傳回類型不是 void 呼叫該方法會獲得結果
    // 傳回方法必須在 {} 內使用 return 關鍵字將結果傳回

    /// <summary>
    /// 平方
    /// </summary>
    /// <param name="number">要平方的數字</param>
    /// <returns>數字的平方</returns>
    private int Square(int number) 
    {
        return number * number;      
    }

    /// <summary>
    /// BMI的計算
    /// </summary>
    /// <param name="height">身高 : 公尺</param>
    /// <param name="weight">體重 : 公斤</param>
    /// <returns></returns>
    private float BMI(float height, float weight)
    {
        return weight / (height * height);
    }
    #endregion 

    //名稱不能重複，包含:類別，變數與方法

    private void Test() { }
    // private void Test () {}  <--- 名稱重複的錯誤

    //方法多載 function overload
    //參數的類型貨數量不同
    //零個參數
    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        Debug.Log($"<color=#19f>移動中</color>");
    }
    //一個參數
    /// <summary>
    /// 移動方法並指定速度
    /// </summary>
    /// <param name="speed">移動速度</param>
    private void Move(float speed)
    {
        Debug.Log($"<color=#19f>移動中，速度:{speed}</color>");
    }
}

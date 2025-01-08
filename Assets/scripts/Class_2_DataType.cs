using UnityEngine;


// 三條斜線 是摘要 summary (XML 語言) 用來做簡短說明，在加在類別與變數上方
/// <summary>
/// 認識 C#   資料類型
/// </summary>

public class Class_2_DataType : MonoBehaviour 
{
    // 變數語法 :
    // 修飾詞 資料類型 變數名稱 指定 預設值;
    // 四大常用資料類型
    // 整數 : 儲存沒有小數點的數值 [int]
    // 浮點數 : 儲存有小數點的數值 [float] 
    // 字串 : 儲存文字，必須使用雙引號 [string]
    // 布林值 : 儲存正與反，bool 只有兩種值 [true or false]
    public int count = 7;
    public float moveSpeed = 3.5f;  // 浮點數必須添加 f 後綴
    public float trunSpeed = 45.5F; // 大小寫的F皆可以
    public string character = "發條";
    public bool isDead = false;     // 是否死亡 : 否
    public bool gameOver = true;    // 是否結束 : 是


    // 整數資料類型
    public byte lv = 18;            // byte 型別，範圍 0~255 大小 8 byte
    public uint coin = 9999;        // uint 型別，範圍 0~4294**，大小 32 byte
    public long items = 3000;       // long 型別，範圍 0~92***，大小 64 byte


    // 字串與字元
    public string playerName = "Rondo";  //字串 : 儲存多個字元，使用雙引號
    public char a = 'a';                 //字元 : 儲存單個字元，使用單引號

    // 益位
    //public sbyte number = 128;  <---超過 sbye的轉換值    // 益位會導致錯誤，會出現紅色蚯蚓

}

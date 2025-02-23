using Rondo.Tools;
using UnityEngine;
using System;
namespace Inferno
{

    /// <summary>
    /// 資料類型轉換
    /// </summary>
    public class Class_9_2_DataTypeSwitch : MonoBehaviour
    {

        private void Awake()
        {
            // 隱式轉換 : 不需要另外宣告轉換類型
            // 將[小]的資料放到[大]的資料內
            byte byte1 = 1;
            int int1 = 0;

            Logsystem.LogWithColor(byte1, "#7f7");
            Logsystem.LogWithColor(byte1.GetType(), "#7f7");
            Logsystem.LogWithColor(int1, "#7f7");
            Logsystem.LogWithColor(int1.GetType(), "#7f7");
            //隱式轉換 : 將比較小的 byte 放到大的 int
            // 隱士資料轉換
            int1 = byte1;
            Logsystem.LogWithColor(int1,"#7f7");
            Logsystem.LogWithColor(int1.GetType(), "#7f7");

            int int2 = 100;
            byte byte2 = 0;
            Logsystem.LogWithColor(byte2, "#7f7");
            Logsystem.LogWithColor(byte2.GetType(), "#7f7");
            Logsystem.LogWithColor(int2, "#7f7");
            Logsystem.LogWithColor(int2.GetType(), "#7f7");

            // 顯式轉換 : 需要宣告轉換的類型
            // 將[大]的資料放到[小]的資料內
            // 需要在前面添加(資料類型)
            //byte2 = int2;   <---因為沒有添加資料類型 會顯示錯誤 
            byte2 = (byte)int2;
            Logsystem.LogWithColor(byte2, "#1a1");
            Logsystem.LogWithColor(byte2.GetType(), "#1a1"); 

            //-------------------
            // 浮點樹轉換為整數類別
            float float1 = 3.5f;
            byte byte3 = 0;
            byte3 = (byte)float1;
            Logsystem.LogWithColor(byte3, "#77a");
            Logsystem.LogWithColor(byte3.GetType(), "#77a");
            //測試完之後會發現原本屬於浮點數的3.5 轉換成byte之後會變成3 因為byte不會紀錄小數點

            //-------------------------------------------------------
            //範圍較大的轉換為範圍較小的，會導致益味(超過的數值會重新開始算)
            //例如byte0~255 超過255 就會重0開始 ||>  所以數字設定256 會顯示0  257會顯示1
            int int3 = 257;
            byte byte4 = 0;
            byte4 = (byte)int3;
            Logsystem.LogWithColor(byte4, "#77a");
            Logsystem.LogWithColor("---------", "#77a");




        }

        private void Start()
        {
            // 將整數轉為字串
            int count = 99;
            Logsystem.LogWithColor(count.GetType(), "#7f7");

            var inToString = Convert.ToString(count);
            Logsystem.LogWithColor(inToString.GetType(), "#7f7");

            //將布林值轉為字串
            bool isOver = false;
            Logsystem.LogWithColor(isOver.GetType(), "#7f7");

            var boolToString = Convert.ToString(isOver);
            Logsystem.LogWithColor(boolToString.GetType(), "#7f7");

            //將浮點數轉為byte
            float move = 8.7f;
            var floatToByte = Convert.ToByte(move);
            Logsystem.LogWithColor(floatToByte, "#7f7");
            Logsystem.LogWithColor(floatToByte.GetType(), "#7f7");

            //將布林值轉換為Byte
            //轉換完成之後 會發現 true = 1  ， flase = 0。
            bool isGrounded = true;
            var boolToByte = Convert.ToByte(isGrounded);
            Logsystem.LogWithColor(isGrounded, "#7f7");                
            Logsystem.LogWithColor(boolToByte.GetType(), "#7f7");


        }
    }
}


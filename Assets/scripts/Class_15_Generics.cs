using Rondo.Tools;
using UnityEngine;
namespace Inferno_class_15
{
    /// <summary>
    /// 泛型 Generics
    /// </summary>

    public class Class_generics : MonoBehaviour
    {
        private void Awake()
        {
            #region 不使用泛型
            //數字對調
            int numberA = 6, numberB = 9;
            Logsystem.LogWithColor($"數字 A 與 數字 B:{numberA} | {numberB}", "#f93");
            SwapNumber(ref numberA, ref numberB);
            Logsystem.LogWithColor($"數字 A 與 數字 B:{numberA} | {numberB}", "#f93");

            // 字元對調
            char charA = '幹', charB = '哩';
            Logsystem.LogWithColor($"字 A 與 字 B:{charA} | {charB}", "#f93");
            SwapChar(ref charA, ref charB);
            Logsystem.LogWithColor($"字 A 與 字 B:{charA} | {charB}", "#f93");

            // 物件對調
            object objA = 8.7f, objB = 7.8f;
            Logsystem.LogWithColor($"物品 A 與 物品 B:{objA} | {objB}", "#f93");
            SwapObject(ref objA, ref objB);
            Logsystem.LogWithColor($"物品 A 與 物品 B:{objA} | {objB}", "#f93");

            // 自由對調
            object objC = 8.7f, objD = "林娘哩";
            SwapObject(ref objC, ref objD);
            Logsystem.LogWithColor($"物品 A 與 物品 B:{objC} | {objD}", "#f93");
            #endregion

            #region 使用泛型
            bool boolA = true, boolB = false;
            Logsystem.LogWithColor($" A 與 B:{boolA} | {boolB}", "#f93");
            Swap<bool>(ref boolA,ref boolB);
            Logsystem.LogWithColor($" A 與 B:{boolA} | {boolB}", "#f93");

            byte byteA = 7, byteB = 8;
            Logsystem.LogWithColor($" A 與 B:{byteA} | {byteB}", "#f93");
            Swap<byte>(ref byteA,ref byteB);
            Logsystem.LogWithColor($" 整數A 與 整數B:{byteA} | {byteB}", "#f93");
            object objectA = "幹", objectB = 3.5f;
            Swap<object>(ref objectA, ref objectB);
            Logsystem.LogWithColor($" 物件A 與 物件B:{objectA} | {objectB}", "#f93");
            #endregion

            var player1 = new DataPlayer<int>();
            player1.data = 99;
            player1.LogData(123);
            
            var player2 = new DataPlayer<string>();
            player2.data = "玩家二";
            player2.LogData ("賽林良機掰");


        }


        /// <summary>
        /// 數字對調
        /// </summary>
        /// <param name="a">第一個數字</param>
        /// <param name="b">第二個數字</param>
        /// 步驟 1 . [1] [2]  1跟2互換
        /// 步驟 2 . []  [2] 1  (先把1拿出來)
        /// 步驟 3 . [2] []  1  (再把2拿過去)
        /// 步驟 4 . [2] [1]   最終完成
        public void SwapNumber(ref int a, ref int b)
        {
            int temp = a;  // 將第一個數字放去旁邊(暫存)
            a = b;         // 將第二個數字放到第一個數字內
            b = temp;      // 將旁邊的數字放到第二個數字
        }

        /// <summary>
        /// 字元對調
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void SwapChar(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// 物件對調
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void SwapObject(ref object a, ref object b)
        {
            object temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// 使用泛型進行對調
        /// </summary>
        /// <typeparam name="T">要對調的資料類型</typeparam>
        /// <param name="a">第一個資料</param>
        /// <param name="b">第二個資料</param>
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }


    public class DataPlayer<T>
    {
        public T data;
        public void LogData(T data)
        {
            Logsystem.LogWithColor(data, "#3ff");
        }
    }
}

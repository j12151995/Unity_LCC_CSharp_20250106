using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using Rondo.Tools;   //  有許多資料結構的命名空間
namespace Inferno_Class_16
{
    /// <summary>
    /// 資料結構
    /// </summary>
    public class Class_16_DataStruct : MonoBehaviour
    {
        // 陣列
        public int[] potions = { 10, 20, 30 };
        public float[] defense = { 10, 20, 30 };

        // 會用陣列跟 泛型清單比較
        // 兩個在unity上面看起來一樣 但是寫法不一樣

        // 清單 : 泛型集合
        public List<int> speed = new List<int>() { 3, 7, 11 };
        public List<string> props = new List<string>() { "藥水", "情趣用品" };
        public List<float> playerDefense;

        private void Awake()
        {
            #region 清單
            // 清單存取 : 與陣列相同
            Logsystem.LogWithColor($"第三筆速度:{speed[2]}", "#3f3");
            speed[0] = 10;
            Logsystem.LogWithColor($"第一筆速度:{speed[0]}", "#3f3");
            // 接下來與陣列不一樣的地方
            // 陣列初始化後就無法增減長度
            // 清單還能添加 : 添加一筆道具
            props.Add("大鵰");
            // 清單還能刪除 : 刪除一筆道具
            props.RemoveAt(0);

            // 清單還能插入 : 插入保險套到編號1的資料上
            props.Insert(1, "保險套");

            foreach (var prop in props)
            {
                Logsystem.LogWithColor($"道具: {prop}", "#f93");
            }

            // 使用建構子帶入陣列
            playerDefense = new List<float>(defense);

            // 排序---由小到大
            playerDefense.Sort();
            // 排序---由大到小
            playerDefense.Reverse();
                                
            foreach (var item in playerDefense)
            {
                Logsystem.LogWithColor($"資料 : {item}", "#f93");
            }

            // Count 指的是清單內的資料，根據Add 或者是 Remove 改變
            Logsystem.LogWithColor($"數量:{props.Count}", "#77f");
            
            // Capacity 指的是清單內的容量，系統自動分配，預設是4，並且以倍數成長(會根據C# 版本 而不同)
            Logsystem.LogWithColor($"容量:{props.Capacity}", "#77f");

            List<int> numbers = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                numbers.Add(i);
                Logsystem.LogWithColor($"數量:{numbers.Count}", "#3a3");
                Logsystem.LogWithColor($"容量:{numbers.Capacity}", "#f39");
            }
            #endregion

            #region 堆疊
            // 堆疊 : 先進後出，類似椅子堆再一起 先進去的椅子在最下面 晚一點的椅子在上面
            // 所以先輸入的會最後出，最後輸入的會最先出
            Stack<string> enemys = new Stack<string>();
            enemys.Push("綠水靈");
            enemys.Push("菇菇寶貝");
            enemys.Push("綠菇菇");
            enemys.Push("紅寶");

            LogStack<string>(enemys);
            // 拿資料 並且不移除
            var peek =enemys.Peek();
            Logsystem.LogWithColor(peek,"#3f6");

            LogStack<string>(enemys);
            // 拿資料 並移除
            var pop = enemys.Pop();
            LogStack<string>(enemys);
            Logsystem.LogWithColor(pop,"#3f6");
            
            // 判斷是否包含某筆資料
            Logsystem.LogWithColor($"{enemys.Contains("紅寶")}","#3f6");
            // 清除所有資料
            enemys.Clear();
            LogStack<string>(enemys);
            #endregion

            // 佇列--------
            Queue<string> player = new Queue<string>();

            // 放一個資料進去佇列
            player.Enqueue("盜賊");
            player.Enqueue("遊俠");
            player.Enqueue("法師");
            LogQueue<string>(player);

            //拿東西不會刪除，與堆疊的 Peek 用法相同
            Logsystem.LogWithColor(player.Peek(), "#f33");
            LogQueue<string>(player);
            //拿東西會刪除，與堆疊的 Pop 用法相同
            Logsystem.LogWithColor(player.Dequeue(), "#f33");
            LogQueue<string>(player);


        }

         // 寫一個堆疊 讓上面AWAKE 可以LOG他
        private void LogStack<T>(Stack<T> stack)
        {
                Logsystem.LogWithColor("--------------", "#fff");
            foreach (var item in stack)
            {
                Logsystem.LogWithColor($"堆疊資料 : {item}", "#f77");
            }
        }

         // 寫一個佇列 讓上面AWAKE 可以LOG他
         private void LogQueue<T>(Queue<T> queue)
            {
            Logsystem.LogWithColor("---------","#fff");
            foreach (var item in queue)
              {
               Logsystem.LogWithColor($"佇列資料 : {item}","#3f3");
              }
            }


    }

       
}



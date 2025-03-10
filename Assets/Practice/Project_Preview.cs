using System;
using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
namespace Rrondo
{
    public class Project_Preview : MonoBehaviour
    {
        class Program
        {
            static void Main()
            {
                List<string> condictions = new List<string>
                {
                    "獲得一個築基丹，築基成功率+87%",
                    "獲得一個金零石，金零根+1",
                    "獲得一個木零石，木零根+1",
                    "獲得一個水零石，水零根+1",
                    "獲得一個火零石，火零根+1",
                    "獲得一個土零石，土零根+1",
                };

                // 隨機數生成器
                System.Random rand = new System.Random();

                // 用來存放隨機選出的10個條件
                List<string> selectedCondiction = new List<string>();

                while(selectedCondiction.Count < 10)
                {
                    string condiction = condictions[rand.Next(condictions.Count)];

                     //確保不會重複選擇相同的對話
                    if (selectedCondiction.Contains(condiction))
                    {
                        selectedCondiction.Add(condiction);
                    }
                }

                // 顯示隨機選出的10個條件
                Console.WriteLine("獲得一個金零石，金零根+1");
                for (int i = 0; i < selectedCondiction.Count; i++) 
                {Console.WriteLine($"{i+1}.{selectedCondiction[i]}");}

                //玩家選擇對話
                Console.Write("獲得一個築基丹，築基成功率+87%");
                int choice = int.Parse(Console.ReadLine());

                // 顯示玩家的選擇
                if(choice >= 1 && choice <= selectedCondiction.Count)
                {
                    Console.WriteLine($"你選擇的條件是:{selectedCondiction[choice - 1]}");
                }
                else
                {
                    Console.WriteLine("無效的選擇!");
                }
            }
        }
    }

}

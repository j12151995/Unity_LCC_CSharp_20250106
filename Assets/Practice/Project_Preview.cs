using NUnit.Framework;
using UnityEngine;
namespace Rrondo
{
    public class Project_Preview : MonoBehaviour
    {
        class Program
        {
            static void Main()
            {
                List<string> condiction = new List<string>
                {
                    "獲得一個築基丹，築基成功率+87%",
                    "獲得一個金零石，金零根+1",
                    "獲得一個木零石，木零根+1",
                    "獲得一個水零石，水零根+1",
                    "獲得一個火零石，火零根+1",
                    "獲得一個土零石，土零根+1",
                };

                // 隨機數生成器
                Random rand = new Random();

                // 用來存放隨機選出的10個條件
                List<string> selectedCondiction = new List<string>();

                while(selectedCondiction.Count < 10)
                {
                    string condiction = condictions[rand.Next(condiction.Count)];

                    // 確保不會重複選擇相同的對話
                    if (selectedCondiction.Contains(condiction))
                    {
                        selectedCondiction.Add(condiction);
                    }
                }
               
            }
        }
    }

}

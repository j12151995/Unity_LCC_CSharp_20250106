using Rondo.Tools;
using UnityEngine;
namespace Inferno_class_15
{
    /// <summary>
    /// 介面物件 : 實作介面的物件
    /// </summary>
    public class Class_15_InterfaceObject : MonoBehaviour
    {

    }




    // 介面的使用步驟
    // 1. 定義介面與介面成員
    // 2. 類別實作介面
    // 3. 實作介面的成員


    // 步驟 : 1
    // 帶有 [使用] 功能的介面 ， 換言之 遊戲內可被使用的物品都可以使用介面
    public interface IUse   // 使用介面命名的時候 都會用I開頭 所以在USE前面加I 變成 IUse
    {
        // 不用宣告方法，不用寫大括號  X{}X
        public void Use();
    }

    // 步驟 : 2
    // C# 單一繼承，多重實作介面
    public class Weapon : IUse     //使用黃色燈泡 --> 實作介面
    {
        // 步驟 : 3
        public void Use()
        {
            Logsystem.LogWithColor("使用武器，裝備狼牙", "#fa3");
        }
    }

    public class Potion : IUse
    {
        public void Use()
        {
            Logsystem.LogWithColor("使用威而鋼，我很硬", "#a3f");
        }
    }

    public class Chest : IUse
    {
        public void Use()
        {
            Logsystem.LogWithColor("開啟寶相，獲得隨機物品", "#3fa");
        }
    }
}


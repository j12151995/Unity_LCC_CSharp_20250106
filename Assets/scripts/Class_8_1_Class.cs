using UnityEngine;

namespace Inferno
{
    /// <summary>
    /// 類別
    /// </summary>
    public class Class_8_1_Class : MonoBehaviour 

    {
        // 類別 : 用來定義一個物件以及他所擁有的資料與功能(成員)
        // EX: 定義一個小孩 public child()  就可以寫下她的 1.年紀 2.身高 3.體重

        private void Awake()
        {
            // 實例化 NPC 並儲存在 npcMotherFucker 變數內
             Class_8_1_NPC npcMotherFucker = new Class_8_1_NPC();   
             Class_8_1_NPC npcGodDamnIt = new Class_8_1_NPC("GodDamnIt");

            npcMotherFucker.LogName();
            npcGodDamnIt.LogName();
        }


    }
}



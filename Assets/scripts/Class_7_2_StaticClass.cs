using UnityEngine;

namespace Inferno
{

    /// <summary>
    /// 靜態類別
    /// 靜態類別不能繼承 MonoBehaviour , 意味著 不能放在Untiy 的物件上
    /// </summary>
    public static class Class_7_2_StaticClass
    {
        // 常數(靜態)
        // 常數是無法修改的 (靜態可以修改不會還原)
        // 常數除了無法修改，命名時還需要有預設值
        public const string PlayerName = "Rondo";

        //靜態可以修改，也不用給預設值
        public static string PlayerWeapon;

        // 靜態類別內只能有靜態成員
        public static int lv = 1;
        public static float walkSpeed => 10;

       // public static void Run()
       // {

       // }

        //靜態類別內不能有非靜態的成員 <--徹底的排外
        //public int count=3   (錯誤)
    }
}

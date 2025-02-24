using UnityEngine;
using Rondo.Tools;
using NUnit.Framework.Constraints;
namespace Inferno
{
    /// <summary>
    /// 抽象
    /// </summary>
    public class Class_11_Abstract : MonoBehaviour 
    {
        private void Awake()
        {
            // 抽象類別 :
            // 1. 必須使用 關鍵字 "abstract"
            // 2. 不能被實例化 (new)
            // 3. 如果有抽象方法成員，不需要主體 也就是大括號{}
            // 4. 抽象成員必須被子類別實作 也就是 (Override)
            var flyDragon = new FlyDragon();
            var ThreeHornDragon = new ThreeHornDragon();

            // var monster = new Monster();       <--- 抽象的類別 沒辦法被實例化
            // 可以解讀成 沒有這個東西

            flyDragon.Attack();
            ThreeHornDragon.Attack();

            // 向上轉型 Upcasting : 實例化後存放到父類別
            // 向上轉型可以使用多型
            Monster anger = new FlyDragon();
            anger.Threat();

            FlyDragon anger2 = new FlyDragon();
            anger2.Threat();
            anger2.Threat(100);

            var anger3 = new FlyDragon();
            anger3.Threat();
            anger3.Threat(150);

        }
    }

    // abstract 抽象
    public abstract class Monster
    {
        public float hp;               // 血量
        public float moveSpeed;        // 移動速度

        // 抽象方法 不需要主體 (也就是大括號 {}) 直接 [()]+上 [;]就好
        public abstract void Attack();           // 攻擊方式，攻擊方式很多種 可以弄成抽象方法

        public void Threat()
        {
            Logsystem.LogWithColor("仇恨值", "#f93");
        }
                        
    }

    public class FlyDragon : Monster
    {
        public override void Attack()    // 由於繼承了 Monster 所以要寫下Attack  (因為上面被定義成抽象)
        {
            Logsystem.LogWithColor("飛龍吐熄", "#f77");
        }

        public void Threat(int anger)
        {
            Logsystem.LogWithColor($"仇恨，憤怒值 : {anger}", "#F93");
        }
    }

    public class ThreeHornDragon : Monster
    {
        public override void Attack()
        {
            Logsystem.LogWithColor("三角龍衝撞", "#f77");

        }

    }
}


using JetBrains.Annotations;
using Rondo.Tools;
using UnityEngine;
namespace Inferno
{

    /// <summary>
    /// 繼承 inherit
    /// </summary>
    public class Class_10_1_Inherit : MonoBehaviour
    {
        private void Awake()
        {
            var goblin1 = new Goblin(10, 1);
            Logsystem.LogWithColor($"哥布林1號的攻擊 : {goblin1.attack}", "#f3d");
            var slime1 = new Slime(8, 7);
            Logsystem.LogWithColor($"史萊姆的攻擊 : {slime1.attack}", "#f3d");
            goblin1.Move();
            slime1.Move();
            slime1.Initlize();

            // 判斷史萊姆是否繼承哥布林
            // 類別A is 類別B : 布林值
            var slime1IsGoblin = slime1 is Goblin;
            Logsystem.LogWithColor($"史萊姆一號是否繼承哥布林:{slime1IsGoblin}", "#3f3");

            var spider1 = new Spider(7, 8);
            var spider1IsSlime = spider1 is Slime;
            var spider1IsGoblin = spider1 is Goblin;
            Logsystem.LogWithColor($"蜘蛛一號是否繼承史萊姆:{spider1IsSlime}", "#3f3");
            Logsystem.LogWithColor($"蜘蛛一號是否繼承哥布林:{spider1IsGoblin}", "#3f3");

        }
    }

    public class Goblin
    {
        public int attack;
        public int defense;                // 公開 : 所有類別可以存取
        private float moveSpeed;           // 私人 : 此類別可以存取
        protected float hp;                // 保護 : [子類別]可以存取
        protected int lv = 5;

        public Goblin(int _attack,int _defense)
        {
            attack = _attack;
            defense = _defense;
        }

        // virtual 虛擬 : 允許子類別覆寫
        public virtual void Move()
        {
            Logsystem.LogWithColor("兩條腿移動","#9f9");
        }
    }

    // 上面建構哥布林的數值
    // 下面用使萊姆繼承
    // 繼承讓類別可以繼承另一個類別，擁有該類別的成員
    // 子類別 : 父類別
    // C# 僅提供單一繼承(只能繼承一個類別)
    public class Slime : Goblin   //寫法類似每個腳本 都在後面繼承 MonoBehaviour 一樣
    {
        public Slime(int _attack, int _defense) : base(_attack, _defense)     // 這個base 意思就是跟父類別的建構子一樣 base on 的意思
        {
        }

        protected int lv = 10;    // 綠色蚯蚓 : 提示你 父類別有相同的成員名稱

        public void Initlize()
        {
            attack = 7;  // 公開 : 可以存取
            //moveSpeed = 8.7f;   因為上面寫的是私人private 所以這樣更改存取會出現錯誤
            hp = 10;     // 保護 : 因為是子類別 所以可以存取
            Logsystem.LogWithColor($"等級 : {lv}", "#1a1");
            Logsystem.LogWithColor($"等級 : {base.lv}(父類別)", "#1a1");

        }

        // override 覆寫 : 覆寫父類別上面有 [virtual] 關鍵字的成員
        // override 選擇要覆寫的成員 --> 按下 Enter 完成
        public override void Move()
        {
            // base.Move();       // 父類別原有的內容
            Logsystem.LogWithColor("跳動", "#3f3");

        }


       
    }
    public class Spider : Slime
    {
        public Spider(int _attack, int _defense) : base(_attack, _defense)
        {

        }
    }

}


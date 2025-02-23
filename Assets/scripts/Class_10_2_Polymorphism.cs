using UnityEngine;
using Rondo.Tools;
namespace Inferno
{
    /// <summary>
    /// 多型
    /// </summary>
    public class Class_10_2_Polymorphism : MonoBehaviour
    {
        private void Awake()
        {
            Trap trap1 = new Trap("神聖彗星反射力量", 8);
            Magic magic1 = new Magic("融合", 2);

            // 多形 : 多種形式 ， 可以使用父類別或者自己的成員。
            trap1.Information();             // 型式 1 : 呼叫父類別的無參數方法
            trap1.Information(37);           // 型式 2 : 呼叫自己有一個參數的方法

            // 多形 : 宣告時使用父類別，實例化的類別會決定型式
            Card card1 = new Card("一般卡片", 1);
            Card magic2 = new Magic("貪婪之壺", 2);
            card1.Information();            // 型式 1 : 呼叫 Card 的方法
            magic2.Information();           // 型式 2 : 呼叫 Magic 的方法
        }
    }

    public class Card
    {
        public string name;
        public int cost;
        public Card() { }
        public Card(string _name, int _cost)
        {
            name = _name;
            cost = _cost;
        }
        public virtual void Information()
        {
            Logsystem.LogWithColor("這是一張卡牌", "#aaa");
        }
    }

    public class Trap : Card
    {
            public Trap(string _name, int _cost) : base(_name , _cost)
            {

            }
            public void Information(int index)
        {
            Logsystem.LogWithColor($"這是一張陷阱卡 編號 : {index}", "#f77");

        }
    }

    public class Magic : Card
    {
            public Magic(string _name, int _cost) : base(_name, _cost)
            {
            }
        public override void Information() 
        { 
            Logsystem.LogWithColor($"{name}這是一張魔法卡", "#3f3");
        }
    }
    

}

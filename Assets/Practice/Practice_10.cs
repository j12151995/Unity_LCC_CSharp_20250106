using UnityEngine;
using Rondo.Tools;
using JetBrains.Annotations;

namespace Inferno
{
    /// <summary>
    /// 這是作業
    /// </summary>
    public class Practice_10 : MonoBehaviour
    {

        private void Awake()
        {
            potions potions1 = new potions("Red Potion", 1); 
            potions potions2 = new potions("Blue Potion", 1);
            equiptment equiptment1 = new equiptment("風暴戰盔", 1);

            potions1.Information();

            potions2.Information(100);
            equiptment1.Information("風暴戰盔");
        }






        public class inventory
        {
            public string name;
            public int slots;
            public inventory() { }
            public inventory(string _name, int _slots)
            {
                name = _name; slots = _slots;
            }
            public virtual void Information()
            {
                Logsystem.LogWithColor("我是道具欄","#5aa");
            }
        }

        public class potions : inventory 
        {
            public potions(string _name, int _slots) : base(_name, _slots)
            {
                
            }
            public void Information(int intdex)
            {
                Logsystem.LogWithColor($"使用藍色藥水回復: {intdex}", "#005AB5");
            }
        }
        

        public class equiptment : inventory
        {
            public equiptment (string _name, int _slots) : base(_name, _slots)
            {
                
            }
            public  void  Information(string name)
            {
                Logsystem.LogWithColor($"裝備: { name}", "#FF5809");
            }
        }
            
        
        
        

    }
}


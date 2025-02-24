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
            Potions potions1 = new Potions("Red Potion", 1); 
            Potions potions2 = new Potions("Blue Potion", 1);
            Equiptment equiptment1 = new Equiptment("風暴戰盔", 1);

            potions1.Use();

            potions2.Use(100);
            equiptment1.Use("風暴戰盔");
        }






        public class Inventory
        {
            public string name;
            public int slots;
            public Inventory() { }
            public Inventory(string _name, int _slots)
            {
                name = _name; slots = _slots;
            }
            public virtual void Use()
            {
                Logsystem.LogWithColor($"我是道具欄，使用 : {name}","#5aa");
            }
        }

        public class Potions : Inventory 
        {
            public Potions(string _name, int _slots) : base(_name, _slots)
            {
                
            }
            public void Use(int increase)
            {
                Logsystem.LogWithColor($"使用藍色藥水回復: {increase}", "#005AB5");
            }
        }
        

        public class Equiptment : Inventory
        {
            public Equiptment (string _name, int _slots) : base(_name, _slots)
            {
                
            }
            public  void  Use(string name)
            {
                Logsystem.LogWithColor($"裝備: { name}", "#FF5809");
            }
        }
            
        
        
        

    }
}


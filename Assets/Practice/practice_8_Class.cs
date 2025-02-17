using UnityEngine;


namespace Inferno
{
    /// <summary>
    /// 這是作業
    /// </summary>
    public class practice_8_Class : MonoBehaviour
    {
        private void Awake()
        {
            Practice_8_1_Boss bossDragon = new Practice_8_1_Boss("遠古巨龍", "破壞死光", 9487);
            Practice_8_1_Boss bossQueen = new Practice_8_1_Boss("亞布雷舒德", "夢幻之眼", 9453);

            Debug.Log($"<color=#3f3>{bossDragon},招式 : {bossDragon.skill},血量 : {bossDragon.hp}</color>");
            Debug.Log($"<color=#3f3>{bossQueen},招式 : {bossQueen.skill},血量 : {bossQueen.hp}</color>");
            

        }


    }

    
    
    /// <summary>
    /// BOSS的類別
    /// </summary>
    public class Practice_8_1_Boss
    {
        public string name;
        public string skill;
        public float hp;

        public Practice_8_1_Boss(string _name,string _skill,float _hp)
        {
            name = _name;
            skill = _skill;
            hp = _hp;
        }

    }
}


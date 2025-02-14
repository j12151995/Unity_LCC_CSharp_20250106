using UnityEngine;



namespace Inferno
{
    /// <summary>
    /// homework practice
    /// 
    /// </summary>

    public class Practice_7_Property : MonoBehaviour
    {




        private float _hp = 100;
        public float hp
        {
            get
            {
                
                return _hp; 
            }
            
            

            
        }
        

        private void Start()
        {
            Debug.Log($"<color=#3f3>血量 : {hp}</color>");
            
            Debug.Log($"<color=#3f3>血量 : {hp*0} 血量歸零，你已經死了</color>");
        }
    }

}

using UnityEngine;



namespace Inferno
{
    /// <summary>
    /// homework practice
    /// 
    /// </summary>

    public class Practice_7_Property : MonoBehaviour
    {



        [SerializeField]
        private float _hp = 100;

        public float hp
        {
            get
            {
                if (_hp <= 0)
                {
                    Debug.Log($"<color=#f33>血量歸零，你已經死了</color>");
                }
                return _hp; 
            }
            
            

            
        }
        

        private void Update()
        {
            Debug.Log($"<color=#3f3>血量 : {hp}</color>");
            
          
        }
    }

}

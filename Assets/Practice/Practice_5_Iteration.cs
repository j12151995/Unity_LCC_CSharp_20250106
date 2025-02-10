using UnityEngine;

//這是作業
public class Practice_5_Iteration : MonoBehaviour
{
    [SerializeField, Header("血量"), Range(0, 100)]
    private float hp = 100;

    private void Update()
    {

        switch (hp)
        {
            case >= 80:
                Debug.Log("<color=#f93>血量安全</color>");
                break;
            case >= 60:
                Debug.Log("<color=#f93>健康狀態有狀況</color>");
                break;
            case >= 40:    
                Debug.Log("<color=#f93>警告快喝水</color>");
                break;
            case >= 10:
                Debug.Log("<color=#f93>我快死了</color>");
                break;
            case <= 0:
                Debug.Log("<color=#f93>你已經死了</color>");
                break;


        }

    }



}

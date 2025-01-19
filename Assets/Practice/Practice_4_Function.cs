using UnityEngine;
// 這是作業
public class Practice_4_Function : MonoBehaviour 
{
    private void Awake()
    {
        bool X = true;
        bool Y = false;
        Debug.Log($"<color=#F93>X並且Y{X && Y}</color>");
        Debug.Log($"<color=#F93>X或者Y{X || Y}</color>");

    }




    private bool Operator(bool X,bool Y)
    {
        return X && Y;
        return X || Y;
        
    }
}

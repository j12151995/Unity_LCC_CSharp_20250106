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

        //----以下老師示範----
        Debug.Log($"<color=#3f3>布林值 True : {ReturnTrue()}</color>");
        Debug.Log($"<color=#3f3>布林值 False : {ReturnFalse()}</color>");



    }




    private bool Operator(bool X,bool Y)
    {
        return X && Y;
        return X || Y;
        
    }


    // ----以下老師示範----

    /// <summary>
    /// 布林值 True
    /// </summary>
    /// <returns></returns>
    private bool ReturnTrue()
    { return true; }


    /// <summary>
    /// 布林值 False
    /// </summary>
    /// <returns></returns>
    private bool ReturnFalse() 
    { return false; }



}

using UnityEngine;

//這是作業

public class Practice_6_IterationArray : MonoBehaviour
{
    private string[,,] characterNames =
    {
        { {"伊布", "水精靈","火精靈" },{"夜精靈","日精靈","皮卡丘"}  },
        { {"嫩寶","藍寶","紅寶"},{"姑姑寶貝","藍姑姑","殭屍姑姑"}  },
        { {"劫","塔龍","姬亞娜"},{"雷文","賈克斯","蓋倫"}  }
    };


    private void Awake()
    {
        Debug.Log($"<color=#F33>皮卡丘 : {characterNames[0,1,2]}</color>");
        Debug.Log($"<color=#F33>姑姑寶貝 : {characterNames[1,1,0]}</color>");
        Debug.Log($"<color=#F33>蓋倫 : {characterNames[2,1,2]}</color>");


        Debug.Log($"<color=#F33>第二頁第一排第三個 : {characterNames[1,0,2]}</color>");
    }

}

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

//命名空間 :
//將類別分類，類似倉庫的概念。不同倉庫可以有相同的名稱類別。
//語法 : namespace 命名空間名稱 {內容}
namespace Inferno
{
    /// <summary>
    /// 選取陳述式 Selection statement
    /// 1. if 判斷式
    /// 2. Switch 判斷式
    /// </summary>
    public class Class_5_1_selection : MonoBehaviour

    {
        [SerializeField, Header("是否開門")]
        private bool isOpen;
        [SerializeField, Header("分數"), Range(0, 100)]
        private int score = 100;
        [SerializeField, Header("魔力"), Range(0, 200)]
        private int mana = 200;
        [SerializeField, Header("武器")]
        private string weapon;
        private void Awake()
        #region
        {
            // if 判斷式
            // if (布林值，任何會得到布林值的運算式) {陳述式}

            if (true)
            {
                Debug.Log("當布林值為 True，會執行這裡。");
            }

            //快速完成 : 輸入 if 選取 if的陳述式並按下 Enter or Tab
            if (false)
            {
                Debug.Log("當布林值為False，不會執行這裡而且會有綠蚯蚓。");
            }
            #endregion
        }
        // 更新事件 : 一秒鐘直行約 60次 (60FPS)  Frame Per Second
        private void Update()
        {
            // 常用快捷鍵
            // 1.格式化(排版) Ctrl+ K + D
            // 2.程式碼片段 Ctrl+ K + S 選 region
            #region 判斷式 if
            Debug.Log("<color=#79f>更新事件</color>");
            //如果 isOpen 布林值等於 True，就顯示已經開門
            if (isOpen)
            {
                Debug.Log("<color=#F93>已經開門</color>");
            }
            //否則 isOpen 布林值等於False，就顯示門關了
            else
            {
                Debug.Log("<color=#F93>門關了</color>");
            }

            //比較運算子、邏輯運算子結果為布林值
            //if 會在最上方、else 在最下方，中間可以有多個 else if (否則 如果)。
            //如果 分數>= 60就通過

            if (score >= 60)
            {
                Debug.Log("<color=#F33>恭喜你的C#課程過了</color>");
            }
            //否則　如果　分數>= 40可以補考
            else if (score >= 40)
            {
                Debug.Log("<color=#f96>可以補考</color>");
            }
            // 否則 如果 分數 >= 20 可以補考並且做一個小專題
            else if (score >= 20)
            {
                Debug.Log("<color=#f9a>可以補考但是要做一個C# 小專題</color>");
            }
            //否則當掉
            else
            {
                Debug.Log("<color=#f33>恭喜你的C#課程被當了</color>");
            }

            // 判斷式只會執行一個陳述式
            //程式是由上往下執行
            // 如果先從 >=0 開始寫 那之後的>= 40，>=60，>=100 都會是同一個陳述式   <---錯誤寫法
            // 要改變 >=0開始寫的方法 必須增加多個條件 搭配邏輯運算子 例如:
            // (mana >=10 && mana < 40)   (mana >=40 && mana <60)
            if (mana >= 100)
            {
                Debug.Log("<color=#00C>你的魔力充足可以施放大招了</color>");
            }
            else if (mana >= 80)
            {
                Debug.Log("<color=#00C>妳的魔力稍顯不足</color>");  
            }
            else if(mana >= 60 && mana < 80)
            {
                Debug.Log("<color=#00C>妳的魔力不足，請補充魔力</color>");
            }
            else if(mana >= 10 && mana <60)
            {
                Debug.Log("<color=#00C>妳的魔力見底啦，請趕快補充魔力</color>");
            }
            else if (mana == 0)
            {
                Debug.Log("<color=#00C>你的魔力是0</color>");
            }
            #endregion

            #region 判斷式 switch
            // switch 判斷式
            // Switch (要判斷的值)(可以放字串，整數，不一定是布林值){陳述式}
            // 快速完成 : switch +Tab * 2
            switch (weapon)
            {
                // case 值 :
                // 當判斷的值等於值時會執行這裡
                // break; 跳出判斷式
                // 下面這條程式的意思是 : 如果武器等於小刀，攻擊力等於20
                //兩個case疊再一起 表示 蝴蝶刀與小刀的值一樣。
                case "":
                    Debug.Log("<color=#ff3>攻擊力 : 0</color>");
                    break;
                case "蝴蝶刀":
                case "小刀":
                    Debug.Log("<color=#ff3>攻擊力 : 20</color>");

                    break;
                case "無盡之力":
                    Debug.Log("<color=#ff3>攻擊力 : 100 ， 爆擊率 : 25%</color>");
                    break;

                // 當 waepon 的值不等於上面的所有執會執行這裡
                default:
                    Debug.Log("<color=#ff3>你不能使用這種武器</color>");
                    break;
            } 
            #endregion
        }
    }
}










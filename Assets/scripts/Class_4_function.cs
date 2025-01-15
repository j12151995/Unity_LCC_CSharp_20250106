﻿using UnityEngine;
/// <summary>
/// 方法
/// 中文 :　方法、函式、函數、功能
/// 英文 : function、method (Untiy)
/// </summary>
public class Class_4_function : MonoBehaviour
{
    private void Awake()
    {
        // 呼叫方法 : 方法沒有呼叫不會執行
        // 方法名稱();
        FirstFunction();
        FirstFunction();
        FirstFunction();
        // 呼叫有參數的方法 : 小括號內要放入引數
        // Useskill();  <--錯誤寫法:少了引數
        UseSkill("虎嘯龍吟");
        UseSkill("震驚百里");
        UseSkill("神龍擺尾");
        UseSkill("閃現");
    }

    // 方法 :
    // 包含一系列城市區塊
    // 方法語法 :
    // 修飾詞 傳回資料類型 方法名稱 (參數1，參數2，....，參數n) { 城市區塊 }
    // 方法命名習慣 : Unity 習慣使用大寫開頭命名方法
    // void 無傳回 : 使用此方法不會有傳回資料
    private void FirstFunction()
    {
        Debug.Log("第一個方法");
    }

    // 參數語法:與區域變數相同 資料類型 參數名稱 (習慣用小寫或者加底線開頭)
    private void UseSkill(string skill)
    {
        Debug.Log($"<color=#f93>施放技能:{skill}</color>");
    }
}
using UnityEngine;

namespace Inferno
{
    /// <summary>
    /// 練習存取資料用
    /// </summary>

    public class Class_7_1_GetSetData : MonoBehaviour

    {
        public Class_7_Property property;

        private void Awake()
        {
            //取得另一個類別的資料
            Debug.Log(property.moveSpeed);     //可取得公開的變數 也就是另一個資料的pulic
            //Debug.Log(property.rotatespeed);   //不可取得私人的變數 也就是另一個資料的 private


            //設定另一個類別的資料
            property.moveSpeed = 7.7f;        //可取得公開的變數
            // property.rotatespeed = 45.1f;  //不可取得私人的變數

            Debug.Log(property.runSpeed);   //可取得公開的變數
            //Debug.Log(property.sprintSpeed);   //不可取得私人的變數

            property.runSpeed = 50.3f;        //可以設定有 set的屬性
            //property.jumpSpeed = 99.3f;        //不可以設定沒有 set的屬性(唯獨)

            property.Lv = 1;
            

        }
    }
}


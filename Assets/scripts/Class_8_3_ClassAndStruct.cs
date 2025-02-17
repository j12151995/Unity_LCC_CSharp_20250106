using UnityEngine;
using Rondo.Tools;
using Inferno;
namespace Inderno
{
    /// <summary>
    /// 類別與結構的差異
    /// </summary>
    public class Class_8_3_ClassAndStruct : MonoBehaviour
    {

        private void Awake()
        {
            // 空值 : 類別可以空值，結構不行
            Class_8_3_Class class1 = new Class_8_3_Class();            // 有實例化 
            Class_8_3_Class class2 = null;                             // 空值 null = 空值

            Class_8_3_Struct struct1 = new Class_8_3_Struct();         // 有實例化
            //Class_8_3_Struct struct2 = null ;        // <---報錯了   // 空值 null = 空值

            Logsystem.LogWithColor(class1.ToString(), "#f96");
            Logsystem.LogWithColor(class2.ToString(), "#f96");
            Logsystem.LogWithColor(struct1.ToString(), "#f96");
            //Logsystem.LogWithColor(struct2.ToString(), "#f96");
            
        }

        private void Start()
        {
            //var 不指定類型，可以儲存所有資料
            var testClass = new Class_8_4_Class("我是類別");
            var testStruct = new Class_8_4_Struct("我是結構");

            var testClass2 = new Class_8_4_Class("我是類別2");
            var testStruct2 = new Class_8_4_Struct("我是結構2");

            Logsystem.LogWithColor(testClass.name, "#f79");
            Logsystem.LogWithColor(testClass2.name, "#f79");
            Logsystem.LogWithColor(testStruct.name, "#f79");
            Logsystem.LogWithColor(testStruct2.name, "#f79");

            testClass2 = testClass;        // 傳址 : 這時候的 class 與 class 指向同一個地址。
            testStruct2 = testStruct;      // 傳值 : 這時候的 struct 與 struct2 指向同一個值。

            // 修改 class 或者是 class2 資料都會被同步(同址)
            testClass.name = "類別";
            Logsystem.LogWithColor(testClass.name, "#f79");
            Logsystem.LogWithColor(testClass2.name, "#f79");

            // 修改 Struct 或者是 Strust2 資料不會被同步(不同址)
            testStruct.name = "結構";
            Logsystem.LogWithColor(testStruct.name, "#f79");
            Logsystem.LogWithColor(testStruct2.name, "#f79");
            
        }


    }

    //類別 :
    // 1. 繼承 : 允許繼承
    // 2. 可以有多個建構子
    // 3. 資料型別 : 參考型別 Reference Type
    public class Class_8_3_Class : MonoBehaviour
    {
        
        public Class_8_3_Class()
        {

        }
        
               
        public Class_8_3_Class(int test)
        {

        }
    }

    //結構 :
    // 1. 結構 : 不允許繼承
    // 2. 建構子 : 不能有無參數的建構子
    // 3. 資料型別 : 實質型別  Type

    public struct Class_8_3_Struct
    {
       // public Class_8_3_Struct()     <-- 會報錯誤訊息 因為沒有參數
        //{

       // }

        public Class_8_3_Struct (int test)
        {

        }
    }


}

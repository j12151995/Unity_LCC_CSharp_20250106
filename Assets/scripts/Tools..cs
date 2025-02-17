using UnityEngine;
namespace Rondo.Tools
{
    /// <summary>
    /// 輸出訊息工具
    /// </summary>
    public class Logsystem
    {
        /// <summary>
        /// 輸出訊息並指定顏色
        /// </summary>
        /// <param name = "message"">訊息</param>
        /// <param name = "color">顏色</param>
        /// <returns>包含顏色的訊息</returns>
        
        public static string LogWithColor(string message,string color)
        {
            string result = $"<color={color}>{message}</color>";
            Debug.Log(result);
            return result;
        }







    }

}

using UnityEngine;
namespace Rondo.Tools
{
    /// <summary>
    /// ��X�T���u��
    /// </summary>
    public class Logsystem
    {
        /// <summary>
        /// ��X�T���ë��w�C��
        /// </summary>
        /// <param name = "message"">�T��</param>
        /// <param name = "color">�C��</param>
        /// <returns>�]�t�C�⪺�T��</returns>
        
        public static string LogWithColor(string message,string color)
        {
            string result = $"<color={color}>{message}</color>";
            Debug.Log(result);
            return result;
        }







    }

}

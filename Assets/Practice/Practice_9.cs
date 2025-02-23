using UnityEngine;
using Rondo.Tools;
using System;
namespace Inferno
{
    /// <summary>
    /// 這是作業
    /// </summary>
    public class Practice_9 : MonoBehaviour
    {
        public float float1 = -999.321f;

        private void Awake()
        {
            var float1ToByte = Convert.ToByte(float1);
            Logsystem.LogWithColor(float1ToByte, "3f3");
            Logsystem.LogWithColor(float1ToByte.GetType(), "3f3");
        }
    }
    
}


using UnityEngine;
namespace Inferno
{

    /// <summary>
    /// �m�ߨ��o�P�]�w�R�A���
    /// </summary>
    public class Class_7_2_GetSetStaticData : MonoBehaviour
    {
        //���o�D�R�A���(����)
        //1. ���w�q�n��o������O���ܼ�
        //2. �z�L�ܼƨ��o�D�R�A���(����)


        public Class_7_2_Static class_7_2;

        private void Awake()
        { 
            //���o�D�R�A�ܼ�
            //�ܼƦW��.�D�R�A����
            Debug.Log($"<color=#f3d>�D�R�A���� : {class_7_2.inventoryWater}</color>");
            
            //���o�D�R�A�ݩ�
            Debug.Log($"<color=#3f3>�D�R�A�ݩ� : {class_7_2.skillMain}</color>");
            //�I�s�D�R�A��k
            class_7_2.Punch();
           
            //���o�R�A���(����)
            //���O�W��.�R�A����
            Debug.Log($"<color=#f3d>�R�A���� : {Class_7_2_Static.inventoryProp}</color>");
            //���o�R�A�ݩ�



        }


    }
}


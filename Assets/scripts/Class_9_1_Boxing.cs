using Rondo.Tools;
using UnityEngine;
namespace Inferno
{
    /// <summary>
    ///  �˽c Boxing �P��c Unboxing
    /// </summary>
    public class Class_9_1_Boxing : MonoBehaviour 

    {
        // ��諬�O���������
        // ���c�B�C�|�B��ơB�B�I�ơB���L�ȡB�r��
        // ��諬�O����Ʒ|�x�s�b Stack �O���餺
        private int number = 100;

        // �������������Ѧҫ��O (�x�s�b Heap �O���餺)
        private object box;

        //�ǳƩ�c
        private object boxNumber = 50;
        private int count;
        private void Awake()
        {
            //�˽c�ʧ@
            //�N��諬�O��Ʃ�b�Ѧҫ��O��Ƥ�
            box = number;
            Logsystem.LogWithColor(box.ToString(), "#f33");

            //��c�ʧ@  Unboxing
            //�N�Ѧҫ��O��Ʃ�b��諬�O��Ƥ�
            // �b�e��K�[ (�n�ഫ���������)

            //count = boxNumber;   <--�b�e���S�K�[�n�ഫ��������� �N�|��ܿ��~
            count = (int)boxNumber;
            Logsystem.LogWithColor(count.ToString(), "#f33");


        }
    }

}

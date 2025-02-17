using Rondo.Tools;
using UnityEngine;
namespace Inferno
{

    /// <summary>
    /// ��������ഫ
    /// </summary>
    public class Class_9_2_DataTypeSwitch : MonoBehaviour
    {

        private void Awake()
        {
            // �����ഫ : ���ݭn�t�~�ŧi�ഫ����
            // �N[�p]����Ʃ��[�j]����Ƥ�
            byte byte1 = 1;
            int int1 = 0;

            Logsystem.LogWithColor(byte1, "#7f7");
            Logsystem.LogWithColor(byte1.GetType(), "#7f7");
            Logsystem.LogWithColor(int1, "#7f7");
            Logsystem.LogWithColor(int1.GetType(), "#7f7");
            //�����ഫ : �N����p�� byte ���j�� int
            // ���h����ഫ
            int1 = byte1;
            Logsystem.LogWithColor(int1,"#7f7");
            Logsystem.LogWithColor(int1.GetType(), "#7f7");

            int int2 = 100;
            byte byte2 = 0;
            Logsystem.LogWithColor(byte2, "#7f7");
            Logsystem.LogWithColor(byte2.GetType(), "#7f7");
            Logsystem.LogWithColor(int2, "#7f7");
            Logsystem.LogWithColor(int2.GetType(), "#7f7");

            // �㦡�ഫ : �ݭn�ŧi�ഫ������
            // �N[�j]����Ʃ��[�p]����Ƥ�
            // �ݭn�b�e���K�[(�������)
            //byte2 = int2;   <---�]���S���K�[������� �|��ܿ��~ 
            byte2 = (byte)int2;
            Logsystem.LogWithColor(byte2, "#1a1");
            Logsystem.LogWithColor(byte2.GetType(), "#1a1"); 

            //-------------------
            // �B�I���ഫ��������O
            float float1 = 3.5f;
            byte byte3 = 0;
            byte3 = (byte)float1;
            Logsystem.LogWithColor(byte3, "#77a");
            Logsystem.LogWithColor(byte3.GetType(), "#77a");
            //���է�����|�o�{�쥻�ݩ�B�I�ƪ�3.5 �ഫ��byte����|�ܦ�3 �]��byte���|�����p���I

            //-------------------------------------------------------
            //�d����j���ഫ���d����p���A�|�ɭP�q��(�W�L���ƭȷ|���s�}�l��)
            //�Ҧpbyte0~255 �W�L255 �N�|��0�}�l ||>  �ҥH�Ʀr�]�w256 �|���0  257�|���1
            int int3 = 257;
            byte byte4 = 0;
            byte4 = (byte)int3;
            Logsystem.LogWithColor(byte4, "#77a");
            Logsystem.LogWithColor("---------", "#77a");




        }
    }
}


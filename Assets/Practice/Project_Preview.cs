using NUnit.Framework;
using UnityEngine;
namespace Rrondo
{
    public class Project_Preview : MonoBehaviour
    {
        class Program
        {
            static void Main()
            {
                List<string> condiction = new List<string>
                {
                    "��o�@�ӿv�򤦡A�v�򦨥\�v+87%",
                    "��o�@�Ӫ��s�ۡA���s��+1",
                    "��o�@�Ӥ�s�ۡA��s��+1",
                    "��o�@�Ӥ��s�ۡA���s��+1",
                    "��o�@�Ӥ��s�ۡA���s��+1",
                    "��o�@�Ӥg�s�ۡA�g�s��+1",
                };

                // �H���ƥͦ���
                Random rand = new Random();

                // �ΨӦs���H����X��10�ӱ���
                List<string> selectedCondiction = new List<string>();

                while(selectedCondiction.Count < 10)
                {
                    string condiction = condictions[rand.Next(condiction.Count)];

                    // �T�O���|���ƿ�ܬۦP�����
                    if (selectedCondiction.Contains(condiction))
                    {
                        selectedCondiction.Add(condiction);
                    }
                }
               
            }
        }
    }

}

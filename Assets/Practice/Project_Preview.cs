using System;
using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
namespace Rrondo
{
    public class Project_Preview : MonoBehaviour
    {
        class Program
        {
            static void Main()
            {
                List<string> condictions = new List<string>
                {
                    "��o�@�ӿv�򤦡A�v�򦨥\�v+87%",
                    "��o�@�Ӫ��s�ۡA���s��+1",
                    "��o�@�Ӥ�s�ۡA��s��+1",
                    "��o�@�Ӥ��s�ۡA���s��+1",
                    "��o�@�Ӥ��s�ۡA���s��+1",
                    "��o�@�Ӥg�s�ۡA�g�s��+1",
                };

                // �H���ƥͦ���
                System.Random rand = new System.Random();

                // �ΨӦs���H����X��10�ӱ���
                List<string> selectedCondiction = new List<string>();

                while(selectedCondiction.Count < 10)
                {
                    string condiction = condictions[rand.Next(condictions.Count)];

                     //�T�O���|���ƿ�ܬۦP�����
                    if (selectedCondiction.Contains(condiction))
                    {
                        selectedCondiction.Add(condiction);
                    }
                }

                // ����H����X��10�ӱ���
                Console.WriteLine("��o�@�Ӫ��s�ۡA���s��+1");
                for (int i = 0; i < selectedCondiction.Count; i++) 
                {Console.WriteLine($"{i+1}.{selectedCondiction[i]}");}

                //���a��ܹ��
                Console.Write("��o�@�ӿv�򤦡A�v�򦨥\�v+87%");
                int choice = int.Parse(Console.ReadLine());

                // ��ܪ��a�����
                if(choice >= 1 && choice <= selectedCondiction.Count)
                {
                    Console.WriteLine($"�A��ܪ�����O:{selectedCondiction[choice - 1]}");
                }
                else
                {
                    Console.WriteLine("�L�Ī����!");
                }
            }
        }
    }

}

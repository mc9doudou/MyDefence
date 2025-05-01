using UnityEngine;
namespace Sample.Generic
{
    public class GenericDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //CupŬ������ ��ü ����
            //Cup cup = new Cup(); //x
            //int�� �����͸� �����ϴ� �Ӽ��� ���� ��ü ���� 
            Cup<int> number = new Cup<int>();
            number.Contents = 1234;

            //string�� �����͸� �����ϴ� �Ӽ��� ���� ��ü ����
            Cup<string> text = new Cup<string>();
            text.Contents = "���ڿ� ������";

            Debug.Log($"{number.Contents}-{text.Contents}");

            //����
            Cup<Water> waterCup = new Cup<Water>();
            Water water = new Water();
            waterCup.Contents = water;
            Debug.Log(waterCup.Contents.ToString());
        }

    }
}
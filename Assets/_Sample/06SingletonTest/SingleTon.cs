using UnityEngine;
namespace Sample
{
    public class SingleTon
    {
        //Ŭ������ �ν��Ͻ��� ����(static) ���� ����
        private static SingleTon instance;

        public static SingleTon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingleTon();
                }
                return instance;
            }
        }

        //public�� �޼���� instance�� ���������� �����ϱ�
        /*public static SingleTon Instance()
        {
            if (instance == null)
            {
                instance = new SingleTon();
            }
            return instance;
        }*/

        /*
        ������ 
        public SingleTon()
        {
        
        }
        */
    }
}
/*
 ��Ŭ�� Ŭ���� ����
�ϳ��� �ν��Ͻ��� ���� : new�� 1���� ȣ��
Ŭ������ �ν��Ͻ��� ������ ���� ���� : ���� static ����

1. Singleton�� Ư¡
 ���� ���� ����: ��𼭵� �ν��Ͻ��� ���� ������ �� ����.
 �޸� ����: ���ʿ��� ��ü ������ ����, �ϳ��� �ν��Ͻ��� ����.
 ��ü �� ������ ����: ���� ��ũ��Ʈ���� ������ �ν��Ͻ��� ���.
*/
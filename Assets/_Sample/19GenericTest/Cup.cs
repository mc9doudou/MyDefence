using UnityEngine;
namespace Sample.Generic
{
    public class Water { }

    public class Coffee { }

    //Ŭ���� �̸�<T> ���·� ���׸� Ŭ���� �����ϱ�
    public class Cup<T>
    {
        public T Contents { get; set; }

        public void PrintDate(T data)
        {
            Debug.Log(data);
        }
    }
}
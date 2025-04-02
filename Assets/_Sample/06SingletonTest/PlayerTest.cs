using UnityEngine;
namespace Sample
{
    public class PlayerTest : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //static ��� ���� ȣ��
            //StaticTest.number = 10;
            //Debug.Log($"StaticTest.number:{StaticTest.number}");

            //�̱��� ���� Ŭ���� �ν��Ͻ� ����(ȣ��, ����)
            //SingleTon singleTon = new SingleTon();   //X
            //Debug.Log(singleTon.ToString());
            var singletonA = SingleTon.Instance;
            var singletonB = SingleTon.Instance;
            if (singletonA==singletonB)
            {
                Debug.Log(singletonA.ToString());
            }

            SingleTonTest.Instance.number = 99;
            Debug.Log($"SingleTonTest.Instance.number: {SingleTonTest.Instance.number}");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
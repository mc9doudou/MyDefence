using UnityEngine;
using System.Collections;
namespace Sample
{
    //Coroutin �Լ� ���� �׽�Ʈ
    public class CoroutinTest : MonoBehaviour
    {
        bool isCorou = false;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (isCorou == false)
            {
                Debug.Log("---------------------���� 1");

                StartCoroutine(CorouTest());
            }

            Debug.Log("���� 4");
        }

        //
        IEnumerator CorouTest()
        {
            isCorou = true;

            Debug.Log("---------------------���� 2");

            for (int i = 0; i < 3; i++)
            {
                Debug.Log($"---------------------���� 5 - {i}");
                yield return new WaitForSeconds(0.1f); // 0.1�� ����
                //Debug.Log("---------------------���� 5");
            }
            
            //������ ����
            Debug.Log("---------------------���� 3");

            yield return new WaitForSeconds(0.1f);  // 0.1�� ����
            Debug.Log("---------------------���� 6");
            //������ ����
        }


    }
}
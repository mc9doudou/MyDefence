using UnityEngine;
namespace Sample
{
    //MonoBehaviour�� ��ӹ��� Ŭ������ �̱��� ����
    public class SingleTonTest : MonoBehaviour
    {
        //Ŭ������ �ν��Ͻ� ������ ����(static)������ ���� 
        private static SingleTonTest instance;
        
        public static SingleTonTest Instance
        {
            get
            {
                
                return instance;
            }
        }

        private void Awake()
        {
            if(instance != null)
            {
                Destroy(gameObject);
                return;
            }
            instance = this;

            //�� ����� ������Ʈ ���� ����
            DontDestroyOnLoad(gameObject);
        }
        //�ʵ�
        public int number;

    }
}
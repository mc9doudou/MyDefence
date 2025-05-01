using UnityEngine;
namespace Sample.Generic
{
    //���׸� �̱��� Ŭ����
    public class Singleton<T> :MonoBehaviour where T : Singleton<T>
    {
        //Ŭ������ �ν��Ͻ� ������ ���� ������ ����
        private static T instance;

        //public�� �Ӽ��� instance�� ���������� �����ϱ�
        public static T Instance
        {
            get
            {
                return instance;
            }
        }
        //�̱��� ��ü ���翩�� üũ
        public static bool InstanceExist
        {
            get
            {
                return instance != null;
            }
        }

        protected virtual void Awake()
        {
            //�̱����� ���� ������Ʈ�� �̹� �����ϸ� 
            if (instance != null)
            {
                //�� ������Ʈ ų
                Destroy(gameObject);
                return;
            }
            instance = (T)this;
            //�� ����� ������Ʈ ���� ����
            //DontDestroyOnLoad(gameObject);
        }

        //������Ʈ ų�Ҷ� instance �ʱ�ȭ
        protected virtual void OnDestroy()
        {
            if (instance == this)
            {
                instance = null;
            }
        }
    }
}
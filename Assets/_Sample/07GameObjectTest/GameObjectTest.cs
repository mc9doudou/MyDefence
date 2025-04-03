using MyDefence;
using UnityEngine;
namespace Sample
{
    //(���̶�Űâ�� �ִ�)���ӿ�����Ʈ�� gameobject,transform �� �����ϴ� ��� 
    //���ӿ�����Ʈ�� GameObject, Transform Ŭ������ ��ü�� �������� ���
    public class GameObjectTest : MonoBehaviour
    {
        #region Field
        //2) ��ũ��Ʈ�� �ʵ� ����ο��� Transform, GameObject�� ��ü(�ν��Ͻ�)�� public��
        //������ �� ����Ƽ���� �ν����� â���� ���� ���� ������Ʈ�� �����Ѵ� 
        public Transform publicTransform;
        public GameObject publicObject;

        //3) ���� ������Ʈ�� tag�� �̿��Ͽ� GameObject�� ��ü(�ν��Ͻ�) �������� 
        private GameObject[] tagObjects; 
        private GameObject tagObject;

        //4) ������ ���ӿ�����Ʈ ������ Instantiate �Լ��� ��ȯ������ GameObject�� ��ü(�ν��Ͻ�) ��������
        public GameObject gameObjectPrefab;

        //5) ���� ����,��ɵ�� �����ִ� ���� ������Ʈ�� ��ü(�ν��Ͻ�) ��������
        // �θ� ���ӿ�����Ʈ�� ���� ���� ����
        // �θ� ������Ʈ�� �����Ͽ� �ڽ� ������Ʋ�� ��ü�� �����´�
        public Transform parentObject;
        private Transform[] childObjects;

        //6) static, �̱��� ���� ���������� ���� ������Ʈ�� ��ü(�ν��Ͻ�) ��������
        private SingleTonTest singletonTest;

        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //1) ���� ������Ʈ�� ��ũ��Ʈ �ҽ��� ������Ʈ�� �߰��Ͽ� ����(this.) �����´�
            //this.transform;
            //this.gameObject;

            //2) 
            //publicObject
            //publicTransform

            //3) FindGameObjectsWithTag(), FindGameObjectWithTag() ��ȯ������ 
            //���ӿ�����Ʈ�� ��ü�� �����´�
            //tagObjects = GameObject.FindGameObjectsWithTag("tagString");
            //tagObject = GameObject.FindGameObjectWithTag("tagString");

            //4) Instantiate(������ ������Ʈ, ������ġ, ����ȸ����)�� ��ȯ������ 
            //GameObject�� ��ü(�ν��Ͻ�) ��������
            //Instantiate(gameObjectPrefab,this.transform.transform,Quaternion.identity)

            //5)parentObject.childCount, parentObject.GetChild ��ȯ������ 
            //�ڽ� ���ӿ�����Ʈ���� ��ü�� �����´�
            /* childObjects = new Transform[parentObject.childCount];
             for (int i = 0; i < childObjects.Length; i++)
             {
                 childObjects[i] = parentObject.GetChild(i);
             }
            */
            //6) Ŭ�����̸�. ��ü�̸� ���� �����Ͽ� ���
            //SingleTonTest.Instance
            //SingleTonTest.Instance.number = 10;
            singletonTest = SingleTonTest.Instance;
            singletonTest.number = 10;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
/*
(���̶�Űâ�� �ִ�)���ӿ�����Ʈ�� gameobject,transform �� �����ϴ� ��� 
���ӿ�����Ʈ�� GameObject,Transform Ŭ������ ��ü�� �������� ���

1)  ���� ������Ʈ�� ��ũ��Ʈ �ҽ��� ������Ʈ�� �߰��Ͽ� ����(this.) �����´�
2)  ��ũ��Ʈ�� �ʵ� ����ο��� Transform, GameObject�� ��ü(�ν��Ͻ�)�� public��
    ������ �� ����Ƽ���� �ν����� â���� ���� ���� ������Ʈ�� �����Ѵ� 
3)  ���� ������Ʈ�� tag�� �̿��Ͽ� GameObject�� ��ü(�ν��Ͻ�) �������� 
    FindGameObjectsWithTag(), FindGameObjectWithTag() ��ȯ�� �޾ƿ´�
4)  Instantiate(������ ������Ʈ, ������ġ, ����ȸ����)�� ��ȯ������ 
    GameObject�� ��ü(�ν��Ͻ�) ��������
5)  ���� ����,��ɵ�� �����ִ� ���� ������Ʈ�� ��ü(�ν��Ͻ�) ��������
    �θ� ���ӿ�����Ʈ�� ���� ���� ����
    parentObject.childCount, parentObject.GetChild ��ȯ������ 
    �ڽ� ���ӿ�����Ʈ���� ��ü�� �����´�
6)  static : �̱��� ���� �������� �̿��Ͽ� ���� ������Ʈ ��ü(�ν��Ͻ�) ��������
    Ŭ�����̸�.�ν��Ͻ��̸�, Ŭ�����̸�.Instance 


*/
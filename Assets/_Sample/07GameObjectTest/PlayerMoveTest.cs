using UnityEngine;
namespace Sample
{
    // Ÿ������ �̵��Ѵ�
    public class PlayerMoveTest : MonoBehaviour
    {
        #region Field
        //�̵� �ӵ�
        public float moveSpeed = 5f;

        //Ÿ������ �̵��ϱ����ؼ��� Ÿ�� ������Ʈ�� transform������ �ʿ�
        public Transform target;
        public GameObject targetgo;

        //Ÿ�� ������Ʈ�� �پ� �ִ� TargetTest ������Ʈ(��ũ��Ʈ)�� ��ü�� GetComponent��  ��������  
        //private TargetTest targetTest;

        //Ÿ�� ������Ʈ�� �پ� �ִ� TargetTest ������Ʈ(��ũ��Ʈ)�� ��ü�� public��  ��������  
        public TargetTest targetTest;

        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //����
            //targetTest = target.GetComponent<TargetTest>();

            targetTest.SetA(60);
            Debug.Log($"targetTest.a{targetTest.GetA()}");
            //�ʱ�ȭ
            targetTest.b = 30;
            Debug.Log($"targetTest.b:{targetTest.b}");
        }

        // Update is called once per frame
        void Update()
        {
            //�̵�
            Vector3 dir = target.position - this.transform.position;
            this.transform.Translate(dir.normalized * Time.deltaTime * moveSpeed);

        }
    }
}
/*





*/

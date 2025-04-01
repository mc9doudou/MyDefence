using UnityEngine;
namespace Sample
{
    struct CBox
    {
        public float x; //box x��ǥ
        public float y; //box y��ǥ
        public float w; //width
        public float h; //height
    }
    struct CCircle
    {
        public float x; //box x��ǥ
        public float y; //box y��ǥ
        public float r; //������
    }
    public class HitTest : MonoBehaviour
    {
        #region Field
        //Ÿ�� ������Ʈ
        public Transform target;
        //�̵� �ӵ�
        public float moveSpeed = 100f;

        #endregion


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        
        //�Ű������� ���� �ΰ��� box�� �浹�ߴ��� üũ 
        //�浹�ϸ� true��ȯ , �浹���� �ʾ����� false ��ȯ 
        private bool CheckHitBox(CBox a,CBox b)
        {
            float dx = (a.x > b.x) ? (a.x - b.x) : (b.x - a.x);
            float dy = (a.y > b.y) ? (a.y - b.y) : (b.y - a.y);
            if(dx <= (a.w/2 + b.w / 2)&& dy<=(a.h/2 + b.h/2))
            {
                return true;
            }
            return false; 
        }
        
        private bool CheckHitCircle(CCircle a,CCircle b)
        {
            float dx = a.x - b.x;
            float dy = a.y - b.y;
            //�ο��� �Ÿ� ���ϱ�
            //float distance = Mathf.Sqrt(dx * dx + dy * dy);
            float distanceS = dx * dx + dy * dy;
            //�ο��� �Ÿ����� �ο��� �������� ���� ��ũ�� �浹
            if(distanceS >= (a.r + b.r)* (a.r + b.r))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //�������� �Ÿ��� �����Ÿ�(0.5f) �ȿ� ������ �浹 ����
        private bool CheckArrivePosition()
        {
            float distance = Vector3.Distance(target.position, this.transform.position);
            if (distance < 0.5f)
            {
                return true;
                //Debug.Log("�浹");
            }
            else
            {
                return false;
            }
        }
        //Ÿ������ �̵��Ҷ� Ÿ�ٱ��� �����Ÿ��� �������ӿ� �̵��ϴ� �Ÿ����� ������ �浹�̶�� ����
        private bool CheckPassPosition()
        {   
            //Ÿ�ٱ��� ���� �Ÿ�
            float distance = Vector3.Distance(target.position, this.transform.position);
            //�̹� �����ӿ� �̵��ϴ� �Ÿ�

            //dir.nomalized * Time.Deltatime * moveSpeed
            float distanceThisFrame = Time.deltaTime * moveSpeed;

            if (distance <= distanceThisFrame)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
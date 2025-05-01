using UnityEngine;
namespace MyDefence
{
    //���� �̵��� �����ϴ� Ŭ����
    public class EnemyMove : MonoBehaviour
    {
        //�ʵ�
        #region Field
        //���� üũ 
        private bool isArrive = false;

        //�̵� �ӵ�
        [HideInInspector]
        public float moveSpeed;

        //�̵� �ӵ� - origin
        [SerializeField]
        private float startMoveSpeed = 5f;

        //wayPoint ������Ʈ�� Ʈ������ ��ü
        private Transform target;
        //wayPoints �迭�� �ε���
        private int wayPointIndex = 0;
        #endregion

        #region Property
        //���� ���� üũ
        public bool IsArrive => isArrive;
        public float StartMoveSpeed => startMoveSpeed;
        #endregion

        void Start()
        {
            //�ʱ�ȭ
            wayPointIndex = 0;
            target = WayPoints.wayPoints[wayPointIndex];
            moveSpeed = startMoveSpeed;
        }
        void Update()
        {
            if (isArrive)
            {
                return;
            }
            //�̵� ����
            Vector3 dir = target.position - this.transform.position;
            transform.Translate(dir.normalized * Time.deltaTime * moveSpeed, Space.World);

            //target ���� ����
            float distance = Vector3.Distance(target.position, this.transform.position);
            if (distance <= 0.1f)
            {
                //���� Ÿ�� ����
                GetNextTarget();
            }
            //�ӵ� ����
            moveSpeed = startMoveSpeed;
        }
        void GetNextTarget()
        {
            //���� ���� ����
            if (wayPointIndex == WayPoints.wayPoints.Length - 1)
            {
                //���� ���� üũ
                isArrive = true;

                //�÷��̾��� ������ �Ҹ�
                PlayerStats.UseLife(1);

                //Enemy ī����
                WaveManager.enemyAlive--;
                //Debug.Log($"enemyAlive: {WaveManager.enemyAlive}");

                //���� VFX,SFX


                Destroy(this.gameObject, 1f);
                return;
            }

            wayPointIndex++;
            target = WayPoints.wayPoints[wayPointIndex];
        }
        public void Speed()
        {

        }
    }
}
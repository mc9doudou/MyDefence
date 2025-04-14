using UnityEngine;
namespace MyDefence
{
    public class Tower : MonoBehaviour
    {
        #region Field
        //���ݹ���
        public float attackRange = 7f;

        //���� ����� �� Ʈ������
        protected Transform target;
        protected Enemy targetEnemy;

        public float searchTimer = 0.5f;
        //private float countdown = 0f;
        //Enemy tag
        public string enemyTag = "Enemy";

        //�ͷ� ��� ȸ�� 
        public Transform partToRotate;
        public float turnSpeed = 5f;

        //shoot Ƽ�̸� - 1�ʿ� 1�߾� �߻�
        public float shootTimer = 1f;
        private float shootCountdown = 0;

        //Bullet �߻�
        //bullet ������
        public GameObject bulletPrefab;
        //�߻� ��ġ
        public Transform FirePoint;

        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //updateTarget �Լ��� ��� 0.1�ʸ��� �ݺ��ؼ� ȣ���ϵ�
            InvokeRepeating("UpdateTarget", 0f, 0.1f);
        }

        private void UpdateTarget()
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
            //�ּ� �Ÿ� ���ϴ� ���ÿ� �� �����ϱ�
            float minDistance = float.MaxValue;
            GameObject nearEnemy = null;

            foreach (var enemy in enemies)
            {
                float distance = Vector3.Distance(this.transform.position, enemy.transform.position);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    nearEnemy = enemy;
                }
            }

            //target = nearEnemy.transform;
            //Debug.Log($"minDistance : {minDistance}");
            if (nearEnemy != null && minDistance <= attackRange)
            {
                target = nearEnemy.transform;
                targetEnemy = target.GetComponent<Enemy>();
                //Debug.Log($"find target");

            }
            else
            {
                target = null;
                targetEnemy = null;
            }
        }
        // Update is called once per frame
        protected virtual void Update()
        {
            /*countdown += Time.deltaTime;
            if(countdown >= searchTimer)
            {
                UpdateTarget();
                countdown = 0f;
            }*/

            if (target == null)
                return;
            //Ÿ�� ���� 
            LockOn();
            //Ÿ������ �Ǹ� �ͷ��� 1�ʸ��� 1�߾� ���
            //->Debug.Log("Shoot!!!!!");
            shootCountdown += Time.deltaTime;
            if (shootCountdown >= shootTimer)
            {
                //Ÿ�̸� ��� - 1�߾� ���
                Shoot();

                //timer�ʱ�ȭ
                shootCountdown = 0f;
            }
        }
        //źȯ �߻�
        private void Shoot()
        { //Debug.Log("Shoot!!!");
            GameObject bulletGo = Instantiate(bulletPrefab, FirePoint.position, Quaternion.identity);
            Bullet bullet = bulletGo.GetComponent<Bullet>();
            if (bullet != null)
            {
                bullet.setTarget(target);
            }

        }

        protected void LockOn()
        {
            Vector3 dir = target.position - this.transform.position;
            Quaternion targetRotation = Quaternion.LookRotation(dir);
            Quaternion lookRotation = Quaternion.Lerp(partToRotate.rotation, targetRotation, Time.deltaTime * turnSpeed);
            Vector3 eulerRotation = lookRotation.eulerAngles;           //4�ڸ����� 3�ڸ� ���ϱ�
            partToRotate.rotation = Quaternion.Euler(0f, eulerRotation.y, 0f);
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(this.transform.position, attackRange);
        }
    }
}

using UnityEngine;
namespace MyDefence
{
    public class Tower : MonoBehaviour
    {
        #region Field
        //공격범위
        public float attackRange = 7f;

        //가장 가까운 적 트렌스폼
        protected Transform target;
        protected Enemy targetEnemy;

        public float searchTimer = 0.5f;
        //private float countdown = 0f;
        //Enemy tag
        public string enemyTag = "Enemy";

        //터렛 헤드 회전 
        public Transform partToRotate;
        public float turnSpeed = 5f;

        //shoot 티이머 - 1초에 1발씩 발사
        public float shootTimer = 1f;
        private float shootCountdown = 0;

        //Bullet 발사
        //bullet 프리팹
        public GameObject bulletPrefab;
        //발사 위치
        public Transform FirePoint;

        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //updateTarget 함수를 즉시 0.1초마다 반복해서 호출하디
            InvokeRepeating("UpdateTarget", 0f, 0.1f);
        }

        private void UpdateTarget()
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
            //최소 거리 구하는 동시에 적 구별하기
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
            //타겟 조준 
            LockOn();
            //타겟팅이 되면 터렛이 1초마다 1발씩 쏘기
            //->Debug.Log("Shoot!!!!!");
            shootCountdown += Time.deltaTime;
            if (shootCountdown >= shootTimer)
            {
                //타이머 기능 - 1발씩 쏘기
                Shoot();

                //timer초기화
                shootCountdown = 0f;
            }
        }
        //탄환 발사
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
            Vector3 eulerRotation = lookRotation.eulerAngles;           //4자리에서 3자리 구하기
            partToRotate.rotation = Quaternion.Euler(0f, eulerRotation.y, 0f);
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(this.transform.position, attackRange);
        }
    }
}

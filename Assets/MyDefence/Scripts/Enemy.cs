using UnityEngine;

namespace MyDefence
{
    //WayPoint들의 정보를 가져오는 클래스
    public class Enemy : MonoBehaviour
    {
        //필드
        #region Field
        //체력
        private float health;

        //체력 초기값 
        [SerializeField] private float startHealth = 100f;

        //이동 속도
        public float moveSpeed = 5f;

        //이동 속도 - Origin
        private float startMoveSpeed;

        private Vector3 targetPosition;
        //wayPoint 오브젝트의 트랜스폼 객체
        private Transform target;              
        //wayPoints 배열의 인덱스
        private int wayPointIndex = 0;

        //리워드 골드 
        [SerializeField] private int rewardGold = 50;

        //죽음 이펙트 프리펩
        public GameObject deathEffectPrefab;
        #endregion


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //초기화
            wayPointIndex = 0;
            target = WayPoints.wayPoints[wayPointIndex];
            health = startHealth;
            startMoveSpeed = moveSpeed;
        }

        // Update is called once per frame
        void Update()
        {
            //이동 구현
            Vector3 dir = target.position - this.transform.position;
            transform.Translate(dir.normalized * Time.deltaTime * moveSpeed, Space.World);

            //targetPosition 도착 판정
            float distance = Vector3.Distance(target.position, this.transform.position);
            if(distance <= 0.05f)
            {
                //Debug.Log("도착");
                GetNextTarget();
            }

            //속도 원복
            moveSpeed = startMoveSpeed;
        }
        //다음 타겟포지션 얻는
        void GetNextTarget()
        {
            if (wayPointIndex == WayPoints.wayPoints.Length - 1)
            {
                //Debug.Log("종점 도착!!!");
                //플레이어의 라이프 소모 
                PlayerStats.UseHealth(1);

                Destroy(this.gameObject);
                return;
            }
            wayPointIndex++;
            target = WayPoints.wayPoints[wayPointIndex];
            //Debug.Log($"wayPointIndex: {wayPointIndex}");

        }

        //데미지 처리
        public void TakeDamage(float damage)
        {
            //연산
            health -= damage;
            Debug.Log($"Now Health: {health}");

            //데미지 효과(VFX, SFX)

            //죽음 체크
            if (health <= 0)
            {
                Die();    
            }
        }

        //죽음 처리
        private void Die()
        {
            //보상, 벌
            //리워드로 50G 지급
            PlayerStats.AddMoney(rewardGold);

            //VFX, SFX
            //죽는 파티클 이펙트 만들어서 처리
            GameObject effectGo = Instantiate(deathEffectPrefab, this.transform.position, Quaternion.identity);
            Destroy(effectGo, 2f);

            //킬
            Destroy(this.gameObject,0f);
        }
    
        //매개변수를 입력받은 감속률 만큼 속도 감속
        public void Slow(float rate)
        {
            moveSpeed = startMoveSpeed * (1-rate);
        }

    }
}
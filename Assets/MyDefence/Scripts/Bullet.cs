using UnityEngine;
namespace MyDefence
{
    //탄환(발사체) 관리하는 클래스

    public class Bullet : MonoBehaviour
    {
        #region Field
        //타겟 오브젝트
        private Transform target;
        //이동속도
        public float moveSpeed = 70f;

        //타격effect 프리팹
        public GameObject bulletImpactPrefab;

        //공격 데미지 
        [SerializeField] protected float attackDamage = 50f;
        #endregion
        public void setTarget(Transform _target)
        {
            this.target = _target;
        }

        // Update is called once per frame
        void Update()
        {
            //이동 하기
            //dir.magnitude : 두 벡터간의 거리
            if (target == null)
            {
                Destroy(this.gameObject);
                return;
            }
            Vector3 dir = target.position - this.transform.position;    
            float distanceThisFrame = Time.deltaTime * moveSpeed;       //이번 프레임에 이동하는 거리
            if (dir.magnitude <= distanceThisFrame)
            {
                HitTarget();
                return;
            }

            transform.Translate(dir.normalized * Time.deltaTime * moveSpeed, Space.World);

            //타겟을 바라보며 이동하기
            transform.LookAt(target);
        }


        //타겟을 맞추고 적을 킬 - bullet
        protected virtual void HitTarget()
        {
            //타격 effect 효과
            GameObject effectGo = Instantiate(bulletImpactPrefab, this.transform.position,Quaternion.identity);
            Destroy(effectGo,2f);

            //타겟에게 대미지 주기
            Damage(target);

            //탄환 오브젝트 킬
            Destroy(this.gameObject);
        }
        
        //매개변수로 들어온 타겟에게 데미지 주기
        protected void Damage(Transform _target)
        {
            //타겟 게임오브젝트 킬 - 원샷/원킬
            //Destroy(_target.gameObject);

            //attackDamage 만큼 타겟의 Health 감산
            Enemy enemy = _target.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(attackDamage);
            }
        }
    }
}
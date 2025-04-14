using UnityEngine;
namespace MyDefence
{
    //로켓 관리하는 클래스 
    public class Rocket : Bullet
    {
        #region Field 
        //데미지 영역
        public float damageRange = 3.5f;

        //enemy 태그
        public string enemyTag = "Enemy";
        #endregion

        //타겟을 맞추어 폭발하여 데미지 영역에 있는 적 킬 - Rocket
        protected override void HitTarget()
        {
            GameObject effectGo = Instantiate(bulletImpactPrefab, this.transform.position, Quaternion.identity);
            Destroy(effectGo, 2f);

            //폭발
            Explosion();

            //로켓 오브젝트 킬
            Destroy(this.gameObject);
        }

        //폭발 - 데미지 영역에 있는 적을 찾아 킬
        //폭발지점으로 부터 각 Enemy들과의 거리를 구하여 거리에 반비례하여 데미지 주기
        private void Explosion()
        {
            Collider[] hitColliders = Physics.OverlapSphere(this.transform.position, damageRange);
            //데미지 영악안의 모든 충돌체에서 enemy 찾기
            foreach (var hitCollider in hitColliders)
            {
                if (hitCollider.tag == enemyTag)
                {
                    //거리구하기
                    float distance = Vector3.Distance(this.transform.position, hitCollider.transform.position);
                    //거리 미례로 데미지 구하기
                    float damage = attackDamage * ((damageRange-distance)/damageRange);

                    Enemy enemy = hitCollider.GetComponent<Enemy>();
                    if (enemy != null)
                    {
                        enemy.TakeDamage(damage);
                    }
                    /*//Destroy(hitCollider.gameObject);
                    Damage(hitCollider.transform);*/
                }
            }
        }

        //기즈모 데미지 영역 그리기
        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(this.transform.position,damageRange);
        }
    }
}


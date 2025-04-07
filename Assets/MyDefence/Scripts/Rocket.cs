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
        //public LayerMask enemyLayer;
        #endregion

        //타겟을 맞추어 폭발하여 데미지 영역에 있는 적 킬 - Rocket
        protected override void HitTarget()
        {
            GameObject effectGo = Instantiate(bulletImpactPrefab, this.transform.position, Quaternion.identity);
            Destroy(effectGo, 2f);

            //폭발
            Explosion();

            //탄환 오브젝트 킬
            Destroy(this.gameObject);
        }
        //폭발 - 데미지 영역에 있는 적을 찾아 킬
        private void Explosion()
        {
            Collider[] hitColliders = Physics.OverlapSphere(this.transform.position, damageRange);
            //데미지 영악안의 모든 충돌체에서 enemy 찾기
            foreach (var hitCollider in hitColliders)
            {
                if (hitCollider.tag == enemyTag)
                {
                    Destroy(hitCollider.gameObject);
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


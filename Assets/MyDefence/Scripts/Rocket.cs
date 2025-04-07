using UnityEngine;
namespace MyDefence
{
    //���� �����ϴ� Ŭ���� 
    public class Rocket : Bullet
    {
        #region Field 
        //������ ����
        public float damageRange = 3.5f;

        //enemy �±�
        public string enemyTag = "Enemy";
        //public LayerMask enemyLayer;
        #endregion

        //Ÿ���� ���߾� �����Ͽ� ������ ������ �ִ� �� ų - Rocket
        protected override void HitTarget()
        {
            GameObject effectGo = Instantiate(bulletImpactPrefab, this.transform.position, Quaternion.identity);
            Destroy(effectGo, 2f);

            //����
            Explosion();

            //źȯ ������Ʈ ų
            Destroy(this.gameObject);
        }
        //���� - ������ ������ �ִ� ���� ã�� ų
        private void Explosion()
        {
            Collider[] hitColliders = Physics.OverlapSphere(this.transform.position, damageRange);
            //������ ���Ǿ��� ��� �浹ü���� enemy ã��
            foreach (var hitCollider in hitColliders)
            {
                if (hitCollider.tag == enemyTag)
                {
                    Destroy(hitCollider.gameObject);
                }
            }
        }

        //����� ������ ���� �׸���
        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(this.transform.position,damageRange);
        }
    }
}


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
        #endregion

        //Ÿ���� ���߾� �����Ͽ� ������ ������ �ִ� �� ų - Rocket
        protected override void HitTarget()
        {
            GameObject effectGo = Instantiate(bulletImpactPrefab, this.transform.position, Quaternion.identity);
            Destroy(effectGo, 2f);

            //����
            Explosion();

            //���� ������Ʈ ų
            Destroy(this.gameObject);
        }

        //���� - ������ ������ �ִ� ���� ã�� ų
        //������������ ���� �� Enemy����� �Ÿ��� ���Ͽ� �Ÿ��� �ݺ���Ͽ� ������ �ֱ�
        private void Explosion()
        {
            Collider[] hitColliders = Physics.OverlapSphere(this.transform.position, damageRange);
            //������ ���Ǿ��� ��� �浹ü���� enemy ã��
            foreach (var hitCollider in hitColliders)
            {
                if (hitCollider.tag == enemyTag)
                {
                    //�Ÿ����ϱ�
                    float distance = Vector3.Distance(this.transform.position, hitCollider.transform.position);
                    //�Ÿ� �̷ʷ� ������ ���ϱ�
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

        //����� ������ ���� �׸���
        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(this.transform.position,damageRange);
        }
    }
}


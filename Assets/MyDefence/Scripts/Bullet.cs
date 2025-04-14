using UnityEngine;
namespace MyDefence
{
    //źȯ(�߻�ü) �����ϴ� Ŭ����

    public class Bullet : MonoBehaviour
    {
        #region Field
        //Ÿ�� ������Ʈ
        private Transform target;
        //�̵��ӵ�
        public float moveSpeed = 70f;

        //Ÿ��effect ������
        public GameObject bulletImpactPrefab;

        //���� ������ 
        [SerializeField] protected float attackDamage = 50f;
        #endregion
        public void setTarget(Transform _target)
        {
            this.target = _target;
        }

        // Update is called once per frame
        void Update()
        {
            //�̵� �ϱ�
            //dir.magnitude : �� ���Ͱ��� �Ÿ�
            if (target == null)
            {
                Destroy(this.gameObject);
                return;
            }
            Vector3 dir = target.position - this.transform.position;    
            float distanceThisFrame = Time.deltaTime * moveSpeed;       //�̹� �����ӿ� �̵��ϴ� �Ÿ�
            if (dir.magnitude <= distanceThisFrame)
            {
                HitTarget();
                return;
            }

            transform.Translate(dir.normalized * Time.deltaTime * moveSpeed, Space.World);

            //Ÿ���� �ٶ󺸸� �̵��ϱ�
            transform.LookAt(target);
        }


        //Ÿ���� ���߰� ���� ų - bullet
        protected virtual void HitTarget()
        {
            //Ÿ�� effect ȿ��
            GameObject effectGo = Instantiate(bulletImpactPrefab, this.transform.position,Quaternion.identity);
            Destroy(effectGo,2f);

            //Ÿ�ٿ��� ����� �ֱ�
            Damage(target);

            //źȯ ������Ʈ ų
            Destroy(this.gameObject);
        }
        
        //�Ű������� ���� Ÿ�ٿ��� ������ �ֱ�
        protected void Damage(Transform _target)
        {
            //Ÿ�� ���ӿ�����Ʈ ų - ����/��ų
            //Destroy(_target.gameObject);

            //attackDamage ��ŭ Ÿ���� Health ����
            Enemy enemy = _target.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(attackDamage);
            }
        }
    }
}
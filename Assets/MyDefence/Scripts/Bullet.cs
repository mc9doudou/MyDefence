using System.Runtime.CompilerServices;
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

        //public string enemyTag = "Enemy";
        
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
        }
        //Ÿ���� ���߰� ���� ų - bullet
        protected virtual void HitTarget()
        {
            //Ÿ�� effect ȿ��
            GameObject effectGo = Instantiate(bulletImpactPrefab, this.transform.position,Quaternion.identity);
            Destroy(effectGo,2f);

            //Ÿ�� ���ӿ�����Ʈ ų
            Destroy(target.gameObject);
            //źȯ ������Ʈ ų
            Destroy(this.gameObject);
        }
    }
}
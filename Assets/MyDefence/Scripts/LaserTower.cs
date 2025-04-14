using UnityEngine;

namespace MyDefence
{
    //������ Ÿ���� �����ϴ� Ŭ����
    public class LaserTower : Tower
    {
        #region Field
        public LineRenderer lineRenderer;  //�������� �׸���
        public ParticleSystem impactEffect;
        public Light impactLight;

        //�ʴ� 30������ �߰�
        [SerializeField]
        private float laserDamage = 30f;

        //�ӵ� 40% ����
        [SerializeField]
        private float slowRate = 0.4f;
        #endregion
        protected override void Update()
        {
            if (target == null)
            {
                if (lineRenderer.enabled)
                {
                    lineRenderer.enabled = false;
                    impactEffect.Stop();
                    impactLight.enabled = false;
                }
                return;
            }
                
            //Ÿ�� ���� 
            LockOn();

            Laser();
        }
        void Laser()
        {
            //������ ȿ�� �����ϱ�

            //�̹� �����ӿ� �ִ� ��������
            float damage = laserDamage * Time.deltaTime;
            
            if (targetEnemy != null)
            {
                targetEnemy.TakeDamage(damage);
                targetEnemy.Slow(slowRate);
            }

            //������ �� �׸���
            if (lineRenderer.enabled == false)
            {
                lineRenderer.enabled = true;
                impactEffect.Play();
                impactLight.enabled = true;
            }

            lineRenderer.SetPosition(0, FirePoint.position);
            lineRenderer.SetPosition(1, target.position);

            //Ÿ�ٿ��� FirePoint�� �ٶ󺸴� ���� ���ϱ�
            Vector3 dir = FirePoint.position - target.position;
            impactEffect.transform.position = target.position + (dir.normalized / 2f);
            impactEffect.transform.rotation = Quaternion.LookRotation(dir);
        }

        
    }

    
}

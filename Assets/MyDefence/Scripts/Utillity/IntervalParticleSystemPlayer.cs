using UnityEngine;
namespace MyDefence
{
    //Ÿ�̸� ����� �̿��Ͽ� Ư���ϴ� �ð�����(5,6��) ��ƼŬ ����Ʈ�� �÷����ϴ� ��� ����
    public class IntervalParticleSystemPlayer : MonoBehaviour
    {
        #region Field
        //Ÿ�̸� �ð����� �÷����� ��ƼŬ �ý���
        public ParticleSystem particleSystemToPlay;

        //Ÿ�̸�
        public float interval;
        private float countdown = 0f;
        #endregion
        private void Start()
        {
            //�ʱ�ȭ 
            countdown = 0f;
        }

        private void Update()
        {
            countdown += Time.deltaTime;
            if (countdown >= interval)
            {
                //Ÿ�̸� ��� ����
                PlayParticleEffect();
                //Ÿ�̸� �ʱ�ȭ
                countdown = 0f;
            }
        }
        
        void PlayParticleEffect() 
        {
            if (particleSystemToPlay == null)
                return;
              
            particleSystemToPlay.Play();
        }
        

}
}
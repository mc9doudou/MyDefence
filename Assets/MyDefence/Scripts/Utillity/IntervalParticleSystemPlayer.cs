using UnityEngine;
namespace MyDefence
{
    //타이머 기능을 이용하여 특정하는 시간마다(5,6초) 파티클 이팩트를 플레이하는 기능 구현
    public class IntervalParticleSystemPlayer : MonoBehaviour
    {
        #region Field
        //타이머 시간마다 플레이할 파티클 시스템
        public ParticleSystem particleSystemToPlay;

        //타이머
        public float interval;
        private float countdown = 0f;
        #endregion
        private void Start()
        {
            //초기화 
            countdown = 0f;
        }

        private void Update()
        {
            countdown += Time.deltaTime;
            if (countdown >= interval)
            {
                //타이머 기능 구현
                PlayParticleEffect();
                //타이머 초기화
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
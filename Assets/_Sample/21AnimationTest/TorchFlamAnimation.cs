using UnityEngine;
using System.Collections;
namespace Sample
{
    public class TorchFlamAnimation : MonoBehaviour
    {
        #region Variables
        //라이트 레거시 애니메이션
        public Animation animation;

        [SerializeField]private float animTimer = 1f;
        private float countdown = 0f;
        //애니메이션 인덱스
        private int lightMode;
        #endregion

        private void Start()
        {
            lightMode = 0;
            
            //InvokeRepeating("FlameAnimations", 0f, 1f);
        }

        private void Update()
        {
            //1초 마다 3개중 랜덤하게 애니메이션을 플레이
            /*countdown += Time.deltaTime;
            if (countdown >= animTimer)
            {
                //타이머 기능 호출
                FlameAnimations();

                //타이머 초기화
                countdown = 0f;
            }*/

            //코루틴으로 
            if (lightMode == 0)
            {
                StartCoroutine(PlayAnimation());
            }
        }

        void FlameAnimations()
        {
            lightMode = Random.Range(1, 4);     //0, 1, 2
            switch (lightMode)
            {
                case 1:
                    animation.Play("FlameAnim01");
                    break; 
                case 2:
                    animation.Play("FlameAnim02");
                    break; 
                case 3:
                    animation.Play("FlameAnim03");
                    break;
            }
        }
        IEnumerator PlayAnimation()
        {
            lightMode = Random.Range(1, 4);     //0, 1, 2
            switch (lightMode)
            {
                case 1:
                    animation.Play("FlameAnim01");
                    break;
                case 2:
                    animation.Play("FlameAnim02");
                    break;
                case 3:
                    animation.Play("FlameAnim03");
                    break;
            }
            yield return new WaitForSeconds(0.99f);

            lightMode = 0;
        }

    }
}

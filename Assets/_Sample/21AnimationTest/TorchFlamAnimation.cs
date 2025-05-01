using UnityEngine;
using System.Collections;
namespace Sample
{
    public class TorchFlamAnimation : MonoBehaviour
    {
        #region Variables
        //����Ʈ ���Ž� �ִϸ��̼�
        public Animation animation;

        [SerializeField]private float animTimer = 1f;
        private float countdown = 0f;
        //�ִϸ��̼� �ε���
        private int lightMode;
        #endregion

        private void Start()
        {
            lightMode = 0;
            
            //InvokeRepeating("FlameAnimations", 0f, 1f);
        }

        private void Update()
        {
            //1�� ���� 3���� �����ϰ� �ִϸ��̼��� �÷���
            /*countdown += Time.deltaTime;
            if (countdown >= animTimer)
            {
                //Ÿ�̸� ��� ȣ��
                FlameAnimations();

                //Ÿ�̸� �ʱ�ȭ
                countdown = 0f;
            }*/

            //�ڷ�ƾ���� 
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

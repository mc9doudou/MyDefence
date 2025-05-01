using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
namespace MyDefence
{
    //�� ���۽� ���̵���, �� ����� ���̵� �ƿ� ȿ�� ����
    public class SceneFader : MonoBehaviour
    {
        #region Field
        //���̴� �̹���
        public Image img;

        //�ִϸ��̼� Ŀ��
        public AnimationCurve curve;
        #endregion

        private void Start()
        {
            //���̵��� 
            StartCoroutine(FadeIn());
            //StartCoroutine(FadeOut());
        }

        private void Update()
        {
            
        }
        //�ڷ�ƾ���� ���� 
        //FadeIn : 1�ʵ��� : �������� ���� ��������(�̹��� ���İ� a:1 -> a:0)
        IEnumerator FadeIn()
        {
            float t = 1f;

            while (t > 0)
            {
                t -= Time.deltaTime;
                float a = curve.Evaluate(t);

                img.color = new Color(0f, 0f, 0f, t);

                yield return 0f;    //�� ������ ���� 
            }
        }
        
        //FadeOut : 1�ʵ��� : ������ ���� �������� (�̹��� ���İ� a:0 -> a:1)
        IEnumerator FadeOut()
        {
            float p = 0f;

            while (p < 1)
            {
                p += Time.deltaTime;
                float a = curve.Evaluate(p);
                img.color = new Color(0f, 0f, 0f, a);

                yield return 1f;
            }
        }

        //�ٸ� ������ �̵��� FadeOutȿ���� LoadScene ���� �̵�
        IEnumerator FadeOut(string sceneName)
        {
            //Fadeȿ����

            float p = 0f;

            while (p < 1f)
            {
                p += Time.deltaTime;
                float a = curve.Evaluate(p);
                img.color = new Color(0f, 0f, 0f, a);

                yield return 0f;
            }

            //�� �̵�
            if (sceneName != "")
            {
                SceneManager.LoadScene(sceneName);
            }
        }
        //FadeOut ȿ�� �� �Ű������� ���� ������ LoadScene���� �̵� 
        //�ٸ� �� �̵�
        public void FadeTo(string sceneName = "")
        {
            StartCoroutine(FadeOut(sceneName));
        }
    }
}
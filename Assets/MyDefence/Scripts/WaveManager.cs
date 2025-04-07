using UnityEngine;
using System.Collections;
using TMPro;

namespace MyDefence
{

    //Enemy ����/ ���̺긦 �����ϴ� ��ũ��Ʈ
    public class WaveManager : MonoBehaviour
    {
        #region Field
        //�� ������
        public GameObject enemyprefab;
        //�� ������ġ
        public Transform startPoint;

        //Ƽ�̸�
        public float waveTimer = 3f;
        private float countdown = 0f;

        //���̺� ī��Ʈ
        private int waveCount = 0;

        //UI Countdown Text
        public TextMeshProUGUI countdownText;

        #endregion
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
           

        }
        void Update()
        {
            //Ÿ�̸� ����
            countdown += Time.deltaTime;

            if (countdown >= waveTimer)
            {
                //Ÿ�̸� ���
                StartCoroutine(SpawnWave());

                //Ÿ�̸� �ʱ�ȭ
                countdown = 0f;
            }

            //UI
            //countdownText.text = countdown.ToString();
            countdownText.text = Mathf.Round(countdown).ToString(); 

        }

        //���̺�
        IEnumerator SpawnWave() 
        {
            waveCount++;
            //Debug.Log($"waveCount: {waveCount}");
            if (waveCount < 30)
            {
                for (int i = 0; i < waveCount; i++)
                {
                    SpawnEnemy();

                    //�����ð� ����
                    yield return new WaitForSeconds(0.5f);
                }
            }
        }

        //���� ������ enemy ����
        void SpawnEnemy()
        {
            Instantiate(enemyprefab, startPoint.position, Quaternion.identity);
        }
    }
}


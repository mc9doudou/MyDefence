using UnityEngine;
using System.Collections;
using TMPro;
namespace MyDefence
{
    //Enemy 스폰/ 웨이브를 관리하는 스크립트
    public class WaveManager : MonoBehaviour
    {
        #region Field
        //적 프리팹
        public GameObject enemyprefab;
        //적 스폰위치
        public Transform startPoint;

        //티이머
        public float waveTimer = 3f;
        private float countdown = 0f;

        //웨이브 카운트
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
            //타이머 구현
            countdown += Time.deltaTime;
            if (countdown >= waveTimer)
            {
                //타이머 기능
                StartCoroutine(SpawnWave());
                //타이머 초기화
                countdown = 0f;
            }
            //UI
            //countdownText.text = countdown.ToString();
            countdownText.text = Mathf.Round(countdown).ToString(); 
        }
        //웨이브
        IEnumerator SpawnWave() 
        {
            waveCount++;
            //라운드 카운트
            PlayerStats.Rounds++;
                for (int i = 0; i < waveCount; i++)
                {
                    SpawnEnemy();
                    //일정시간 지연
                    yield return new WaitForSeconds(0.5f);
                }
        }
        //시작 지점에 enemy 스폰
        void SpawnEnemy()
        {
            Instantiate(enemyprefab, startPoint.position, Quaternion.identity);
        }
    }
}


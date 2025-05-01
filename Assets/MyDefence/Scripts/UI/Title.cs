using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

namespace MyDefence
{
    // 타이머 클래스
    //타이틀 씬 관리하는 클래스
    public class Title : MonoBehaviour
    {
        #region Field
        //애니키 UI 오브젝트
        public GameObject anyKey;

        //다음 이동하는 씬 이름
        [SerializeField]
        private string loadToScene = "MainMenu";
        //애니 UI 를 보여주고 있는지 체크
        private bool isShow = false;

        //타이머
        [SerializeField]
        private float titleTimer = 2f;
        private float countdown = 0f;

        [SerializeField]
        private float SpawnDelay = 2f;      //생성 딜레이 2초
        private float spawnTime;            //몬스터 생성한 시간 저장

        private bool isOneTime = false;//실행 안했으면 false,
        //한번이라도 실행했으면 true

        #endregion

        void Start()
        {
            //초기화 
            //countdown = 0;
            //spawnTime = Time.time;
            isShow = false;

            //InvokeRepeating 처음 시작시 1초 딜레이후 2초 간격으로 몬스터 생성
            //InvokeRepeating("SpawnMonster", 1f , 2f);

            //지연 - Invoke
            //Invoke("SpawnMonster", SpawnDelay);

            //지연 - Corountine 
            //StartCoroutine(Spawn());
            StartCoroutine(titleProcess());


        }
        void Update()
        {
            /*//Time.deltaTime 더하기 누적 반복 타이머
            countdown += Time.deltaTime;
            if (countdown >= titleTimer)
            {
                //반복 실행문
                GotoMenu();

                //타이머 초기화
                countdown = 0f;
            }*/

            //Time.deltaTime 빼기 누적 반복 타이머
            /*countdown -= Time.deltaTime;
            if (countdown <= 0)
            {
                //반복 실행문
                GotoMenu();

                //타이머 초기화
                countdown = titleTimer;
            }*/

            //Time.time 현재시간을 저장하고 딜레이 시간 만큼 지났는지 체크
            /*if ((spawnTime + SpawnDelay) <= Time.time)
            {
                //반복 실행문
                SpawnMonster();

                //타이머 초기화 : 현재시간을 저장
                spawnTime = Time.time;
            }*/


            /*if (isOneTime == false )
            {
                countdown += Time.deltaTime;
                if (countdown >= titleTimer)
                {
                    GotoMenu();

                    countdown = 0f;
                    isOneTime = true;
                }
            }*/

            //아무 키를 누르면 메임메뉴 씬 이동로 이동
            if (Input.anyKeyDown && isShow)
            {
                //현재 대기하고 있는 모든 코루팀 함수 정지 
                StopAllCoroutines();

                GotoMenu();
            }
        }
        IEnumerator titleProcess()
        {
            yield return new WaitForSeconds(titleTimer);
            ShowAnyKey();

            yield return new WaitForSeconds(10f);
            GotoMenu();
        }

        private void ShowAnyKey()
        {
            isShow = true;
            anyKey.SetActive(true);
        }

        private void GotoMenu()
        {
            //Debug.Log("Go to Menu!");
            SceneManager.LoadScene(loadToScene);
        }
        private void SpawnMonster()
        {
            GotoMenu();
        }
        /*IEnumerator Spawn()
        {
            //spawndelay 만큼 딜레이
            yield return new WaitForSeconds(SpawnDelay);
            SpawnMonster();
        }*/


        
    }
}
/*
타이머 
- 1회성 : 반복실행중 1회 실행하고 더이상 반복하지 않는다

- 반복
: 2초마다 메인메뉴 보내기

*/
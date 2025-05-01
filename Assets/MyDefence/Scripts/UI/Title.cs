using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

namespace MyDefence
{
    // Ÿ�̸� Ŭ����
    //Ÿ��Ʋ �� �����ϴ� Ŭ����
    public class Title : MonoBehaviour
    {
        #region Field
        //�ִ�Ű UI ������Ʈ
        public GameObject anyKey;

        //���� �̵��ϴ� �� �̸�
        [SerializeField]
        private string loadToScene = "MainMenu";
        //�ִ� UI �� �����ְ� �ִ��� üũ
        private bool isShow = false;

        //Ÿ�̸�
        [SerializeField]
        private float titleTimer = 2f;
        private float countdown = 0f;

        [SerializeField]
        private float SpawnDelay = 2f;      //���� ������ 2��
        private float spawnTime;            //���� ������ �ð� ����

        private bool isOneTime = false;//���� �������� false,
        //�ѹ��̶� ���������� true

        #endregion

        void Start()
        {
            //�ʱ�ȭ 
            //countdown = 0;
            //spawnTime = Time.time;
            isShow = false;

            //InvokeRepeating ó�� ���۽� 1�� �������� 2�� �������� ���� ����
            //InvokeRepeating("SpawnMonster", 1f , 2f);

            //���� - Invoke
            //Invoke("SpawnMonster", SpawnDelay);

            //���� - Corountine 
            //StartCoroutine(Spawn());
            StartCoroutine(titleProcess());


        }
        void Update()
        {
            /*//Time.deltaTime ���ϱ� ���� �ݺ� Ÿ�̸�
            countdown += Time.deltaTime;
            if (countdown >= titleTimer)
            {
                //�ݺ� ���๮
                GotoMenu();

                //Ÿ�̸� �ʱ�ȭ
                countdown = 0f;
            }*/

            //Time.deltaTime ���� ���� �ݺ� Ÿ�̸�
            /*countdown -= Time.deltaTime;
            if (countdown <= 0)
            {
                //�ݺ� ���๮
                GotoMenu();

                //Ÿ�̸� �ʱ�ȭ
                countdown = titleTimer;
            }*/

            //Time.time ����ð��� �����ϰ� ������ �ð� ��ŭ �������� üũ
            /*if ((spawnTime + SpawnDelay) <= Time.time)
            {
                //�ݺ� ���๮
                SpawnMonster();

                //Ÿ�̸� �ʱ�ȭ : ����ð��� ����
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

            //�ƹ� Ű�� ������ ���Ӹ޴� �� �̵��� �̵�
            if (Input.anyKeyDown && isShow)
            {
                //���� ����ϰ� �ִ� ��� �ڷ��� �Լ� ���� 
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
            //spawndelay ��ŭ ������
            yield return new WaitForSeconds(SpawnDelay);
            SpawnMonster();
        }*/


        
    }
}
/*
Ÿ�̸� 
- 1ȸ�� : �ݺ������� 1ȸ �����ϰ� ���̻� �ݺ����� �ʴ´�

- �ݺ�
: 2�ʸ��� ���θ޴� ������

*/
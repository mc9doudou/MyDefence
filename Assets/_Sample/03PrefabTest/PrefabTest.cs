using System.Collections;
using UnityEngine;

namespace Sample
{
    

    public class PrefabTest : MonoBehaviour
    {
        //Ÿ�� ������
        public GameObject tileprefab;


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //
            //Vector3 position = new Vector3(0f, 0f, 0f);    //������ ��ġ ����

            //Instantiate(tileprefab, position, Quaternion.identity);

            //[2]n(10) *m(10) ���� - 5 *5 ����  7 *7 ����
            //GenerateMap(5,5);
            //GenerateMap2(5,5);

            //[3] Ÿ���� ���� -
            //x��ǥ�� 0~50f ������ ������, y = 0, z��ǥ�� -50f~0 ������ ������ 
            /*for (int i = 0; i < 10; i++)
            {
                GenerateRandomMapTile();
            }*/

            //[4] Ÿ���� 10�� ����, Ÿ���ϳ� �����Ҷ����� ������ 0.2��
            //�ڷ�ƾ Coroutine - ����
            StartCoroutine(GenerateRandomMap());
        }

        void GenerateMap(int row,int column)
        {
            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < column; y++)
                {
                    Vector3 position = new Vector3(x * 5f, 0f, y * -5f);
                    Instantiate(tileprefab, position, Quaternion.identity);
                }
                
            }
        }


        void GenerateMap2(int row, int column)
        {
            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < column; y++)
                {
                    
                    GameObject go = Instantiate(tileprefab,this.transform);
                    go.transform.position = new Vector3(x * 5f, 0f, y * -5f);
                    //Vector3 position = new Vector3(x * 5f, 0f, y * -5f);
                }

            }
        }
    
        void GenerateRandomMapTile()
        {
            float xPos = Random.Range(0f, 50f);
            float zPos = Random.Range(-50f, 0f);
            Vector3 position = new Vector3(xPos,0f,zPos);
            Instantiate(tileprefab, position, Quaternion.identity);

        }
    
        IEnumerator GenerateRandomMap()
        {
            for (int i = 0; i < 10; i++)
            {
                
                Vector3 position = new Vector3(Random.Range(0f, 50f), 0f, Random.Range(-50f, 0f));
                Instantiate(tileprefab, position, Quaternion.identity);

                //0.2�� ������
                yield return new WaitForSeconds(0.2f);
            }
        }


    }
}
/*
Ÿ���� 10x10���� ��ġ�غ�����



*/
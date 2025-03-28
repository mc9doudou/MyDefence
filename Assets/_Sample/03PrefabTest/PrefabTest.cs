using System.Collections;
using UnityEngine;

namespace Sample
{
    

    public class PrefabTest : MonoBehaviour
    {
        //타일 프리팹
        public GameObject tileprefab;


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //
            //Vector3 position = new Vector3(0f, 0f, 0f);    //생성할 위치 지정

            //Instantiate(tileprefab, position, Quaternion.identity);

            //[2]n(10) *m(10) 생성 - 5 *5 생성  7 *7 생성
            //GenerateMap(5,5);
            //GenerateMap2(5,5);

            //[3] 타일을 생성 -
            //x좌표를 0~50f 사이의 렌덤값, y = 0, z좌표를 -50f~0 사이의 렌덤값 
            /*for (int i = 0; i < 10; i++)
            {
                GenerateRandomMapTile();
            }*/

            //[4] 타일을 10개 생성, 타일하나 생성할때마다 딜레이 0.2초
            //코루틴 Coroutine - 지연
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

                //0.2초 딜레이
                yield return new WaitForSeconds(0.2f);
            }
        }


    }
}
/*
타일을 10x10으로 배치해보세요



*/
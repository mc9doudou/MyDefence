using UnityEngine;

namespace MyDefence
{
    //WayPoint들의 정보를 가져오는 클래스
    public class Enemy : MonoBehaviour
    {
        //필드
        #region Field
        //이동 속도
        public float speed = 5f;

        private Vector3 targetPosition;
        //wayPoint 오브젝트의 트랜스폼 객체
        private Transform target;              
        //wayPoints 배열의 인덱스
        private int wayPointIndex = 0;
        #endregion


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //초기화
            wayPointIndex = 0;
            target = WayPoints.wayPoints[wayPointIndex];
        }

        // Update is called once per frame
        void Update()
        {
            //이동 구현
            Vector3 dir = target.position - this.transform.position;
            transform.Translate(dir.normalized * Time.deltaTime * speed, Space.World);

            //targetPosition 도착 판정
            float distance = Vector3.Distance(target.position, this.transform.position);
            if(distance <= 0.05f)
            {
                //Debug.Log("도착");
                GetNextTarget();
                /*wayPointIndex++;
                if(wayPointIndex<WayPoints.wayPoints.Length)
                {
                    targetPosition = WayPoints.wayPoints[wayPointIndex].position;
                }
                else
                {
                    Debug.Log("종점 도착!!!");
                    Destroy(gameObject);
                }*/

            }

        }
        //다음 타겟포지션 얻는
        void GetNextTarget()
        {
            if (wayPointIndex == WayPoints.wayPoints.Length - 1)
            {
                //Debug.Log("종점 도착!!!");
                Destroy(this.gameObject);
                return;
            }
            wayPointIndex++;
            target = WayPoints.wayPoints[wayPointIndex];
            //Debug.Log($"wayPointIndex: {wayPointIndex}");

        }
    
    }
}
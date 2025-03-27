using UnityEditor.Rendering;
using UnityEngine;
namespace MyDefence
{


    public class Enemy : MonoBehaviour
    {
        //필드 
        #region Field
        private float speed = 10f;
        private Vector3 targetPosition;
        private int wayPointIndex = 0;

        #endregion

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {   
            //초기화 
            wayPointIndex = 0;
            targetPosition = WayPoints.wayPoints[wayPointIndex].position;
            
        }

        // Update is called once per frame
        void Update()
        {
            //이동구현
            Vector3 dir = targetPosition - this.transform.position;
            transform.Translate(dir.normalized * Time.deltaTime * speed, Space.World);
            
            float distance = Vector3.Distance(targetPosition, this.transform.position);
            if(distance <= 0.05f)
            {
                //Debug.Log("1지점 도착");
                wayPointIndex++;
                if(wayPointIndex<WayPoints.wayPoints.Length)
                {
                    targetPosition = WayPoints.wayPoints[wayPointIndex].position;
                }
                else
                {
                    Debug.Log("종점 도착!!!");
                    Destroy(gameObject);
                }

            }
            


        }
    }
}
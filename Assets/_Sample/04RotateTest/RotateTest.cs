using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
namespace Sample
{
    public class RotateTest : MonoBehaviour
    {
        #region field
        private float x;
        //회전속도
        public float turnSpeed = 5f;
        //이동속도
        public float moveSpeed = 5f;

        //타겟 오브젝트
        public Transform target;

        #endregion

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //this.gameObject
            //this.transform.rotation = Quaternion.Euler(90f, 0f, 0f);    //x축 기준 회전
            //this.transform.rotation = Quaternion.Euler(0f, 90f, 0f);    //y축 기준 회전
            //this.transform.rotation = Quaternion.Euler(0f, 0f, 90f);    //z축 기준 회전
        
        
        }

        // Update is called once per frame
        void Update()
        {
            //y축 기준으로 +방향 회전하기 
            x += 1;
            //this.transform.rotation = Quaternion.Euler(0f, x, 0f);
            //y축으로 + 회전
            //this.transform.rotation = Quaternion.Euler(x, 0f, 0f);
            //x축으로 + 회전
            //this.transform.rotation = Quaternion.Euler(0f, 0f, x);
            //z축으로 + 회전

            //y축기준으로 속도 5로 회전
            //x += Time.deltaTime * 5;
            //this.transform.rotation = Quaternion.Euler(0f, x, 0f);

            // 축 기준으로  turnSpeed속도 회전
            //this.transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed);
            //this.transform.Rotate(Vector3.right * Time.deltaTime * turnSpeed);
            //this.transform.Rotate(Vector3.forward * Time.deltaTime * turnSpeed);

            //타겟 오브젝트 중심으로 회전하기
            //transform.RotateAround(target.transform.position, Vector3.up, 360 * Time.deltaTime);

            /* //원하는 방향으로 회전하기 
             //Vector3 dir = 타겟위치 - 현재위치;
             Vector3 dir = target.position - this.transform.position;
             //방향 vector로 부터 target방향 보는 화전값 구하기
             Quaternion targetRotation = Quaternion.LookRotation(dir);
             //transform.rotation = lookRotation;
             //this.transform.rotation = lookRotation; 
             Quaternion lookRotation = Quaternion.Lerp(this.transform.rotation,targetRotation,Time.deltaTime*turnSpeed);
             Vector3 eulerRotation = lookRotation.eulerAngles; // eulerRotation.x, eulerRotation.y, eulerRotation.z
             //y축연산을 위해 Euler값 얻어오기 

             //Euler값으로 Quaternion(쿼터니언)값 구하기
             this.transform.rotation = Quaternion.Euler(0f,eulerRotation.y,0f);*/

            //회전 + 이동
            //타겟 방향 구하기
            Vector3 dir = target.position - this.transform.position;
            //방향 vector를 바라보는 화전값 적용하기
            this.transform.rotation = Quaternion.LookRotation(dir);
            this.transform.Translate(dir.normalized * Time.deltaTime * moveSpeed, Space.World);
            //this.transform.Translate(dir.normalized * Time.deltaTime * moveSpeed, Space.Self);

        }
    }
}
/*
Quaternion(쿼터니언)
Euler(오일러)

[1]Euler(오일러)값으로 Quaternion(쿼터니언)값 구하기
3자리에서 4자리 값 구하기
Quaternion 값 = Quaternion.Euler (Euler X, Euler Y, Euler Z);

[2]Quaternion(쿼터니언)값에서 Euler(오일러)값 구하기
4자리에서 3자리 값 구하기
Vector3 angles = Quaternion(transform.rotation).eulerAngles;
*/
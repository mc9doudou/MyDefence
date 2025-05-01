using UnityEngine;
namespace Solid
{
    //탈것 기능 구현 클래스
    public class Vehicle : MonoBehaviour
    {
        #region Field
        public float speed;
        public Vector3 direction;
        #endregion
        
        public virtual void GoForward()
        {
            //앞으로 직진 구현
        }

        public virtual void GoBack()
        {
            //뒤로 후진 구현 
        }

        public virtual void Turnleft()
        {
            //좌회전 구현
        }

        public virtual void Turnright()
        {
            //우회전 구현
        }
    }

    //Vehicle을 상속받은 Car 클래스
    public class Car : Vehicle
    {
        public override void GoForward()
        {
            //자동차가 전진한다 구현
            //base.GoForward();
        }

        public override void GoBack()
        {
            //자동차가 후진한다 구현
            //base.GoBack();
        }

        public override void Turnleft()
        {
            //자동차가 좌회전 한다
            //base.Turnleft();
        }

        public override void Turnright()
        {
            //자동차가 우회전 한다
            //base.Turnright();
        }
    }

    public class train : Vehicle
    {
        public override void GoForward()
        {
            //자동차가 전진한다 구현
        }

        public override void GoBack()
        {
            //자동차가 후진한다 구현
        }

        public override void Turnleft()
        {
            //empty
        }
        private void Update()
        {
            Turnleft();
            Turnright();
        }

    }



}
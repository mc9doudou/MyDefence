using UnityEngine;
namespace Solid
{
    //철도위를 이동하는 탈것
    public class RailVehicle : MonoBehaviour,IMoveable
    {
        public virtual void GoForward()
        {
            //철도위를 전진한다 기능 구현
        }

        public virtual void GoBack()
        {
            //철도위를 후진한다 기능 구현
        }
    }

    //RailVehicle 상속받는 기차 구현
    public class TrainR : RailVehicle
    {
        public void Train()
        {

        }
    }

    public class SubwayR : RailVehicle
    {
        public void Subway()
        {

        }
    }
}
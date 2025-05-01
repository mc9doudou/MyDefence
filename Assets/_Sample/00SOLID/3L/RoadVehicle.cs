using UnityEngine;
namespace Solid
{
    //도로위를 달리는 탈것
    public class RoadVehicle : MonoBehaviour, ITurnable, IMoveable
    {
        public void GoBack()
        {
            //도로를 후진하는 기능 구현
        }

        public void GoForward()
        {
            //도로를 전진하는 기능 구현
        }

        public void TurnLeft()
        {
            //도로를 좌회전하는 기능 구현
        }

        public void TurnRight()
        {
            //도로를 우회전하는 기능 구현
        }
    }
    public class CarR : RoadVehicle
    {

    }

    public class Truck: RoadVehicle
    {

    }
}
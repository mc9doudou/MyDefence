using UnityEngine;
namespace Solid
{
    //�������� �޸��� Ż��
    public class RoadVehicle : MonoBehaviour, ITurnable, IMoveable
    {
        public void GoBack()
        {
            //���θ� �����ϴ� ��� ����
        }

        public void GoForward()
        {
            //���θ� �����ϴ� ��� ����
        }

        public void TurnLeft()
        {
            //���θ� ��ȸ���ϴ� ��� ����
        }

        public void TurnRight()
        {
            //���θ� ��ȸ���ϴ� ��� ����
        }
    }
    public class CarR : RoadVehicle
    {

    }

    public class Truck: RoadVehicle
    {

    }
}
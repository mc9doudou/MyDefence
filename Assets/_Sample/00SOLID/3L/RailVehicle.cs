using UnityEngine;
namespace Solid
{
    //ö������ �̵��ϴ� Ż��
    public class RailVehicle : MonoBehaviour,IMoveable
    {
        public virtual void GoForward()
        {
            //ö������ �����Ѵ� ��� ����
        }

        public virtual void GoBack()
        {
            //ö������ �����Ѵ� ��� ����
        }
    }

    //RailVehicle ��ӹ޴� ���� ����
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
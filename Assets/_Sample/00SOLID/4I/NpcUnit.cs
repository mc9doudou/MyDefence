using UnityEngine;
namespace Solid.Interface
{
    //NPC ����: �̵� ���, 
    public class NpcUnit : MonoBehaviour, IMoveable
    {
        public float MoveSpeed { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public float Acceleation { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void GoBack()
        {
            throw new System.NotImplementedException();
        }

        public void GoForward()
        {
            throw new System.NotImplementedException();
        }

        public void TurnLeft()
        {
            throw new System.NotImplementedException();
        }

        public void TurnRight()
        {
            throw new System.NotImplementedException();
        }
    }
}
using UnityEngine;
namespace Solid.Interface
{
    //�� ����: ���� ����, �̵� ����, stat�� ������ �ִ�
    public class EnemyUnit : MonoBehaviour, IDamageable, IMoveable, IStats
    {
        public float Health { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int Defense { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public float MoveSpeed { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public float Acceleation { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int Stringth { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int Dexterrty { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int Endurance { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Die()
        {
            throw new System.NotImplementedException();
        }

        public void GoBack()
        {
            throw new System.NotImplementedException();
        }

        public void GoForward()
        {
            throw new System.NotImplementedException();
        }

        public void RestoreHealth(float amount)
        {
            throw new System.NotImplementedException();
        }

        public void TakeDamage(float damage)
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
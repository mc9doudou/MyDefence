using UnityEngine;
namespace Solid.Interface
{
    //������ ��� ����� ����  - X 
    public interface IUnitStats 
    {
        public float Health { get; set; }
        public int Defense { get; set; }
        public void TakeDamage(float damage);
        public void Die();
        public void RestoreHealth(float amount);
        public float MoveSpeed { get; set; }
        public float Acceleation { get; set; }
        public void GoForward();
        public void GoBack();
        public void TurnLeft();
        public void TurnRight();
        public int Stringth { get; set; }
        public int Dexterrty { get; set; }
        public int Endurance { get; set; }
    }
}
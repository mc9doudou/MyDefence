using UnityEngine;
namespace Solid.Interface
{
    //health�� ������ �����ϴ� unit
    public interface IDamageable 
    {
        public float Health { get; set; }
        public int Defense { get; set; }
        public void TakeDamage(float damage);
        public void Die();
        public void RestoreHealth(float amount);
    }
}
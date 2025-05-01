using UnityEngine;
namespace Solid.Interface
{
    //Æø¹ßÇÏ´Â Åë : 
    public class ExpplodingBarrel : MonoBehaviour, IDamageable, IExplodable
    {
        public float Mass { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public float ExplosiveForce { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public float FuseDelay { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public float Health { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int Defense { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Die()
        {
            throw new System.NotImplementedException();
        }

        public void Explode()
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
    }
}
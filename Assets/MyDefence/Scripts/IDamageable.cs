using UnityEngine;

namespace MyDefence
{
    public interface IDamageable
    {
        public void TakeDamege(float damage);

        public void Slow(float rate);

    }
}
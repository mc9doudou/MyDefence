using UnityEngine;
namespace Sample
{
    //팩토리 메서드 패턴
    //팩토리 메서드 - 생성하는 메서드를 추상화한다
    public interface IMonsterFactory
    {

        public Monster CreatMonster();

    }
    public class SlimeFactory : IMonsterFactory
    {
        public int count = 0;
        public Monster CreatMonster()
        {
            return new Slime();
        }
        public void SlimeCount() => count++;
    }

    public class ZombieFactory : IMonsterFactory
    {
        
        public Monster CreatMonster()
        {
            return new Zombie();
        }
        public void AddSomething()
        {
            Debug.Log("   ");
        }
    }

    public class SkeletonFactory: IMonsterFactory
    {
        public Monster CreatMonster()
        {
            return new Skeleton();
        }
    }
}
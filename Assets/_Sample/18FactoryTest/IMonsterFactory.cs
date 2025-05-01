using UnityEngine;
namespace Sample
{
    //���丮 �޼��� ����
    //���丮 �޼��� - �����ϴ� �޼��带 �߻�ȭ�Ѵ�
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
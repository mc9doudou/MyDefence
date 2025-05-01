using UnityEngine;
namespace Sample
{
    //���� ���丮
    //���͸� �����ϴ� Ŭ����
    public class MonsterFactory 
    {
        //���� Ÿ���� �Ű������� �޾� Ÿ�Կ� �°� ���͸� �����ϰ� ��ȯ�ϴ� �Լ�
        public Monster CreateMonster(MonsterType monsterType)
        {
            switch (monsterType)
            {
                case MonsterType.M_Goblin :
                    return new Slime();
                    //break;
                case MonsterType.M_Zombie :
                    return new Zombie();
                    //break;
                case MonsterType.M_Slime :
                    return new Slime();
                    //break;
                case MonsterType.M_Skeleton:
                    return new Skeleton();
                    //break;
            }
            //Ÿ�Կ� ������ null ��ȯ 
            return null;
        }

    }
}
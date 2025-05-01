using UnityEngine;
namespace Sample
{
    public class FactoryTest : MonoBehaviour
    {
        private void Start()
        {
            /*//���� ���丮 ��ü ����
            MonsterFactory monsterFactory = new MonsterFactory();

            //������ ����
            Monster slime = monsterFactory.CreateMonster(MonsterType.M_Slime);
            slime.Attack();

            Monster zombie = monsterFactory.CreateMonster(MonsterType.M_Zombie);
            slime.Attack();
            
            Monster goblin = monsterFactory.CreateMonster(MonsterType.M_Goblin);
            slime.Attack();

            Monster slime2 = monsterFactory.CreateMonster(MonsterType.M_Goblin);
            slime2.Attack();*/

            //���丮 �޼��� ����
            //������ ���� ����
            SlimeFactory slimeFactory = new SlimeFactory();
            Monster slime = slimeFactory.CreatMonster();    //������ ����
            slimeFactory.SlimeCount();                      //������ ������ ī��Ʈ
            slime.Attack();

            ZombieFactory zombieFactory = new ZombieFactory();
            Monster zombie = zombieFactory.CreatMonster();    //������ ����
            zombieFactory.AddSomething();                      //������ ������ ī��Ʈ
            zombie.Attack();
        }

    }
}
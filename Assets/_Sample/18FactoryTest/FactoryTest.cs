using UnityEngine;
namespace Sample
{
    public class FactoryTest : MonoBehaviour
    {
        private void Start()
        {
            /*//심플 팩토리 객체 생성
            MonsterFactory monsterFactory = new MonsterFactory();

            //슬라임 생성
            Monster slime = monsterFactory.CreateMonster(MonsterType.M_Slime);
            slime.Attack();

            Monster zombie = monsterFactory.CreateMonster(MonsterType.M_Zombie);
            slime.Attack();
            
            Monster goblin = monsterFactory.CreateMonster(MonsterType.M_Goblin);
            slime.Attack();

            Monster slime2 = monsterFactory.CreateMonster(MonsterType.M_Goblin);
            slime2.Attack();*/

            //팩토리 메서드 패턴
            //슬라임 전용 공장
            SlimeFactory slimeFactory = new SlimeFactory();
            Monster slime = slimeFactory.CreatMonster();    //슬라임 생산
            slimeFactory.SlimeCount();                      //생성한 슬라임 카운트
            slime.Attack();

            ZombieFactory zombieFactory = new ZombieFactory();
            Monster zombie = zombieFactory.CreatMonster();    //슬라임 생산
            zombieFactory.AddSomething();                      //생성한 슬라임 카운트
            zombie.Attack();
        }

    }
}
using UnityEngine;
namespace Sample
{
    //������ Ÿ�� ����
    public enum MonsterType
    {
        M_Slime,
        M_Zombie,
        M_Goblin,
        M_Skeleton
                    
    }

    //��� ������ �θ� �߻� Ŭ����
    public abstract class Monster 
    {
        //���� �Ӽ�, ���� ��� ����, ����
        public abstract void Attack();
        

    }
    //�������� �����ϴ� Ŭ����
    public class Slime : Monster
    {
        public override void Attack()
        {
            Debug.Log("Slime Attack!!!");
        }
    }

    public class Zombie : Monster
    {
        public override void Attack()
        {
            Debug.Log("Zombie Attack!!!");
        }
    }

    public class Goblin : Monster
    {
        public override void Attack()
        {
            Debug.Log("Goblin Attack!!!");
        }
    }

    public class Skeleton : Monster
    {
        public override void Attack()
        {
            Debug.Log("Skeleton Attack!!!");
        }
    }
}
/*
���丮 ���� 
1) ���� ���丮


2) ���丮 �޼��� ����
 - ���� ���丮 Ȯ��
 - ���丮���� ��� �߰�


3) �߻� ���丮 ����
 - ���� ���丮 Ȯ��





*/
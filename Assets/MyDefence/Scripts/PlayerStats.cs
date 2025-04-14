using UnityEngine;

namespace MyDefence
{
    //�÷��̾��� �Ӽ�(������)���� �����ϴ� Ŭ����
    public class PlayerStats : MonoBehaviour
    { 
        #region Field
        //������
        private static int money;

        [SerializeField]
        private int startmoney = 400;

        private static int health;

        [SerializeField]
        private int starthealth = 10;


        #endregion

        #region Property
        //������ �б� ���� �Ӽ�
        public static int Money
        {
            get { return money; }
        }
        public static int Health
        {
            get { return health; }
        }

        //Round ī��Ʈ
        public static int Rounds { get; set; }

        #endregion

        //������ �ʱⰪ 400
        private void Start()
        {
            //������ ���� 400
            money = startmoney;
            health = starthealth;
            Rounds = 0;
        }
        private void Update()
        {

        }
        //����, ����, ������ Ȯ�� �Լ� ����� 
        public static void AddMoney(int amount)
        {
            money += amount;
        }
        public static bool UseMoney(int amount)
        {
            if (money < amount)
            {
                Debug.Log("���� �����մϴ�");
                return false;
            }
            money -= amount;
            return true;
        }
        public static bool HasMoney(int amount)
        {
            return money >= amount;
        }
        //���� �߰�
        public static void AddHealth(int amount)
        {
            health += amount;
        }
        //���� ����ϱ�, �Ҹ�
        public static void UseHealth(int amount)
        {
            health -= amount;
            if (health <= 0)
            {
                health = 0;
            }
        }
    }
}
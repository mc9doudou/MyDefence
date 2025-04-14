using UnityEngine;

namespace MyDefence
{
    //플레이어의 속성(데이터)들을 관리하는 클래스
    public class PlayerStats : MonoBehaviour
    { 
        #region Field
        //소지금
        private static int money;

        [SerializeField]
        private int startmoney = 400;

        private static int health;

        [SerializeField]
        private int starthealth = 10;


        #endregion

        #region Property
        //소지금 읽기 전용 속성
        public static int Money
        {
            get { return money; }
        }
        public static int Health
        {
            get { return health; }
        }

        //Round 카운트
        public static int Rounds { get; set; }

        #endregion

        //소지금 초기값 400
        private void Start()
        {
            //소지금 지급 400
            money = startmoney;
            health = starthealth;
            Rounds = 0;
        }
        private void Update()
        {

        }
        //벌기, 쓰기, 소지금 확인 함수 만들기 
        public static void AddMoney(int amount)
        {
            money += amount;
        }
        public static bool UseMoney(int amount)
        {
            if (money < amount)
            {
                Debug.Log("돈이 부족합니다");
                return false;
            }
            money -= amount;
            return true;
        }
        public static bool HasMoney(int amount)
        {
            return money >= amount;
        }
        //생명 추가
        public static void AddHealth(int amount)
        {
            health += amount;
        }
        //생명 사용하기, 소모
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
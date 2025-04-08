using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
namespace MyDefence
{
    //플레이어의 속성들을 관리하는 클래스
    public class PlayerStats : MonoBehaviour
    { 
        #region Field
        //소지금
        private static int money;

        [SerializeField]
        private int startmoney = 400;

        public TextMeshProUGUI moneyText;
        #endregion

        #region Property
        //소지금 읽기 전용 속성
        public static int Money
        {
            get { return money; }
        }
        #endregion
        

        //소지금 초기값 400
        //벌기, 쓰기, 소지금 확인 함수 만들기 
        public Button machineGunTower;
        public Button rocketTower;

        private void Start()
        {
            //소지금 지급 400
            money = startmoney;
        }
        private  void Updata()
        {
            if (HasMoney(1000))
            {
                machineGunTower.interactable = true;
            }
            else
            {
                machineGunTower.interactable = false;
            }
            if (HasMoney(9000))
            {
                rocketTower.interactable = true;
            }
            else
            {
                rocketTower.interactable = false;
            }
            //소지금(gold)와 UI(골드텍스트) 연결 
            moneyText.text = money.ToString() + " Gold";
        }
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
            /*//소지금 체크
            if (money < amount)
            {
                return false;
            }
            return true;*/
        }

        public static void MachineGunTower()
        {
            if (UseMoney(100) == true)
            {
                Debug.Log($"건설하고 남은돈 :{money - 100}");
            }
        }
        public static void RocketTower()
        {
            if (UseMoney(250) == true)
            {
                Debug.Log($"건설하고 남은돈 :{money - 250}");
            }
        }

    }
}
using UnityEngine;
using TMPro;
using UnityEngine.UI;
namespace Sample
{
    public class MoneyTest : MonoBehaviour
    {
        #region Field
        //소지금 
        private int gold;


        [SerializeField]
        private int startGold;

        //Gold UI
        public TextMeshProUGUI goldText;

        //Button UI
        public Button button1000;
        public Button button9000;
        #endregion
        private void Start()
        {
            //초기화 - 게임 처음 시작할때 startGold로 초기화
            //소지금 지급
            gold = startGold;
            Debug.Log($"소지금 {startGold}원을 지급했습니다");

            //ex 버튼 이미지 색깔 바꾸기
            button1000.image.color = Color.blue;

        }
        private void Update()
        {//소지금이 부족하여 구매가 불가능할 경우 이미지 red
            if (HasGold(1000))
            {
                button1000.interactable = true;
                //button1000.image.color = Color.white;
            }
            else
            {
                button1000.interactable = false;
                //button1000.image.color = Color.red;
            }
            if (HasGold(9000))
            {
                button1000.interactable = true;
                //button9000.image.color = Color.white;
            }
            else
            {
                button1000.interactable = false;
                //button9000.image.color = Color.red;
            }
            //소지금(gold)와 UI(골드텍스트) 연결 
            goldText.text = gold.ToString() + " Gold";
        }
        //Gold를 연산하는 함수
        //돈을 번다: 사냥, 퀘스트 클리어, 케쉬 구매, 미벤트 보상 ...
        public void AddGold(int amount)
        {
            gold += amount;
        }

        //돈을 쓴다: 아이템 구매, 기구 사용....
        //돈이 부족하면 돈을 사용하지 않고 return false;
        //돈이 충분하면 돈을 사용하고 return true;

        public bool UseGold(int amount)
        {
            //소지금 체크
            if (gold < amount)
            {
                Debug.Log("소지금 부족합니다");
                return false;
            }
            gold -= amount;
            return true;
        }

        //소지금 체크:amount 만큼 소지금을 가지고 있는지 여부
        //돈은 사용하지 않고

        public bool HasGold(int amount)
        {
            if (gold < amount)
            {
                
                return false;
            }
            
            return true;
        }

        //버튼 3개 클릭시 호출되는 함수 3개 만들고 각 버튼에 연결하세요
        //버튼 클릭시 Gold 계산하고 출력하세요
        public void SaveButton()
        {
            AddGold(1000);
            Debug.Log("1000 Gold Save");
        }

        public void Item1000()
        {
            if (UseGold(1000) == true)
            {
                Debug.Log("1000 Item 구매");
            }
        }

        public void Item9000()
        {
            if(UseGold(9000) == true)
            {
                Debug.Log("9000 Item 구매");
            }
            
        }
    
    }
}
/*
MoneyTest
1. 시작하면 소지금을 1000G 지급
2. 화면상단에 소지금 UI 표시(1000 Gold)
3. 버튼 3개 
1) 저축 버튼 : 1000G 저축, 버튼 클릭시 + 1000, "1000 Gold Save" 출력

2) 구매 버튼 : 1000G 아이템 구매, 버튼 클릭시 -1000, "1000 Item Purchase" 출력
3) 구매 버튼 : 9000G 아이템 구매, 버튼 클릭시 -9000, "9000 Item Purchase" 출력

구매 버튼 : 아이템 구매가 가능하면 버튼 이미지는 white, 
           소지금 부족하여 구매가 불가능하면 이미지 red,
           구매가 불가능하면 구매버튼 클릭해도 구매 불가능해야 한다
*/
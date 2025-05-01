using UnityEngine;
using UnityEngine.UI;
namespace MyDefence
{
    public class ImageTest : MonoBehaviour
    {
        #region Field
        //스킬 버튼
        public Button skillButton;
        public Image skillButtonImage;
        public GameObject panel;

        [SerializeField]
        private float coolTime = 3f;
        private float countdown = 0f;

        //쿨 타임 체크
        private bool isCharge = false;
        #endregion
        private void Start()
        {
            //초기화
            countdown = 0f;
            isCharge = true;
            panel.SetActive(false);
        }

        private void Update()
        {
            if (isCharge)
              return;

            countdown += Time.deltaTime;
            if (countdown >= coolTime)
            {
                //타이머 기능
                skillButton.interactable = true;

                //panel 이미지 비활성화
                panel.SetActive(false);

                //타이머 초기화
                countdown = 0f;
                isCharge = true;
            }

            //countdown : 0 -> 3, fillamunt 0 -> 1(100%, 소수점, 분수)
            //백분율 : (현재값량: countdown) / (총값량: cooltime) 
            skillButtonImage.fillAmount =countdown / coolTime;

        }
        //스킬 버튼 클릭시 호출되는 함수
        public void SkillUse()
        {
            //skillButtonImage.isActiveAndEnabled(false);
            skillButton.interactable = false;

            //panel 이미지 활성화
            panel.SetActive(true);

            countdown = 0f;
            isCharge = false;
            //Debug.Log("Skill Use");
        }
    }
}
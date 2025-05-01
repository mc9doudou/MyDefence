using UnityEngine;
namespace MyDefence
{
    public class LevelClearUI : MonoBehaviour
    {
        #region Field
        public SceneFader fader;

        [SerializeField]
        private string loadToMenu = "MainMenu";
        [SerializeField]
        private string loadToNext = "LevelSelect";
        #endregion
        //countinue버튼 클릭시 호출- 레벨셀렉트 씬으로 이동
        public void countinueButton()
        {
            fader.FadeTo(loadToNext);
        }

        //menu버튼 클릭시 호출- 메인메뉴 씬으로 이동
        public void MenuButton()
        {
            fader.FadeTo(loadToMenu);
        }
    }
}
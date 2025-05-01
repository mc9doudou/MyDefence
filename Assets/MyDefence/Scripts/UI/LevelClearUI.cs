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
        //countinue��ư Ŭ���� ȣ��- ��������Ʈ ������ �̵�
        public void countinueButton()
        {
            fader.FadeTo(loadToNext);
        }

        //menu��ư Ŭ���� ȣ��- ���θ޴� ������ �̵�
        public void MenuButton()
        {
            fader.FadeTo(loadToMenu);
        }
    }
}
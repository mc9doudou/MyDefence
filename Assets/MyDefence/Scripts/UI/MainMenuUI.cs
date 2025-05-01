using UnityEngine;
using UnityEngine.SceneManagement;
namespace MyDefence
{
    //메인메뉴 씬을 관리하는 클래스
    public class MainMenuUI : MonoBehaviour
    {
        #region Field
        [SerializeField]
        private string loadToScene = "PlayScene";
        #endregion
        public void Play()
        {
            //Debug.Log("Goto Play Scene");
            SceneManager.LoadScene(loadToScene);
        }

        public void Quit()
        {
            //Cheating 
            //PlayerPrefs.DeleteAll();

            //Debug.Log("Quit Game!!!");
            //Unity 에디터에서 명령 무시, 빌드버전에서는 구동
            Application.Quit();
        }
    }
}
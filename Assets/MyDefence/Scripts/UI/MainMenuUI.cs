using UnityEngine;
using UnityEngine.SceneManagement;
namespace MyDefence
{
    //���θ޴� ���� �����ϴ� Ŭ����
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
            //Unity �����Ϳ��� ��� ����, ������������� ����
            Application.Quit();
        }
    }
}
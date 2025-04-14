using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
namespace MyDefence
{
    public class GameOverUI : MonoBehaviour
    {
        #region Field
        public TextMeshProUGUI roundText;
        #endregion
        //활성화시 한번만 호출하고 값을 초기화 한다
        private void OnEnable()
        {
            roundText.text = PlayerStats.Rounds.ToString();
        }
        public void RestartButton()
        {
            //GameManager.IsGameOver = false;
            //SceneManager.LoadScene("PlayScene"); //씬이름으로 로드
            //해당 씬을 다시 부른다 - 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        public void MenuButton()
        {
            Debug.Log("Go to Menu");
        }
    }
}

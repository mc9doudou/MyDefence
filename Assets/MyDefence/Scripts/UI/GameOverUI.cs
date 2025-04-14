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
        //Ȱ��ȭ�� �ѹ��� ȣ���ϰ� ���� �ʱ�ȭ �Ѵ�
        private void OnEnable()
        {
            roundText.text = PlayerStats.Rounds.ToString();
        }
        public void RestartButton()
        {
            //GameManager.IsGameOver = false;
            //SceneManager.LoadScene("PlayScene"); //���̸����� �ε�
            //�ش� ���� �ٽ� �θ��� - 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        public void MenuButton()
        {
            Debug.Log("Go to Menu");
        }
    }
}

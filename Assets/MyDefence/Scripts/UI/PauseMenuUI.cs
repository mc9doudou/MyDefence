using UnityEngine.SceneManagement;
using UnityEngine;
namespace MyDefence
{
    public class PauseMenuUI : MonoBehaviour
    {
        public GameObject pauseUI;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Toggle();
            }
        }
        public void Toggle()
        {
            pauseUI.SetActive(!pauseUI.activeSelf);
            //â�� ������ 
            if (pauseUI.activeSelf)
            { Time.timeScale = 0f; }
            else
            { Time.timeScale = 1f; }
        }
        public void Continue()
        {
            Toggle();
        }
        public void Retry()
        {
            Time.timeScale = 1f;
            //�ش� ���� �ٽ� �θ���  
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        public void Menu()
        {
            Debug.Log("menu");
        }
    }
}
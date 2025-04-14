using UnityEngine;
namespace MyDefence
{
    public class PausedUI : MonoBehaviour
    {
        #region Field
        public GameObject pausedUI;
        #endregion
        private static bool isPause = false;
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Pause();
            }
        }
        //게임 일시정지
        void Pause()
        {
            if (isPause == false)
            {PauseGame(); }
            else
            {ResumeGame();}
        }
        void PauseGame()
        {
            isPause = true;
            pausedUI.SetActive(true);
            Time.timeScale = 0f;
        }
        void ResumeGame()
        {
            isPause = false;
            pausedUI.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
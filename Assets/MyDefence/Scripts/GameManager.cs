using MyDefence;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Field
    //cheat check
    [SerializeField] private bool isCheat=false;

    //게임오버
    //UI
    public GameObject gameOverUI;

    private static bool isGameOver = false;

    #endregion

    #region Property
    public static bool IsGameOver
    {
        get { return isGameOver; }
    }
    #endregion
    private void Start()
    {
        //초기화
        isGameOver = false;
    }
    private void Update()
    {
        //게임오버 체크
        if (IsGameOver)
            return;
        if (PlayerStats.Health <= 0)
        {
            ShowGameOverUI();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            ShowMeTheMoney();
        }

        if (Input.GetKeyDown(KeyCode.O) && isCheat == true)
        {
            ShowGameOverUI();
        }
    }
    //게임오버 UI 조여주기
    void ShowGameOverUI()
    {
        isGameOver = true;
        gameOverUI.SetActive(true);
    }

    //Cheating
    //M키를 누르면 10만골드 지급
    void ShowMeTheMoney()
    {
        if (isCheat == false)
            return;
        
        PlayerStats.AddMoney(100000);
    }

    void LevelUpCheat()
    {
        if (isCheat == false)
            return;
    }
}

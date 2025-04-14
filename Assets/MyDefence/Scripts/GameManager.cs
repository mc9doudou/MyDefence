using MyDefence;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Field
    //cheat check
    [SerializeField] private bool isCheat=false;

    //���ӿ���
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
        //�ʱ�ȭ
        isGameOver = false;
    }
    private void Update()
    {
        //���ӿ��� üũ
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
    //���ӿ��� UI �����ֱ�
    void ShowGameOverUI()
    {
        isGameOver = true;
        gameOverUI.SetActive(true);
    }

    //Cheating
    //MŰ�� ������ 10����� ����
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

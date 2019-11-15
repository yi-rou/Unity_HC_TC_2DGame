using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("分數")]
    public int score;
    [Header("最佳分數")]
    public int scoreHight;

    /// <summary>
    /// 目前分數
    /// </summary>
    /// <param name="add">增加分數.預設值為1</param>
    private void Score(int add = 1)
    {
       
    }
    
    /// <summary>
    /// 最佳分數
    /// </summary>
    private void BestScore()
    {

    }

    /// <summary>
    /// 遊戲結束
    /// </summary>
    private void GameOver()
    {

    }
}

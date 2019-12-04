using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("分數")]
    public int score;
    [Header("最佳分數")]
    public int scoreHight;
    [Header("生成水管")]
    public GameObject pipe;
    [Header("結束畫面")]
    public GameObject goFinal;

    public Text textScore;

    public Text textHight;

    /// <summary>
    /// 目前分數
    /// </summary>
    /// <param name="add">增加分數.預設值為1</param>
    public void Score(int add = 1)
    {
        print("+1");
        score = score + add;
        textScore.text = score.ToString();
        BestScore();
    }
    
    /// <summary>
    /// 最佳分數
    /// </summary>
    private void BestScore()
    {
        if (score > scoreHight)
        {
            PlayerPrefs.SetInt("最佳分數", score);
        }
    }

    /// <summary>
    /// 遊戲結束
    /// </summary>
    public void GameOver()
    {
        goFinal.SetActive(true);
        CancelInvoke("SpawnPipe");  // 取消調用 ("方法名稱")
    }

    /// <summary>
    /// 生成水管
    /// </summary>
    private void SpawnPipe()
    {
        //三維向量 = new 三維向量(x,y,z)
        Vector3 p = new Vector3(4.8f, Random.Range(-1.1f,1.5f), 0);
        //Object可簡略.因為繼承的關係
        //Quaternion.identity 零角度.不旋轉
        Instantiate(pipe , p , Quaternion.identity);
    }

    /// <summary>
    /// 重新遊戲
    /// </summary>
    public void Replay()
    {
        print("重新遊戲");
        SceneManager.LoadScene("遊戲場景");
    }

    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void Exit()
    {
        print("離開遊戲");
        Application.Quit();
    }

    private void Start()
    {
        //SpawnPipe();
        //延遲調用("方法名稱",延遲時間)
        //Invoke("SpawnPipe", 0.5f);
        //InvokeRepeating("方法名稱",延遲時間,產生速率)
        InvokeRepeating("SpawnPipe", 0 ,2.5f);

        scoreHight = PlayerPrefs.GetInt("最佳分數");
        textHight.text = scoreHight.ToString();
    }
}

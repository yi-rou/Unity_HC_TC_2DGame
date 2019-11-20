using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("分數")]
    public int score;
    [Header("最佳分數")]
    public int scoreHight;
    [Header("生成水管")]
    public GameObject pipe;

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
    private void Start()
    {
        //SpawnPipe();
        //延遲調用("方法名稱",延遲時間)
        //Invoke("SpawnPipe", 0.5f);
        //InvokeRepeating("方法名稱",延遲時間,產生速率)
        InvokeRepeating("SpawnPipe", 0 ,2.5f);
    }
}

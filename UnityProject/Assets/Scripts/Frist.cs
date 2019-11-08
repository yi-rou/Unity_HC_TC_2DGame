
using UnityEngine;  // 引用 Unity API

// 類別 類別名稱
public class Frist : MonoBehaviour
{
    // 程式內容
    // 宣告變數 - 定義欄位 Field
    // 欄位類型  欄位名稱 (指定 值) 結束
    // 私人 - 隱藏 private (預設)
    // 公開 - 顯示 public
    [Header("金幣"),Range(10,9999)]
    public int coin = 111;            //整數 - 0
    [Header("速度")]
    [Range(-0.5f,50)]
    public float speed = -0.25f;      //浮點數 - 0
    [Tooltip("沒有用的藥水")]
    public string prop = "紅色藥水";  //字串 - ""
    public bool dead = true;          //布林值 - false

    //事件:在特定時間點已指定次數執行
    //開始:遊戲播放時執行一次
    private void Start()
    {
        print("哈囉，沃德~");
    }
    private void Update()
    {
        print("唷呼");
    }
}
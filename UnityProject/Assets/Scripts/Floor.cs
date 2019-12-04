using UnityEngine;

public class Floor : MonoBehaviour
{
    // 靜態  此類別共用
    // 隱藏
    // 靜態 不會在還原場景時回復預設值
    //[Header("地板速度"),Range(0.5f,99.9f)]
    public static float speed = 3;

    public Transform floor;

    private void Start()
    {
        speed = 3; 
    }

    private void Update()
    {
        Move();
    }

    /// <summary>
    /// 移動速度
    /// </summary>
    private void Move()
    {
         //Time.deltaTime 一個影格的時間(根據電腦效能不同)
        floor.Translate(-speed * Time.deltaTime,0,0);
    }

}

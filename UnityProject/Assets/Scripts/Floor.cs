using UnityEngine;

public class Floor : MonoBehaviour
{
    [Header("地板速度"),Range(0.5f,99.9f)]
    public float speed = 1;

    public Transform floor;

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

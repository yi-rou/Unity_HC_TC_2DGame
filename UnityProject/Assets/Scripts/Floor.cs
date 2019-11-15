using UnityEngine;

public class Floor : MonoBehaviour
{
    [Header("地板速度"),Range(0.5f,99.9f)]
    public float speed = 1;

    public Transform floor;

    private void Update()
    {
        floor.Translate(-speed,0,0);
    }

    /// <summary>
    /// 移動速度
    /// </summary>
    private void Move()
    {
         
    }

}

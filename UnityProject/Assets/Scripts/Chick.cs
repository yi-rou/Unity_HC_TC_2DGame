using UnityEngine;

public class Chick : MonoBehaviour
{
    [Header("跳躍高度"),Range(9f,949f)]
    public float jump =10f;
    [Tooltip("是否死亡")]
    public bool dead;

    /// <summary>
    /// 跳躍高度
    /// </summary>
    private void Jump()
    {
        
    }

    /// <summary>
    /// 小雞是否死亡
    /// </summary>
    private void Dead()
    {
        
    }

    /// <summary>
    /// 通過水管
    /// </summary>
    private void PassPipe()
    {

    }
}

using UnityEngine;

public class Chick : MonoBehaviour
{
    [Header("跳躍高度"),Range(9f,949f)]
    public float jump =10f;
    [Tooltip("是否死亡")]
    public bool dead;
}

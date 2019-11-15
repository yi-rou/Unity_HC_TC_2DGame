using UnityEngine;

public class APItwo : MonoBehaviour
{
    public Chick chick;

    private void Start()
    {
        chick.jump = 99;
        print("跳躍高度" + chick.jump);
    }
}

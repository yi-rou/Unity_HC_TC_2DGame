using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool open;

    public int score;

    public int combo;
    private void Start()
    {
        // 判斷式 if
        // if (布林值) {當布林值為true才會執行 }
        if (true)
        {
            print("fly");
        }
        // 布林值結果為false,才會執行else的{}
        if (open)
        {
            print("開啟");
        }
        else
        {
            print("關閉");
        }

        if (score >= 60)
        {
            print("恭喜");
        }
        else if (score >= 40)
        {
            print("再接再厲");
        }
        else
        {
            print("明年再來吧");
        }
        if (combo < 50)
        {
            print("攻擊");
        }
        else if (combo < 100)
        {
            print("攻擊*2");
        }
        else if (combo < 150)
        {
            print("攻擊*5");
        }
        else
        {
            print("攻擊*10");
        }
    }
}

using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    // 宣告方法 - 定義方法 Method
    //修飾詞 傳回類型 方法名稱(參數類型 參數名稱){ 陳述式.演算法 }
    //private 只有此類別能使用方法
    //void 無傳回

    private void Test()
    {
        print("測試方法");
    
    }
    private float Ten()
    {
        return 1.5f;
    }
    private string Hello()
    {
        return "money + 1";
    }

    private void DriveMethod(float speed)
    {
        print("特效");
        print("開車速度" + speed);
    }

    private void Knife(int speed, float hurt, string direction = "右邊")
    {
        print("速度" + speed);
        print("傷害" + hurt);
        print("方向" + direction);
    }

    private void Start()
    {
        //呼叫方法
        Test();
        float a = Ten();
        print("有傳回方法:" + a);

        print("有傳回方法:" + Ten());

        print("有傳回方法:" + Hello());

        DriveMethod(5.9f);

        Knife(5,9.9f);
    }
}

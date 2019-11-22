using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int a = 55, b = 6;
    public int c = 3, d = 9;
    private void Start()
    {
        #region 數學運算子
        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b);

        a = a + 1;
        print(a);

        print(a++);   //先輸出 a 再遞增
        print(++a);   //先遞增再輸出 a
        print(b--);
        print(--b);

        print(b += 10);  // b + 10=簡寫成 b += 10
        #endregion
        #region  比較運算子 
        print(c > d);   //傳回都是布林值
        print(c < d);
        print(c >= d);
        print(c <= d);
        print(c == d);  // == 等於
        print(c != d);  // != 不等於
        #endregion

        #region  邏輯運算子
        // && 並且
        // 只要有一個false就會傳回false
        print(true && true);
        print(true && false);
        print(false && true);
        print(false && false);
        // || 或者
        // 只要一個true就會傳回true
        print(true || true);
        print(true || false);
        print(false || true);
        print(false || false);

        // ! 相反
        print(!true);
        print(!false);
        #endregion
    }
}

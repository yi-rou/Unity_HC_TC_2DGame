// :繼承
public class Pipe : Floor
{
    // 掛腳本的物件要有 Mesh Renderer
    // 在所有攝影機都看不到時執行一次(包含場景攝影機)
    private void OnBecameInvisible()
    {
       Destroy(gameObject,2.5f);
    }

    // 在所有攝影機都看到時執行一次
    private void OnBecameVisible()
    {
        
    }
}

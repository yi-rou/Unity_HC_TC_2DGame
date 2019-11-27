using UnityEngine;

public class Chick : MonoBehaviour
{
    [Header("跳躍高度"),Range(9f,949f)]
    public float jump =10f;
    [Tooltip("是否死亡")]
    public bool dead;

    public GameObject goScore, goGM;

    public Rigidbody2D rb2D;

    private void Update()
    {
        Jump();
    }

    /// <summary>
    /// 跳躍高度
    /// </summary>
    private void Jump()
    {
        if (dead) return;  //如果 死亡被勾選 就跳出
        

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            goScore.SetActive(true);
            goGM.SetActive(true);

            rb2D.Sleep();                       //睡著()  重設所有物理資料                                    
            rb2D.gravityScale = 1;
            rb2D.AddForce(new Vector2(0,jump));

        }
        rb2D.SetRotation(100 * rb2D.velocity.y);
        //print(rb2D.velocity);
    }

    //碰撞事件:物件碰撞開始時執行一次
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //print(collision.gameObject.name);

        Dead();
    }
    //觸發事件:物件觸發開始時執行一次 針對有勾選isTrigger的物件
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Dead();
    }
    /// <summary>
    /// 小雞是否死亡
    /// </summary>
    private void Dead()
    {
        dead = true;
    }

    /// <summary>
    /// 通過水管
    /// </summary>
    private void PassPipe()
    {

    }
}

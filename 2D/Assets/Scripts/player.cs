using UnityEngine;

public class player : MonoBehaviour
{
    // 空物值 (None)導致程式錯誤-閃退...等

    public GameObject exit;

    //碰撞偵測條件
    //1.兩個物件必須有碰撞器 (Collider2D)
    //2.兩者必須有至少一個剛體 (Rigidbody)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("碰到傳送門");
        exit.SetActive(true);
    }
}

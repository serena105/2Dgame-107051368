using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
 
    // private 私人  public 公開(可被按鈕呼叫)
   //修飾詞 類型 方式名稱( ) { }
   //void 無類型
 public void StartGame()
 {
  print("開始遊戲");
  SceneManager.LoadScene("關卡一");
 }


 public void QuitGame()
 {
  print("結束遊戲");
  Application.Quit();

 }


  
}

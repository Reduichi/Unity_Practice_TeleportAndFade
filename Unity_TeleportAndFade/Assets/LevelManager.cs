using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    private Image imgExit,imgEnter;           // 轉場

    // 碰到物健身上有 IsTrigger 碰撞器執行一次
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "傳送門")
        {
            // levelManager.NextLevel();
            StartCoroutine(levelManager.NextLevel());   // 協程方法，必須要用 啟動協程
        }
    }

    public IEnumerator NextLevel()
    {

        // 迴圈
        for (int i = 0; i < 50; i++)
        {
            imgExit.color += new Color(0, 0, 0, 0.02f); // 轉場.顏色 += new Color(0 , 0 , 0 , 0.02f)
            yield return new WaitForSeconds(0.001f); // 等待 0.001 秒

        }
        yield return new WaitForSeconds(0.2f);
        // 載入下一關
        SceneManager.LoadScene("第二關");
    }
}

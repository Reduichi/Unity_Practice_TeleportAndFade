using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelTwo : MonoBehaviour
{
    private Image imgCross;           // 轉場

    private void Start()
    {
        imgCross = GameObject.Find("轉場效果").GetComponent<Image>();
        StartCoroutine(EnterLevel());   // 協程方法，必須要用 啟動協程
    }

    

    public IEnumerator EnterLevel()
    {
        for (int i = 0; i < 50; i++)
        {
            imgCross.color -= new Color(0, 0, 0, 0.02f);
            yield return new WaitForSeconds(0.001f);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ESCが押下されたか判定
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // アプリケーション終了
            Application.Quit();
        }
    }
}

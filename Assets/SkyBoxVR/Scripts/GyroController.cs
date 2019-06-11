using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroController : MonoBehaviour
{
    // キーボード操作用
    private Vector3 rotate;
    void Start()
    {
        // 動作確認用のログ
        Debug.Log("started");

        rotate = transform.rotation.eulerAngles;
    }

    void Update()
    {
        // キーボードで視点変更
        float speed = Time.deltaTime * 100.0f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotate.y -= speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotate.y += speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rotate.x -= speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rotate.x += speed;
        }
        transform.rotation = Quaternion.Euler(rotate);
    }
}

﻿using System.Collections;
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

        // Unityエディタと実機で処理を分ける
        if (Application.isEditor)
        {
            rotate = transform.rotation.eulerAngles;
            Debug.Log("no-smartphone");
        }
        else 
        {
            Input.gyro.enabled =true;
        }
    }

    void Update()
    {
        // キーボードで視点変更
        float speed = Time.deltaTime * 100.0f;

        // PCは矢印キーで視点変更
        if (Application.isEditor)
        {
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
        // スマホはジャイロで視点変更
        else
        {
            Quaternion gratitude = Input.gyro.attitude;
            gratitude.x *= -1;
            gratitude.y *= -1;
            transform.localRotation = Quaternion.Euler(90, 0, 0) * gratitude;
            
        }
    }
}

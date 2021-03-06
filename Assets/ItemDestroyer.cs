﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    //カメラのオブジェクト
    private GameObject maincamera;
    
    // Use this for initialization
    void Start()
    {
        //カメラのオブジェクトを取得
        this.maincamera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        //オブジェクトが画面外に出た場合
        if (this.transform.position.z < maincamera.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}  
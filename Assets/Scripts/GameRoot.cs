using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameRoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //找到开始游戏的按钮
        transform.GetComponent<Button>().onClick.AddListener(onClick);
    }

    private void onClick()
    {
        //跳转场景
        SceneManager.LoadScene("Game");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

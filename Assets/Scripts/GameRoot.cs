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
        //�ҵ���ʼ��Ϸ�İ�ť
        transform.GetComponent<Button>().onClick.AddListener(onClick);
    }

    private void onClick()
    {
        //��ת����
        SceneManager.LoadScene("Game");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

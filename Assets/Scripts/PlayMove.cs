using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMove : MonoBehaviour
{
    //获取动画
    Animator playAni;
    //移动和旋转的速度
    public float movespeed = 5f;
    public float rotateSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
        playAni = transform.GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 moveDir = new Vector3(h, 0, v);

        if (moveDir.magnitude > 0.1f)
        {
            transform.position += moveDir.normalized * movespeed * Time.deltaTime;

            Quaternion toRotation = Quaternion.LookRotation(moveDir, Vector3.up);

            transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, rotateSpeed * Time.deltaTime);

            playAni.Play("run");

        }
        else
        {
            playAni.Play("Idle");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello,Unity");


        //Instantiate(bullet,transform.position,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 初始化子弹
            GameObject blt = Instantiate(bullet, transform.position, transform.rotation);
            // 获取物理模型
            Rigidbody rgb = blt.GetComponent<Rigidbody>();
            // 子弹速度
            rgb.velocity = transform.forward * speed;


        }
    }
}

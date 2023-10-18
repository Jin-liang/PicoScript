using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMove : MonoBehaviour
{
    // 定义移动速度
    public float moveSpeed = 3.0f;

    // 定义移动方向
    private Vector2 moveDir = new Vector2();

    // 定义移动范围
    private float minX = -5.0f;
    private float maxX = 5.0f;
    private float minY = -5.0f;
    private float maxY = 5.0f;

    // 在开始时初始化移动方向
    void Start()
    {
        moveDir.x = 1.0f;
        moveDir.y = 1.0f;
    }

    // 在每一帧更新移动函数
    void Update()
    {
        Move();
    }

    // 移动函数
    void Move()
    {
        // 获取当前位置
        Vector2 pos = transform.position;

        // 如果到达边界，反转移动方向
        if (pos.x < minX || pos.x > maxX)
        {
            moveDir.x = -moveDir.x;
        }
        if (pos.y < minY || pos.y > maxY)
        {
            moveDir.y = -moveDir.y;
        }

        // 计算新位置
        pos += moveDir * moveSpeed * Time.deltaTime;

        // 更新位置
        transform.position = pos;

    }
}


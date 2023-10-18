using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class playfile : MonoBehaviour
{
    // Start is called before the first frame update

    public VideoPlayer musi;
    public void conconutplay()
    {

        if(musi.isPlaying)
        {
            musi.Pause();
        }
        else
        {
            musi.Play();
        }
    }

    private Button button;  // 引用按钮对象

    private void Start()
    {
        button = GetComponent<Button>();  // 获取按钮组件引用
        button.onClick.AddListener(HandleButtonClick);  // 添加点击事件监听器
    }

    private void HandleButtonClick()
    {
        conconutplay();
    }
    // Update is called once per frame
    void Update()
    {

    }
}

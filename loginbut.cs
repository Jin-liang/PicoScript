using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loginbut : MonoBehaviour
{
    // Start is called before the first frame update
   
   // public InputField InputAccout;
   // public InputField InputPwd;
    public Button _btnOK;  // 引用按钮对象


    void Start()
    {
       // Debug.Log("" + InputAccout.text + "_" + InputPwd.text);  // 按钮点击时执行的代码
        _btnOK.onClick.AddListener(HandleButtonClick);  // 添加点击事件监听器
    }

    public void HandleButtonClick()
    {
        SceneManager.LoadScene("indoor_001");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}



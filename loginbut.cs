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
    public Button _btnOK;  // ���ð�ť����


    void Start()
    {
       // Debug.Log("" + InputAccout.text + "_" + InputPwd.text);  // ��ť���ʱִ�еĴ���
        _btnOK.onClick.AddListener(HandleButtonClick);  // ��ӵ���¼�������
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



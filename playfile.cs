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

    private Button button;  // ���ð�ť����

    private void Start()
    {
        button = GetComponent<Button>();  // ��ȡ��ť�������
        button.onClick.AddListener(HandleButtonClick);  // ��ӵ���¼�������
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

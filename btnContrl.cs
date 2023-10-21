using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using StarterAssets;

public class btnContrl : MonoBehaviour
{
    // Start is called before the first frame update
    public XRSimpleInteractable XRSimple;

    public StarterAssetsInputs _StarterAssetsInputs;

    public bool Isopen;
    void Start()
    {
        XRSimple = gameObject.GetComponent<XRSimpleInteractable>();
        XRSimple.hoverEntered.AddListener(OnHoverEntered);
        XRSimple.hoverExited.AddListener(OnHoverExited);
        XRSimple.selectEntered.AddListener(OnSelectEntered);
        XRSimple.selectExited.AddListener(OnSelectExited);

        Isopen=true;

    }
    /// <summary>
    /// ��ͣ����
    /// </summary>
    /// <param name="args"></param>
    public void OnHoverEntered(HoverEnterEventArgs args)
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        Log3("选择离开"); Isopen = false;
    }

    /// <summary>
    /// ��ͣ�˳�
    /// </summary>
    /// <param name="args"></param>
    public void OnHoverExited(HoverExitEventArgs args)
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.gray;
        Log3("选择推出");
        Isopen=false;
    }

    /// <summary>
    /// ѡ�����
    /// </summary>
    /// <param name="args"></param>
    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        Log3("选择"); Isopen = false;
    }

    /// <summary>
    /// ѡ���˳�
    /// </summary>
    /// <param name="args"></param>
    public void OnSelectExited(SelectExitEventArgs args)
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.gray;
        Log3("选择离开2"); Isopen = false;
    }

    public TMP_Text textAsrResult;
    bool triggerValue;
    Vector2 vec2DAxis = Vector2.zero;
    bool isGrip = false;
    bool isTrigger = false;
    bool isMenu = false;
    bool isPrimaryButton = false;
    bool isSecondButton = false;
    // Update is called once per frame
    void Update()
    {

        

            InputDevices.GetDeviceAtXRNode(XRNode.LeftHand).TryGetFeatureValue(CommonUsages.primary2DAxis, out vec2DAxis);
            InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetFeatureValue(CommonUsages.gripButton, out isGrip);
            InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetFeatureValue(CommonUsages.triggerButton, out isTrigger);
            InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetFeatureValue(CommonUsages.menuButton, out isMenu);
            InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetFeatureValue(CommonUsages.primaryButton, out isPrimaryButton);
            InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetFeatureValue(CommonUsages.secondaryButton, out isSecondButton);

            Log2("摇杆2：" + vec2DAxis.ToString() + "抓握键：" + isGrip.ToString() + "_扳机键：" + isTrigger.ToString() + "菜单：" + isMenu.ToString() + "A/B" + isPrimaryButton.ToString() + "Y/b" + isSecondButton.ToString());
            if(vec2DAxis.y != vec2DAxis.x)
            {
                _StarterAssetsInputs.MoveInput(vec2DAxis);
            }
            if(isGrip)
            {
                _StarterAssetsInputs.JumpInput(isGrip);
            }
            if (isTrigger)
            {
                _StarterAssetsInputs.SprintInput(isTrigger);
            }
        
    }
    protected void Log2(String content)
    {

        textAsrResult.text = content;
        //TextMeshPro mText = gameObject.GetComponent<TextMeshPro>();
        //GameObject.Find("TextContent").GetComponent<TextMesh>().text= content;
        //dataOutput.text = $"> {content}\n{dataOutput.text}";
        //if (dataOutput.text.Length > 1000)
        //{
        //    dataOutput.text = dataOutput.text.Substring(0, 1000);
        //}
    }
    protected void Log3(String content)
    {

        textAsrResult.text += content;
        //TextMeshPro mText = gameObject.GetComponent<TextMeshPro>();
        //GameObject.Find("TextContent").GetComponent<TextMesh>().text= content;
        //dataOutput.text = $"> {content}\n{dataOutput.text}";
        //if (dataOutput.text.Length > 1000)
        //{
        //    dataOutput.text = dataOutput.text.Substring(0, 1000);
        //}
    }
}
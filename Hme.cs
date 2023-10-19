using System;
using System.Collections;
using System.Collections.Generic;
using Pico.Platform;
using PICO.Platform.Samples;
using TMPro;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.XR;

public class Hme : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text textAsrResult;
    public TMP_Text textAsrResultf;
    void Start()
    {
        Log("GetAccessToken...");
        UserService.GetAccessToken().OnComplete(msg =>
        {
            if (msg.IsError)
            {
                Log($"Got access token error:code={msg.Error.Code} {msg.Error.Message} ");
                return;
            }

            string accessToken = msg.Data;
            Log($"Got accessToken {accessToken}");
        });
        triggerValue = false;
    }
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

        Log2(vec2DAxis.ToString() + "" + isGrip.ToString() + "_" + isTrigger.ToString() + "" + isMenu.ToString() + "" + isPrimaryButton.ToString() + "" + isSecondButton.ToString());
    }
    protected void Log2(String content)
    {

        textAsrResultf.text = content;
        //TextMeshPro mText = gameObject.GetComponent<TextMeshPro>();
        //GameObject.Find("TextContent").GetComponent<TextMesh>().text= content;
        //dataOutput.text = $"> {content}\n{dataOutput.text}";
        //if (dataOutput.text.Length > 1000)
        //{
        //    dataOutput.text = dataOutput.text.Substring(0, 1000);
        //}
    }

    protected void Log(String content)
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
}

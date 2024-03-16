using System.Collections;
using System.Collections.Generic;
using MoreMountains.CorgiEngine;
using TMPro;
using UnityEngine;

public class WatermarkUIDebugger : MonoBehaviour
{
    protected TextMeshProUGUI _UI;
        
    void Start()
    {
        if(GetComponent<TextMeshProUGUI>()==null)
        {
            Debug.LogWarning ("WaterMarkUIDebugger requires a TextMeshProUGUI component.");
            return;
        }
        _UI = GetComponent<TextMeshProUGUI>();
    }
        
    void Update()
    {
        _UI.text = System.DateTime.Now.ToString() + "   |   " + SystemInfo.deviceUniqueIdentifier;
    }
}

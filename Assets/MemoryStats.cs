using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Profiling; 
using System.Text;

public class MemoryStats : MonoBehaviour
{
    public Text memText;

    ProfilerRecorder systemUsedMemoryRecorder;

    void OnEnable(){
        systemUsedMemoryRecorder = ProfilerRecorder.StartNew(ProfilerCategory.Memory, "System Used Memory");
    }

    void OnDisable(){
        systemUsedMemoryRecorder.Dispose(); 
    }

    void Update()
    {
        var sb = new StringBuilder(500);

        if (systemUsedMemoryRecorder.Valid){
            sb.AppendLine($"System Used Memory: {systemUsedMemoryRecorder.LastValue / (1024 * 1024) } MB");
        }
        memText.text = sb.ToString(); 

    }
}

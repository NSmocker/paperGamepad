using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class VR_UI_Switch : MonoBehaviour
{
    public GameObject mono, stereo;
    public RenderTexture mono_tex, vr_tex;
    public Camera ar_cam;
    public bool mono_mode=true;

    [Header("UI vars")]
    public TextMeshProUGUI mode_ui;


    public void Switch() 
    {
        if (mono_mode == true) mono_mode = false; else mono_mode = true;
        ApplySettings();


    }
    void ApplySettings() 
    {
        if (mono_mode)
        {
            mono.SetActive(true);
            stereo.SetActive(false);
            ar_cam.targetTexture = mono_tex;
        }
        else
        {
            mono.SetActive(false);
            stereo.SetActive(true);
            ar_cam.targetTexture = vr_tex;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        ApplySettings();
    }

    // Update is called once per frame
    void Update()
    {
        mode_ui.text = "Mode: " + mono_mode.ToString();


    }
}

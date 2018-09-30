using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestCall : MonoBehaviour
{
    // 测试表明：只有在 InputField 编辑时，不输入任何数据，直接结束编辑，会触发错误，其余都是可以的
    public Button button;
    public InputField inputfiled;
    public Toggle toggle;
    public Slider slider;
    public Scrollbar scrolbar;
    public Dropdown dropdown;

    public void Button()
    {
        button.interactable = false;
    }

    public void InputfiledEndit(string arg0)
    {
        inputfiled.interactable = false;
    }
    public void InputfiledValue(string arg0)
    {
        inputfiled.interactable = false;
    }
    public void Toggle(bool bbb)
    {
        toggle.interactable = false;
    }
    public void Slider(float arg0)
    {
        slider.interactable = false;
    }
    public void Scrollbar(float arg0)
    {
        scrolbar.interactable = false;
    }
    public void Dropdown(int i)
    {
        dropdown.interactable = false;
    }

}

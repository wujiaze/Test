using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class toggletest : MonoBehaviour
{

    public Toggle toggle;
   

    void Start ()
	{
        toggle.onValueChanged.AddListener(fe);

	}

    private void fe(bool arg0)
    {
        // 测试说明：当is on =true 时 ，arg0为true；反之亦然

        Debug.Log(arg0);
    }

    // Update is called once per frame
    void Update () {
		
	}
}

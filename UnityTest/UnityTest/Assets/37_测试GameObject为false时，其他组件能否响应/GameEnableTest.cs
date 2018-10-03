using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnableTest : MonoBehaviour
{

    public static GameEnableTest Instance;

    private void Awake()
    {
        Instance = this;
    }


	
	// Update is called once per frame
	void Update () {
	    print("Update");
    }

    private void FixedUpdate()
    {
        print("FixedUpdate");
    }

    private void LateUpdate()
    {
        print("LateUpdate");
    }

    private void OnApplicationPause(bool pause)
    {
        print("OnApplicationPause");
    }

    private void OnApplicationQuit()
    {
        print("OnApplicationQuit");
    }

    private void OnDestroy()
    {
        print("OnDestroy");
    }

    private void OnDisable()
    {
        print("OnDisable");
    }

    private void OnEnable()
    {
        print("OnEnable");
    }
}

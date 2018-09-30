using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class invokeTest : MonoBehaviour {

    public static invokeTest instance;
    void Start () {

        // 以下是测试1
        //Get(0);
        //Get(1);
        //Get(2);
        // 以下是测试2 
        instance = this;
        DontDestroyOnLoad(this);
    }

    // 测试1：说明Invoke可以调用方法，但不能直接调用协程，可以将协程包装在方法中来进行调用
    public void Get(int num) {
        if (num ==0)
        {
            Invoke("method", 3);
        }
        else if(num == 1)
        {
            Invoke("iet", 3);
        }
        else if (num == 2)
        {
            Invoke("set", 3);
        }

        
    }
    void method() {
        Debug.Log("调用了方法");
    }
    IEnumerator iet()
    {
        yield return null;
        Debug.Log("调用了协程");
    }

    void set() {
        StartCoroutine(setie());
    }
    IEnumerator setie() {
        yield return null;
        Debug.Log("调用了方法中的协程");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadSceneAsync(4,LoadSceneMode.Single);
        }
    }

}

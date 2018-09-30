using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class a : MonoBehaviour {
    //测试说明：协程或Timer中断时，本次协程或Timer方法需要运行完毕，才会结束
    IEnumerator oo;
    Coroutine method;
    void Start () {
        m_Timer();
        //method = StartCoroutine(myienum());
        //StopCoroutine(method);
        //oo = myienum();
        //StartCoroutine(oo);
        //StopCoroutine(oo);
        StartCoroutine("myienum");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    float timer = 10;
    public static Timer time;
    void m_Timer()
    {
        time = new Timer();
        time.AutoReset = true;
        time.Interval = 1000;
        time.Elapsed += new ElapsedEventHandler(calGameTime);
        time.Start();
    }
    // 测试说明：可以在委托方法中中断，但是这里说要注意一点，当方法A是个循环，或者无法达到下一步，就需要注意了
    private void calGameTime(object sender, ElapsedEventArgs e)
    {
        timer--;
        // 假设这有个方法A
        if (timer<=0)
        {
            time.Close();
            time.Dispose();
            Debug.Log("测试中断时，当前Timer是否会走完，还是直接中断" + timer);
        }

    }
    // 测试说明：关闭所有是可以关闭自身
    // 只有用方法开启的协程无法关闭，其余的字符串，Coroutine，IEnumerator都可以关闭协程
    IEnumerator myienum() {
        while (true)
        {
            Debug.Log(timer);
            if (timer<=5)
            {
                StopCoroutine("myienum");
                Debug.Log("测试中断时，当前协程是否会走完，还是直接中断"+timer);
                //StopAllCoroutines();
                //StopCoroutine(oo);
                //StopCoroutine(method);
            }
            yield return null;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class timetest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        m_Timer();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public static Timer time;
    float Game3time = 3;
    void m_Timer()
    {
        time = new Timer();
        time.AutoReset = true;
        time.Interval = 1000;
        time.Elapsed += new ElapsedEventHandler(calGameTime);
        time.Start();
    }
    void calGameTime(object sender, System.Timers.ElapsedEventArgs e)
    {
        Game3time--;
        if (Game3time >= 0)
        {
            Debug.Log("正在倒计时" + Game3time);

        }
        if (Game3time < 0)
        {
            outinstance.instance.gettime();
            time.Close();
            time.Dispose();
            Debug.Log("停止倒计时"+ Game3time);
        }

    }
}

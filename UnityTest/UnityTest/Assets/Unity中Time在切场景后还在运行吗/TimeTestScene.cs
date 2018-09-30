using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeTestScene : MonoBehaviour
{
    private Timer time;
    private float timer = 10;
    void Start()
    {
        SetTime();
    }
    // 从下面的测试看出：
    // Timer类是非托管的，当timer小于5时，跳入下一个场景，在本场景中的Update自然没法执行下去，也就是说time这个方法没有关闭，会一直执行
    // 就算Unity停止运行，它还会自己执行，因为它是非托管的，系统的内存不会自己释放。
    // 所以就需要注意：何时关闭 time 对象
    void Update()
    {
        if (timer<=0)
        {
            //    time.Close();
            //    time.Dispose();
        }
        if (timer<=5)
        {
            // 从下面的实验可以看出，即使加载了下一个场景，这个Update中的方法也是会先运算结束，才会进入下一个场景
            SceneManager.LoadSceneAsync(1, LoadSceneMode.Single);
            //SceneManager.LoadScene(1,LoadSceneMode.Single);
            for (int i = 0; i < 10000; i++)
            {
                Debug.Log("11");
            }
            time.Close();
            time.Dispose();
        }
    }

    void SetTime()
    {
        time =new Timer();
        time.Interval = 1000;
        time.Enabled = true;
        time.Elapsed += Time_Elapsed; 
        time.Start();
    }

    private void Time_Elapsed(object sender, ElapsedEventArgs e)
    {
        timer--;
        Debug.Log("场景1中的打印"+ timer);
    }

    

}

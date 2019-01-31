using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorTimeScale : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    //StartCoroutine(TestTimeScale());
	    StartCoroutine(Test());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private IEnumerator TestTimeScale()
    {
        yield return new WaitForSeconds(1);
        print("11");
        Time.timeScale = 0.8f;
        yield return new WaitForSeconds(1);
        print("11");
        Time.timeScale = 0f;
        yield return new WaitForSeconds(1);//这里就永远不会执行下去了
        print("11");
    }

    private IEnumerator Test()
    {
        yield return new WaitForSecondsRealtime(1);//这里 会按实际时间进行，不受 Time.timeScale 的影响
        print("22");
        Time.timeScale = 0.8f;
        yield return new WaitForSecondsRealtime(1);
        print("22");
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(1);
        print("22");
    }
}

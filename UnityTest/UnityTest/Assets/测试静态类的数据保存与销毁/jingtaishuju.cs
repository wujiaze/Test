using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jingtaishuju : MonoBehaviour
{
    public static jingtaishuju instance;
    public static float shuju1 = 5;
	void Start ()
	{
	    instance = this;
        DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.A))
	    {
	        shuju1 = 10;
	        SceneManager.LoadSceneAsync(7, LoadSceneMode.Single);
	    }
	    if (Input.GetKeyDown(KeyCode.Q))
	    {
	        Debug.Log(shuju1);
	    }
    }

    public  float get()
    {
        return shuju1;
    }

    public void set(float x)
    {
        shuju1 = x;
    }
}

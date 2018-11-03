#pragma warning disable 414

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubebase1 : MonoBehaviour {

    public Vector3 pos { get; set; }

    public Transform trans { get; set; }
    void Awake()
    {
        //SetPos();
        if (trans != null)
        {
            SetTransPos();
        }
        Debug.Log("Awake  transform.position" + transform.position);
    }

    void OnEnable()
    {
        isSet = false;
        //SetPos();
        Debug.Log("OnEnable  transform.position" + transform.position);
        if (trans != null)
        {
            SetTransPos();
            Debug.Log(trans.position);
        }

    }

    void Start ()
    {
        if (trans != null)
        {
            SetTransPos();
        }
        //SetPos();
        Debug.Log("Start  transform.position" + transform.position);
    }

    private bool isSet = false;
	void Update () {
	    if (Input.GetKeyDown(KeyCode.A))
	    {
	        tesonobj.instance.objlist.Enqueue(gameObject);
	        gameObject.SetActive(false);

        }
	    SetTransPos();
	    //if (!isSet)
	    //{
	    //    SetPos();
	    //    isSet = true;
	    //    Debug.Log(transform.position);
	    //}
	}

    void SetPos()
    {
        transform.position = pos;
    }

    void SetTransPos()
    {
        transform.position = trans.position;
    }
}

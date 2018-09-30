using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubedsfdsf : MonoBehaviour {

    private void Awake()
    {
        Debug.Log("Awake");
    }
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    void Start () {
        Debug.Log("Start");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            // 强行推入同一个物体两次
            gameObject.SetActive(false); 
            gameteata.instance.queue.Enqueue(gameObject);
            gameteata.instance.queue.Enqueue(gameObject);
        }
	}
    private void LateUpdate()
    {
        Debug.Log("LateUpdate");
    }
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
    private void OnBecameInvisible()
    {
        Debug.Log("OnBecameInvisible");
    }
    private void OnGUI()
    {
        Debug.Log("OnGUI");
    }
    private void OnBecameVisible()
    {
        Debug.Log("OnBecameVisible");
    }
    private void OnApplicationQuit()
    {
        Debug.Log("OnApplicationQuit");
    }
}

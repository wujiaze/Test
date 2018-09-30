using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageController : MonoBehaviour {

    public GameObject imagePrefab;
    private void Awake()
    {
        StartCoroutine(pp());
       
    }
    IEnumerator pp() {
        for (int i = 0; i < 100; i++)
        {
            GameObject ip = Instantiate(imagePrefab);
            ip.transform.localPosition = new Vector3(360, 0, 0);
        }
        yield return null;
    }
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
       
    }

}

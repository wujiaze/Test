using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentActiveTest : MonoBehaviour {

    private void OnEnable()
    {
        print("Parent  OnEnable");
    }

    private void OnDisable()
    {
        print("Parent  OnDisable");
    }
}

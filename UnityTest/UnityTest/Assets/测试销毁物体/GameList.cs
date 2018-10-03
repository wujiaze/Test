using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameList : MonoBehaviour
{
    private List<UIBase> list;

    private List<UIBase> list2;
    
    /* 测试说明 销毁游戏对象，不影响内存*/
    void Start()
    {
        UIBase uibase = Resources.Load<UIBase>("测试销毁物体/UI1");
        list = new List<UIBase>();
        list.Add(uibase);
        UIBase u1 = Instantiate(uibase);
        list2 = new List<UIBase>();
        list2.Add(u1);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Destroy(list2[0].gameObject);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            print(list[0]);
            print(list2[0]);
        }
        
    }
}

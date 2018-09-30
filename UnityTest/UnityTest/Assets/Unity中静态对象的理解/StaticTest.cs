using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StaticTest /*: MonoBehaviour*/
{
    public static StaticTest instance;
    public static GameObject obj;
    public GameObject obj2;
    public static int value = 5;
    public int value2 = 10;
    public static int value3;
    private float timer = 0;
	void Start ()
	{
	    instance = this;
        
		obj =  GameObject.CreatePrimitive(PrimitiveType.Cube);
        // 从下面的测试可以看出：本场景中的存在的静态物体或非静态物体，切换到另一场景后是回收的
        // 除非挂载不销毁的物体上
        //obj.transform.SetParent(this.transform);
	    obj2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //obj2.transform.SetParent(this.transform);

        // 下面是超级重点：
        // 静态对象是随着类的加载而加载的 ： 即这个类只要创建出来了，不管有没有继承 MonoBehaviour 或者 挂在游戏对象上
        // 静态对象的值都已经加载上了，即被赋值了，在内存的静态区;
        // 所以上面数据中：当本类没有继承MonoBehaviour时， instance =null ；obj =null ；value =5；value3 =0 
        // 而其余非静态对象，则都没有赋值 ： value2  obj2  timer
        // 当这个类继承了 MonoBehaviour 或者挂在了游戏对象上，静态值还是不改变的，除非重新赋值
        value3 = 15;

        //DontDestroyOnLoad(this);
    }

    private bool isload = false;
	void Update ()
	{
	    timer += Time.deltaTime;
	    if (timer>3 &&!isload)
	    {
	        isload = true;
            SceneManager.LoadSceneAsync(2);
	    }

	}
}

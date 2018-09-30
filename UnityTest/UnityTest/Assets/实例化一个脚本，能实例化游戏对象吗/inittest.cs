

	using UnityEngine;
public class inittest :MonoBehaviour
{
    private GameObject tmp;
    private ioioio pppp;
    //测试说明：实例化游戏对象上的脚本，也可以实例化游戏对象，并且直接得到脚本的引用
        void Awake()
	    {
	        tmp = GameObject.Find("Cube");
	        pppp = GameObject.Find("Cube").GetComponent<ioioio>();

	    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(tmp);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(pppp);
        }
    }

}

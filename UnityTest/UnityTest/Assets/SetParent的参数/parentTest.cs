
using UnityEngine;
namespace SimpleUIFramework
{
	public class parentTest : MonoBehaviour
	{
	    public Transform child;
	    public Transform parent;
        // 测试说明：SetParent 默认是 true，
        // true 代表：仅仅是添加了父物体，但是自身状态不会改变
        // false 代表：添加了父物体，并且原来相对于世界坐标的Transform属性的值会转变成相对于父物体坐标的值
        void Start () {
			child.SetParent(parent,false);
		}
	
		void Update (){
			
		}
	}
}
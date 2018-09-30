
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenetrst : MonoBehaviour 
	{	

		void Start () {
			DontDestroyOnLoad(this);
		}
	
		void Update (){
		    if (Input.GetKeyDown(KeyCode.A))
		    {
		        SceneManager.LoadSceneAsync(1);
		    }
		}
	}

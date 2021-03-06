using UnityEngine;
using KBEngine;
using System; 

public class UI_Minimap : MonoBehaviour {
	bool showBigMap = false;
	
	void Awake ()     
	{
		Common.DEBUG_MSG("UI_Minimap::Awake()");
	}
	
	// Use this for initialization
	void Start () {
		Common.DEBUG_MSG("UI_Minimap::Start()");
	}

	void Update()
	{
        if (Input.GetKeyUp(KeyCode.M))
        {
        	onShowBigMap();
        }
	}
	
	void onShowBigMap()
	{
		showBigMap = !showBigMap;
		Common.DEBUG_MSG("UI_Minimap::onShowBigMap: bigmap(" + showBigMap + ")!");
		
		if(showBigMap == true)
		{
			worldmap_getpic.show(); 
		}
		else
		{
			worldmap_getpic.hide();
		}
	}
	
	void OnMouseEnter ()
	{
		Common.DEBUG_MSG("UI_Minimap::OnMouseEnter");
	}
	
	void OnMouseOver ()
	{
		Common.DEBUG_MSG("UI_Minimap::OnMouseOver");
	}
	
	void OnMouseExit ()
	{
		Common.DEBUG_MSG("UI_Minimap::OnMouseExit");
	}
}
 
using UnityEngine;
using System.Collections;

public class PanelSlide : MonoBehaviour {

	bool isMoving = false;
	bool isShowing = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void triggerPanel(){
		if (!isMoving && !isShowing) {
			isMoving = true;
		} else if (isMoving && !isShowing) {
			
		}
	}


}

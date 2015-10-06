using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SplashFade : MonoBehaviour {
	public GoogleAnalyticsV3 googleAnalytics;

	bool splashFade = false;
	int timer = 0;
	int splashDur = 100;

	 Image splashImage;
	// Use this for initialization
	void Start () {
		splashImage = gameObject.GetComponent<Image> ();
		DontDestroyOnLoad (this);

		googleAnalytics.StartSession ();
		googleAnalytics.LogScreen ("Splash");
		googleAnalytics.DispatchHits ();
		//googleAnalytics.
		
	}
	
	// Update is called once per frame
	void Update () {
		print (timer);
	if (!splashFade) {
			if (timer < splashDur) {
				timer ++;
			} else {
				splashFade = true;
			}
		} else {
			//Fade Splash Screen
			if(splashImage.color.a > .02f){
			splashImage.color = new Color(splashImage.color.r, splashImage.color.g,splashImage.color.b,splashImage.color.a - .02f);
			}
			else{
				splashImage.gameObject.SetActive(false);
			}
		}
	}
}

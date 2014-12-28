using UnityEngine;
using System.Collections;

public class Global : MonoBehaviour {
    public static int FPS = 60;
    public static ArrayList inputs = new ArrayList();


	void Start () {
        Application.targetFrameRate = FPS;
	}
}

using UnityEngine;
using System.Collections;

public class Clicker {
	public bool clicked() {
		bool triggerDown = Input.anyKeyDown;
		return triggerDown;
	}
}

using UnityEngine;
using System.Collections;
using System;

public class OnDeathEventArgs : EventArgs {
	public string type;
	public Transform transform;
	
	public OnDeathEventArgs(string type,  Transform transform){
		this.type = type;
		this.transform = transform;
	}
}

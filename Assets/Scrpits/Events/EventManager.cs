using UnityEngine;
using System.Collections;
using System;

public delegate void GameEvent(OnDeathEventArgs args);

public class EventManager : MonoBehaviour {

	
	public static event GameEvent OnDeath;

	public static void TriggerOnDeath(OnDeathEventArgs args){
		if(OnDeath != null){
			OnDeath(args);			
		}	
	}
}

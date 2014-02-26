using UnityEngine;
using System.Collections;
using System;

public delegate void GameEvent(OnDeathEventArgs args);
public delegate void ScoreEvent(int score);

public class EventManager : MonoBehaviour {

	
	public static event GameEvent OnDeath;
	public static event ScoreEvent AddScore;

	public static void TriggerOnDeath(OnDeathEventArgs args){
		if(OnDeath != null){
			OnDeath(args);			
		}	
	}
	
	public static void TriggerAddScore(int score){
		if(AddScore != null){
			AddScore(score);
		}
	}
}

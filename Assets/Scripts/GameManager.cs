using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Board Board;

	// Use this for initialization
	void Start ()
    {
        Board.Create();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

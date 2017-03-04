using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class tile : MonoBehaviour {

	mapController controller;
	int x,y;// 2d coordinates
	/*
	 * O = empty, traversable tile
	 * X = impassible wall
	 * U/D/L/R = starting location, with facing location
	 * 1,2,3 = locked doors
	 * a,b,c = button to unlock corresponding door (a=1,b=2,c=3)
	 * x,y,z = teleporter, comes in pairs, with each pointing to each other (x->x)
	 * M = mine, invisible first person, visible on top down map
	 * E = exit
	 */
	char type;

	// Use this for initialization
	public tile (int x,int y, char type,mapController controller) {
		this.x = x;
		this.y = y;
		this.type = type;
		this.controller = controller;
		if (!handleType ())
			Debug.Log ("error setting type: "+type);
	}


	
	// Update is called once per frame
	void Update () {
		
	}

	bool handleType()//depending on type, spawns and links objects accordingly
	{
		type = type.ToUpper();
		switch(type)
		{
		case('O'):
			{
				//do nothing
				break;
			}
		case('X'):
			{
				//instatiante wall at x,y
				break;
			}
		case('U'):
			{
				//spawn player facing up
				break;
			}
		case('D'):
			{
				//spawn player facing up
				break;
			}
		case('L'):
			{
				//spawn player facing up
				break;
			}
		case('R'):
			{
				//spawn player facing up
				break;
			}
		case('1'):
			{
				//spawn door, if btn available, link them
				break;
			}
		case('2'):
			{
				//spawn door, if btn available, link them
				break;
			}
		case('3'):
			{
				//spawn door, if btn available, link them
				break;
			}
		case('A'):
			{
				//spawn btn, if door available, link them
				break;
			}
		case('B'):
			{
				//spawn btn, if door available, link them
				break;
			}
		case('C'):
			{
				//spawn btn, if door available, link them
				break;
			}
		case('X'):
			{
				//spawn teleporter, if other x is available, link them
				break;
			}
		case('Y'):
			{
				//spawn teleporter, if other y is available, link them
				break;
			}
		case('Z'):
			{
				//spawn teleporter, if other z is available, link them
				break;
			}
		case('M'):
			{
				//spawn mine
				break;
			}
		case('E'):
			{
				//spawn exit
				break;
			}
		default:
			{
				return false;
			}
		}
		return true;
	}
}

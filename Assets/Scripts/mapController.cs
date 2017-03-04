using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class mapController : MonoBehaviour {


	tile[,] board;
	teleporter[] teleX;
	teleporter[] teleY;
	teleporter[] teleZ;
	door door1;
	door door2;
	door door3;
	button btnA;
	button btnB;
	button btnC;
	//positions for use of navmesh agent
	Transform exitPos;
	Transform startPos;



	// Use this for initialization
	void Start () {
		//read text file, get map dimensions, iterate and make tiles
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void readFile(string filename)
	{
		FileStream F = new FileStream (filename, FileMode.Open, FileAccess.Read);
		int count = 0;
		while (F.ReadByte () != '\n')
			count++;
		F.Position = 0;//reset postion to start of file
		board = new tile[F.Length/count,count];
		for(int x = 0;x<F.Length/count;x++)
		{
			for(int y = 0;y<count;y++)
			{
				board [x,y] = new tile (x, y, F.ReadByte(),this);
			}
		}
	}

	public void setTeleporter(teleporter tele,int type)//assign and link teleporters of same type
	{
		//type is if it's X,Y,Z, with 0=x,1=y,2=z
		if(type == 0)//X
		{
			if (teleX [0] != null) {
				teleX [1] = tele;
				//link em
			} else
				teleX [0] = tele;
		}
		else if(type == 1)//y
		{
			if (teleY [0] != null) {
				teleY [1] = tele;
				//link em
			} else
				teleY [0] = tele;
		}
		else if(type == 2)//z
		{
			if (teleZ [0] != null) {
				teleZ [1] = tele;
				//link em
			} else
				teleZ [0] = tele;
		}
	}

	public void setDoor(door doorObj,int type)//assign and link doors with btns
	{
		//type is if it's 1,2,3
		if(type == 1)
		{
			door1 = doorObj;
			if(btnA != null)
			{
				//link em
			}
		}
		else if(type == 2)
		{
			door2 = doorObj;
			if(btnB != null)
			{
				//link em
			}
		}
		else if(type == 3)
		{
			door3 = doorObj;
			if(btnB != null)
			{
				//link em
			}
		}
	}

	public void setButton(button btn,int type)//assign and link btns to doors
	{
		//type is if it's 1,2,3 with 0=a,1=b,2=c
		if(type == 0)
		{
			btnA = btn;
			if(door1 != null)
			{
				//link em
			}
		}
		else if(type == 1)
		{
			btnB = btn;
			if(door2 != null)
			{
				//link em
			}
		}
		else if(type == 2)
		{
			btnC = btn;
			if(door3 != null)
			{
				//link em
			}
		}
	}

	public void setStart(Transform pos)
	{
		startPos = pos;
	}

	public void setEnd(Transform pos)
	{
		exitPos = pos;
	}
}

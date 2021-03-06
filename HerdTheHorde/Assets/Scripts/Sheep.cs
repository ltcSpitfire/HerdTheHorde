﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : MonoBehaviour {

	//private GameManager gmScript;
	private Draggable draggableScript;
    private Animator animator;

    public string race;
    public string type;

	//public Sprite bulgedSprite;
    //private Sprite defaultSprite;

	[Header("Movement")]
	public float speed;
	public float movingTime;
	public float idleTime;

	[Header("Dragging")]
	[Tooltip("Negative values push the sheep away from cursor.")]
	public float dragSensitivity;

	[Header("Score")]
	public int scoreValue;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start () {
        //gmScript = GameObject.Find("_manager").GetComponent<GameManager>();
        draggableScript = GetComponent<Draggable>();

        //defaultSprite = gameObject.GetComponent<SpriteRenderer>().sprite;
    }

    public void SheepBulge()
    {
        //gmScript.SheepOnCursor(this.gameObject);

		//Instead, set animator controller to do this, so new animation for bulge instead of still sprite
		//currently works but animator overrules so if you want to see this, lets disable animator
		if (!draggableScript.isMouseUp)	//on sheep click
		{
            //this.gameObject.GetComponent<Animator>().enabled = false;
            //this.gameObject.GetComponent<SpriteRenderer>().sprite = bulgedSprite;
            animator.SetBool("isCaught", true);

		}

		if (draggableScript.isMouseUp)   //on sheep release
		{
            //this.gameObject.GetComponent<Animator>().enabled = true;
            //this.gameObject.GetComponent<SpriteRenderer>().sprite = defaultSprite;
            animator.SetBool("isCaught", false);
        }
    }
}

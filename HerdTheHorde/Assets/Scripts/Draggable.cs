﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Draggable : MonoBehaviour {

	private Vector3 offset;
    public bool canDrag;
    public bool isMouseUp;

    private void Awake()
    {
        canDrag = true;
    }

    void OnMouseDown()
	{
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        isMouseUp = false;
	}

	public void OnMouseDrag()
	{
        if (!canDrag) return;

        if (canDrag)
        {
            Vector2 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
	}

    private void OnMouseUp()
    {
        isMouseUp = true;
    }

}

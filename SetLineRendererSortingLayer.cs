using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Sets SortingLayer of Component GameObject's LineRenderer Component.
/// </summary>
public class SetLineRendererSortingLayer : MonoBehaviour 
{

	public LineRenderer lr;
	public string SortingLayer;
	public int OrderInLayer;

	void Awake() 
	{
		lr = this.GetComponent<LineRenderer>();
	}

	void Update() 
	{
		lr.sortingLayerName = SortingLayer;
		lr.sortingOrder = OrderInLayer;
	}
		
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointOnLineSegment : MonoBehaviour {

	public Transform point;
	public Transform lineStart;
	public Transform lineEnd;
	public float gizmosSize = 1;

	void Start () {
		
	}
	
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Debug.Log (MathUtility.IsPointOnLineSegment(point.position,lineStart.position,lineEnd.position));
		}
	}

	void OnDrawGizmos(){
		if (Application.isPlaying) {
			Gizmos.DrawSphere (point.position, gizmosSize);
			Gizmos.DrawSphere (lineStart.position, gizmosSize);
			Gizmos.DrawSphere (lineEnd.position, gizmosSize);
			Gizmos.DrawLine (lineStart.position, lineEnd.position);
		}
	}

}

using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
		public Transform target;
		public bool on;

		void Start ()
		{
			transform.position = target.position;
		}

		void Update ()
		{
		}
}



using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
		public Transform target;

		void Start ()
		{
			transform.position = target.position;
		}
}

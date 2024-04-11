using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogAwake : MonoBehaviour
{
	private void Awake()
	{
		Debug.Log($"[LogAwake], go: {gameObject.name}", this);
	}
}

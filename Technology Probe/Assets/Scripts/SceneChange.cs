using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
	public void ChangeScene(string sceneName)
	{
		print(sceneName);
		StartCoroutine(waitAndChangeScene(sceneName));
	}
	public void Exit()
	{
		Application.Quit ();
	}

	IEnumerator waitAndChangeScene(string sceneName)
    {
		yield return new WaitForSeconds(1);
		SceneManager.LoadScene(sceneName);
	}
}

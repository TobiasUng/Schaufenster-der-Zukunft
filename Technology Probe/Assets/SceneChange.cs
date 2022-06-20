using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
	public void ChangeScene(string sceneName)
	{
		print(sceneName);
		SceneManager.LoadScene("SampleScene");
	}
	public void Exit()
	{
		Application.Quit ();
	}
}

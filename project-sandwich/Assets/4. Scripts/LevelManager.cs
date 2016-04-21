using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour 
{

	public void ChangeLevel()
	{
		int i = Application.loadedLevel;

		Application.LoadLevel(i + 1);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}

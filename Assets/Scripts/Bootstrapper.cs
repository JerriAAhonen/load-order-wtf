using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bootstrapper : MonoBehaviour
{
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	static async void Init()
	{
		Debug.Log("Bootstrapper...");
		await SceneManager.LoadSceneAsync("Bootstrapper", LoadSceneMode.Single).AsTask();
	}
}

public static class Extensions
{
	/// <summary>
	/// Extension method that converts an AsyncOperation into a Task.
	/// </summary>
	/// <param name="asyncOperation">The AsyncOperation to convert.</param>
	/// <returns>A Task that represents the completion of the AsyncOperation.</returns>
	public static Task AsTask(this AsyncOperation asyncOperation)
	{
		var tcs = new TaskCompletionSource<bool>();
		asyncOperation.completed += _ => tcs.SetResult(true);
		return tcs.Task;
	}

}
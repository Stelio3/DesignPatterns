using System.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace Command
{
    public class LoadSceneCommand : ICommand
    {
        private readonly string _sceneName;

        public LoadSceneCommand(string sceneName)
        {
            _sceneName = sceneName;
        }

        public async Task Execute()
        {
            var asyncOperation = SceneManager.LoadSceneAsync(_sceneName);
            while (!asyncOperation.isDone)
            {
                await Task.Yield();
            }
        }
    }
}

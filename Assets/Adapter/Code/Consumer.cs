using System;
using Code.Parsers;
using Code.Requests;
using Code.Responses;
using Code.RestClient;
using UnityEngine;
using UnityEngine.UI;

namespace Code
{
    public class Consumer : MonoBehaviour
    {
        private string _token;
        private const string NewGame = "https://hangman-api.herokuapp.com/hangman";
        private const string Solution = "https://hangman-api.herokuapp.com/hangman";

        [SerializeField] private Text _wordText;
        private RestRestClient _restRestClient;

        private void Awake()
        {
            //_restRestClient = new RestRestClient(new UnityJsonUtilizeAdapter());
            _restRestClient = new RestRestClient(new JsonNetAdapter());
        }

        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.F1))
            {
                StartNewGame();
            }
            else if (Input.GetKeyUp(KeyCode.F2))
            {
                GetSolution();
            }
        }

        private async void StartNewGame()
        {
            var response = await _restRestClient.Post<Request, NewGameResponse>(NewGame, new Request());
            _token = response.token;
            Debug.Log(response.hangman);
            _wordText.text = response.hangman;
        }

        private async void GetSolution()
        {
            var response =
                await _restRestClient.Get<GetSolutionRequest, GetSolutionResponse>(Solution,
                    new GetSolutionRequest {token = _token});
            Debug.Log(response.solution);
            _wordText.text = response.solution;
        }
    }
}
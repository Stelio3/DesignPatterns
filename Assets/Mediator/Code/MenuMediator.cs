using UnityEngine;

public class MenuMediator : MonoBehaviour
{
    [SerializeField] private MainMenu _mainMenu;
    [SerializeField] private SettingsMenu _settingsMenu;

    private void Awake()
    {
        _settingsMenu.Configure(this);
        _mainMenu.Configure(this);
        
        _settingsMenu.Hide();
    }

    public void BackToMainMenu()
    {
        _mainMenu.Show();
        _settingsMenu.Hide();
    }

    public void StartGame()
    {
        Debug.Log("¡A jugar!");
    }

    public void MoveToSettingsMenu()
    {
        _mainMenu.Hide();
        _settingsMenu.Show();
    }
}

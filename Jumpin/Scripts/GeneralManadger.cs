using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class GeneralManadger : MonoBehaviour
{
    //public static GeneralManadger GM;

    PlayerTrigger PT;    
    [SerializeField] Text _text_score;
    [SerializeField] GameObject FullPanel,WinPanel;
    public int Scorewin;
    int _score;
    void Start()
    {
        PauseOff();
        //GM = this;    
        PT = FindObjectOfType<PlayerTrigger>();
        PT._score.AddListener((Scor) => _text_score.text = Scor.ToString());
        PT._score.AddListener((Scor) => _score = Scor);
    }

   public void Full()
    {
        FullPanel.SetActive(true); PauseOn();

    }

    public void Win()
    {
        WinPanel.SetActive(true); PauseOn();

    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   public void PauseOn() { Time.timeScale = 0; }
    public void PauseOff() { Time.timeScale = 1; }
}

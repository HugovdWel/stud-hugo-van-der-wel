using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public int deathHeight;
    public int lives;
    public string neutralMenuSceneName;
    public string winMenuSceneName;
    public string loseMenuSceneName;
    public Vector3 spawnPoint;
    public Vector3 spawnRotation;
    public GameObject player;

    private int _amountOfCheckpointsNotReached;

    private void Start()
    {
        player.transform.position = spawnPoint;
        player.transform.rotation = Quaternion.Euler(spawnRotation);
        _amountOfCheckpointsNotReached = GameObject.FindGameObjectsWithTag("Checkpoint").Length;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            SetSceneToMenu(neutralMenuSceneName);
        }

        if (player.transform.position.y > deathHeight) return;

        lives--;
        if (lives < 1)
        {
            SetSceneToMenu(loseMenuSceneName);
        }

        player.transform.position = spawnPoint;
        player.transform.rotation = Quaternion.Euler(spawnRotation);
        player.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
    }

    private void OnEnable()

    {
        CheckpointController.CheckPointReached += RegisterCheckpointReached;
    }

    private void OnDisable()
    {
        CheckpointController.CheckPointReached -= RegisterCheckpointReached;
    }


    private void RegisterCheckpointReached(CheckpointController checkpoint)
    {
        var checkPointTransform = checkpoint.transform;
        
        _amountOfCheckpointsNotReached--;
        spawnPoint = checkPointTransform.position + checkpoint.spawnLocationInCheckpoint;
        spawnRotation = checkPointTransform.forward;
        
        if (_amountOfCheckpointsNotReached == 0)
        {
            SetSceneToMenu(winMenuSceneName);
        }
    }

    private void SetSceneToMenu(string menuScene)
    {
        SceneManager.LoadScene(menuScene, LoadSceneMode.Single);
    }
}
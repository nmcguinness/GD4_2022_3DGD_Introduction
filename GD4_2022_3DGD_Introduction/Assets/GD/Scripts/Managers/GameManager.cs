using System.Collections;
using UnityEngine;

namespace GD
{
    public class GameManager : MonoBehaviour
    {
        #region Fields

        [SerializeField]
        [Range(0, 10)]
        private float startWaitSeconds;

        [SerializeField]
        [Range(0, 10)]
        private float playWaitSeconds;

        [SerializeField]
        [Range(0, 10)]
        private float endWaitSeconds;

        private WaitForSeconds startWait;
        private WaitForSeconds endWait;
        private WaitForSeconds playLevelWait;
        private bool isPaused;

        #endregion Fields

        // Start is called before the first frame update
        private void Start()
        {
            //instanciate the waits used by start, play, or end functions
            InitializeWaits();

            //STUDENTCODE - 1
            //SpawnNPC();
            //SpawnPickups();
            //SpawnPlayers();

            //start the main loop that will perform start/end actions and check win/lose logic
            StartCoroutine(GameLoop());
        }

        //don't forget to stop any running code on destroy
        private void OnDestroy()
        {
            StopAllCoroutines();
        }

        private void InitializeWaits()
        {
            startWait = new WaitForSeconds(startWaitSeconds);
            endWait = new WaitForSeconds(endWaitSeconds);
            playLevelWait = new WaitForSeconds(playWaitSeconds);
        }

        private IEnumerator GameLoop()
        {
            yield return StartCoroutine(StartLevel());
            yield return StartCoroutine(PlayLevel());
            yield return StartCoroutine(EndLevel());
        }

        private IEnumerator StartLevel()
        {
            ShowStartToast();   //e.g. "Get Ready!...5..4..3..2..1"
            yield return startWait;
        }

        private IEnumerator PlayLevel()
        {
            //loop until some end condition is reached e.g. all objectives have been completed, all inventory items collected etc
            for (; ; ) //we will replace this infinite loop with some termination boolean expression e.g. while(isCompleted == false)
            {
                //add the game logic here that tests for end conditions
                CheckWinLose();                                                             //STUDENTCODE - 2

                //yield if the game is paused i.e. showing a menu
                yield return new WaitWhile(() => isPaused);

                //yield control for a period of time
                yield return playLevelWait;
            }
        }

        private IEnumerator EndLevel()
        {
            ShowWinLoseToast();   //e.g. "You won!"
                                  //SaveGameData();       //e.g. asynchronously store using AssetDatabase, simple write JSON to file, or network save

            //wait for N seconds to show the toast
            yield return endWait;

            //raise an event to show the main menu
            //Event: MainMenu - Show
            //     Debug.Log($"Goodbye at {Time.realtimeSinceStartup}");
        }

        public void Play()
        {
            isPaused = false;
        }

        public void Pause()
        {
            isPaused = true;
        }

        //we don't need to use the Update() but we can if we want to perform an operation at the normal update frequency of the game
        private void Update()
        {
            //demo code which we will remove later and instead respond to the OnPause/OnResume event
            if (Input.GetKeyDown(KeyCode.P))
            {
                isPaused = !isPaused;
            }

            //pause and unpause the game (affects physics, animations)
            if (isPaused)
                Time.timeScale = 0;
            else
                Time.timeScale = 1;
        }

        //STUDENTCODE - 3
        private void ShowStartToast()
        {
            //       Debug.Log($"ShowStartToast at {Time.realtimeSinceStartup}");
        }

        //STUDENTCODE - 4
        private void CheckWinLose()
        {
            //      Debug.Log($"CheckWinLose at {Time.realtimeSinceStartup}");
        }

        //STUDENTCODE - 5
        private void ShowWinLoseToast()
        {
            //     Debug.Log($"ShowWinLoseToast at {Time.realtimeSinceStartup}");
        }
    }
}
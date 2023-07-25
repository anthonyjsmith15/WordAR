using UnityEngine.XR.ARFoundation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static System.Net.Mime.MediaTypeNames;
using System;
using UnityEngine.UI;
using System.Text;
using UnityEditor;
using System.IO;
using Random = UnityEngine.Random;
using Debug = UnityEngine.Debug;
using System.Diagnostics;
using TMPro;
using System.Reflection;
using UnityEngine.Video;
using Unity.Services.Core;
using Unity.Services.Authentication;
using Unity.Services.Leaderboards;
using System.Threading.Tasks;



public class SpawnableCubeManagerPractice : MonoBehaviour
{

    [SerializeField]
    ARRaycastManager m_RaycastManager;
    List<ARRaycastHit> m_Hits = new List<ARRaycastHit>();
    [SerializeField]
    GameObject spawnablePrefab;

    public Camera arCam;
    public Camera threeDcamera;
    GameObject spawnedObject;
    private GameObject target;
    private GameObject targetSpawned;
    private Vector3 scaleChange, positionChange;
    private GameObject cube1;
    private GameObject cube2;
    private GameObject cube3;
    private GameObject cube4;
    private GameObject cube5;
    private GameObject cube6;
    private GameObject cube7;
    private GameObject cube8;
    private GameObject cube9;
    public static string word = "_ _ _ _ _ _ _";
    public static string letter1 = "";
    public static string letter2 = "";
    public static string letter3 = "";
    public static string letter4 = "";
    public static string letter5 = "";
    public static string letter6 = "";
    public static string letter7 = "";
    private static int lettersCount = 0;
    public static string finalWord = "";
    public TextAsset dictionary;
    public static string arr = "";
    private System.Collections.Generic.HashSet<string> _set;
    public float timerStart = 121;
    public TextMeshPro timerComponent;
    [SerializeField]
    Font cubeSideFont;
    public static int letter1Score;
    public static int letter2Score;
    public static int letter3Score;
    public static int letter4Score;
    public static int letter5Score;
    public static int letter6Score;
    public static int letter7Score;
    public static double currentScore;
    public static double currentTimerScore;
    public static double finalScore;
    public Button resetButton;
    private const string LeaderboardId = "WordAR_Leaderboard";
    public static bool success;
    public static bool signedIn;
    public static Ray ray;
    //public TextMeshPro wordAnswerComponent;

    [SerializeField]
    private GameObject canvas = null;

    //[SerializeField]
    //private GameObject spawnManager = null;

    //[SerializeField]
    //private GameObject textTMP = null;

    [SerializeField]
    private GameObject wordMatched = null;

    [SerializeField]
    private GameObject wordAnswer = null;

    [SerializeField]
    private GameObject countdownTimer = null;

    [SerializeField]
    private GameObject scoreDisplay = null;

    [SerializeField]
    private GameObject timerScore = null;

    [SerializeField]
    private GameObject matched = null;

    [SerializeField]
    private GameObject mainmenu = null;

    [SerializeField]
    private GameObject scorespanel = null;

    [SerializeField]
    private Button threeDbutton = null;

    //private async void Awake()
    //{
    //    //await UnityServices.InitializeAsync();
    //    //signedIn = AuthenticationService.Instance.IsSignedIn;
    //    //if (signedIn == false)
    //    //{
    //    //    await AuthenticationService.Instance.SignInAnonymouslyAsync();
    //    //}
    //}

    // Start is called before the first frame update
    void OnEnable()
    {
        //resetButton = GameObject.Find("ResetButton").GetComponent<Button>();
        //resetButton.onClick.AddListener(() => ResetPractice());

        spawnedObject = null;
        //arCam = GameObject.Find("AR Camera").GetComponent<Camera>();
        arr = dictionary.text;
        //timerComponent = GetComponent<TMPro.TextMeshPro>();
        //resetButton = GameObject.Find("ResetButton");
        //videoPlayer = VideoPlayer.Find("IntroMovie");
        

        List<string> list = new List<string>();
        list.Add("A");
        list.Add("B");
        list.Add("C");
        list.Add("D");
        list.Add("E");
        list.Add("F");
        list.Add("G");
        list.Add("H");
        list.Add("I");
        list.Add("J");
        list.Add("K");
        list.Add("L");
        list.Add("M");
        list.Add("N");
        list.Add("O");
        list.Add("P");
        list.Add("Q");
        list.Add("R");
        list.Add("S");
        list.Add("T");
        list.Add("U");
        list.Add("V");
        list.Add("W");
        list.Add("X");
        list.Add("Y");
        list.Add("Z");

        List<string> listVowels = new List<string>();

        listVowels.Add("A");
        listVowels.Add("E");
        listVowels.Add("O");
        listVowels.Add("I");
        listVowels.Add("U");
        listVowels.Add("Y");

        string[] stringArray = list.ToArray();
        string[] stringArrayVowels = listVowels.ToArray();

        string stringToRetrieve1 = GetRandomItemArray(stringArrayVowels);
        string stringToRetrieve2 = GetRandomItemArray(stringArray);
        string stringToRetrieve3 = GetRandomItemArray(stringArray);
        string stringToRetrieve4 = GetRandomItemArray(stringArray);
        string stringToRetrieve5 = GetRandomItemArray(stringArray);
        string stringToRetrieve6 = GetRandomItemArray(stringArray);
        string stringToRetrieve7 = GetRandomItemArray(stringArray);
        string stringToRetrieve8 = GetRandomItemArray(stringArray);
        string stringToRetrieve9 = GetRandomItemArray(stringArrayVowels);
        string stringToRetrieve10 = GetRandomItemArray(stringArray);
        string stringToRetrieve11 = GetRandomItemArray(stringArray);
        string stringToRetrieve12 = GetRandomItemArray(stringArray);
        string stringToRetrieve13 = GetRandomItemArray(stringArray);
        string stringToRetrieve14 = GetRandomItemArray(stringArrayVowels);
        string stringToRetrieve15 = GetRandomItemArray(stringArray);
        string stringToRetrieve16 = GetRandomItemArray(stringArray);
        string stringToRetrieve17 = GetRandomItemArray(stringArray);
        string stringToRetrieve18 = GetRandomItemArray(stringArray);
        string stringToRetrieve19 = GetRandomItemArray(stringArray);
        string stringToRetrieve20 = GetRandomItemArray(stringArray);
        string stringToRetrieve21 = GetRandomItemArray(stringArray);
        string stringToRetrieve22 = GetRandomItemArray(stringArrayVowels);
        string stringToRetrieve23 = GetRandomItemArray(stringArray);
        string stringToRetrieve24 = GetRandomItemArray(stringArray);
        string stringToRetrieve25 = GetRandomItemArray(stringArray);
        string stringToRetrieve26 = GetRandomItemArray(stringArray);
        string stringToRetrieve27 = GetRandomItemArray(stringArray);
        string stringToRetrieve28 = GetRandomItemArray(stringArray);
        string stringToRetrieve29 = GetRandomItemArray(stringArray);
        string stringToRetrieve30 = GetRandomItemArray(stringArrayVowels);
        string stringToRetrieve31 = GetRandomItemArray(stringArray);
        string stringToRetrieve32 = GetRandomItemArray(stringArray);
        string stringToRetrieve33 = GetRandomItemArray(stringArray);
        string stringToRetrieve34 = GetRandomItemArray(stringArray);
        string stringToRetrieve35 = GetRandomItemArray(stringArray);
        string stringToRetrieve36 = GetRandomItemArray(stringArray);
        string stringToRetrieve37 = GetRandomItemArray(stringArray);
        string stringToRetrieve38 = GetRandomItemArray(stringArray);
        string stringToRetrieve39 = GetRandomItemArray(stringArray);
        string stringToRetrieve40 = GetRandomItemArray(stringArray);
        string stringToRetrieve41 = GetRandomItemArray(stringArrayVowels);
        string stringToRetrieve42 = GetRandomItemArray(stringArray);
        string stringToRetrieve43 = GetRandomItemArray(stringArray);
        string stringToRetrieve44 = GetRandomItemArray(stringArray);
        string stringToRetrieve45 = GetRandomItemArray(stringArray);
        string stringToRetrieve46 = GetRandomItemArray(stringArray);
        string stringToRetrieve47 = GetRandomItemArray(stringArray);
        string stringToRetrieve48 = GetRandomItemArray(stringArray);
        string stringToRetrieve49 = GetRandomItemArray(stringArray);
        string stringToRetrieve50 = GetRandomItemArray(stringArray);
        string stringToRetrieve51 = GetRandomItemArray(stringArray);
        string stringToRetrieve52 = GetRandomItemArray(stringArray);
        string stringToRetrieve53 = GetRandomItemArray(stringArrayVowels);
        string stringToRetrieve54 = GetRandomItemArray(stringArray);

        Vector3 position = new Vector3(0.0f, 0.0f, 1.0f);

        SpawnPrefab(cubeSideFont, position, stringToRetrieve1, stringToRetrieve2, stringToRetrieve3, stringToRetrieve4, stringToRetrieve5, stringToRetrieve6,
                stringToRetrieve7, stringToRetrieve8, stringToRetrieve9, stringToRetrieve10, stringToRetrieve11, stringToRetrieve12,
                stringToRetrieve13, stringToRetrieve14, stringToRetrieve15, stringToRetrieve16, stringToRetrieve17, stringToRetrieve18,
                stringToRetrieve19, stringToRetrieve20, stringToRetrieve21, stringToRetrieve22, stringToRetrieve23, stringToRetrieve24,
                stringToRetrieve25, stringToRetrieve26, stringToRetrieve27, stringToRetrieve28, stringToRetrieve29, stringToRetrieve30,
                stringToRetrieve31, stringToRetrieve32, stringToRetrieve33, stringToRetrieve34, stringToRetrieve35, stringToRetrieve36,
                stringToRetrieve37, stringToRetrieve38, stringToRetrieve39, stringToRetrieve40, stringToRetrieve41, stringToRetrieve42,
                stringToRetrieve43, stringToRetrieve44, stringToRetrieve45, stringToRetrieve46, stringToRetrieve47, stringToRetrieve48,
                stringToRetrieve49, stringToRetrieve50, stringToRetrieve51, stringToRetrieve52, stringToRetrieve53, stringToRetrieve54
                );

        StartCoroutine(MoveOverSeconds(cube1, new Vector3(-0.75f, -1.0f, 3.75f), 2.5f));
        StartCoroutine(waiter());
        StartCoroutine(MoveOverSeconds(cube2, new Vector3(0f, -1.0f, 3.75f), 2.5f));
        StartCoroutine(waiter());
        StartCoroutine(MoveOverSeconds(cube3, new Vector3(0.75f, -1.0f, 3.75f), 2.5f));
        StartCoroutine(waiter());
        StartCoroutine(MoveOverSeconds(cube4, new Vector3(-0.75f, -1.0f, 3f), 2.5f));
        StartCoroutine(waiter());
        StartCoroutine(MoveOverSeconds(cube5, new Vector3(0f, -1.0f, 3f), 2.5f));
        StartCoroutine(waiter());
        StartCoroutine(MoveOverSeconds(cube6, new Vector3(0.75f, -1.0f, 3f), 2.5f));
        StartCoroutine(waiter());
        StartCoroutine(MoveOverSeconds(cube7, new Vector3(-0.75f, -1.0f, 2.25f), 2.5f));
        StartCoroutine(waiter());
        StartCoroutine(MoveOverSeconds(cube8, new Vector3(0f, -1.0f, 2.25f), 2.5f));
        StartCoroutine(waiter());
        StartCoroutine(MoveOverSeconds(cube9, new Vector3(0.75f, -1.0f, 2.25f), 2.5f));
        StartCoroutine(waiter());
        StartCoroutine(ButtonCoroutine());
        mainmenu.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

        //videoPlayer.started += OnVideoStarted;
        //videoPlayer.loopPointReached += OnVideoStopped;

        RaycastHit hit;
        
        if (GameObject.Find("AR Camera") != null)
        {
            ray = arCam.ScreenPointToRay(Input.GetTouch(0).position);
        }
        else
        {
            ray = threeDcamera.ScreenPointToRay(Input.GetTouch(0).position);
        }
        //float rotatespeed = 100f;
        //float startingPositionX = 0.0f;
        //float startingPositionY = 0.0f;
        Touch touch = Input.GetTouch(0);
        timerStart = Mathf.Max(0, timerStart - Time.deltaTime);
        TimeSpan timeSpan = TimeSpan.FromSeconds(timerStart);
        //countDownText.text = timeSpan.Minutes.ToString("00") + ":" + timeSpan.Seconds.ToString("00");
        //timeLeft -= Time.deltaTime;
        //string timer = timeLeft.ToString();
        //GameObject countdownTimer = GameObject.Find("CountdownTimerPractice");
        TextMeshPro timerComponent = countdownTimer.GetComponent<TMPro.TextMeshPro>();
        timerComponent.text = timeSpan.Minutes.ToString("00") + ":" + timeSpan.Seconds.ToString("00");

        //GameObject scoreDisplay = GameObject.Find("ScorePractice");
        TextMeshPro scoreComponent = scoreDisplay.GetComponent<TMPro.TextMeshPro>();
        scoreComponent.text = currentScore.ToString();

        GameObject timeScoreDisplay = GameObject.Find("TimeScorePractice");
        TextMeshPro timeScoreComponent = timeScoreDisplay.GetComponent<TMPro.TextMeshPro>();
        currentTimerScore = timerStart / 5;
        currentTimerScore = Math.Round(currentTimerScore, 1);
        timeScoreComponent.text = currentTimerScore.ToString();

        //GameObject dailyScoreDisplay = GameObject.Find("DailyPlayerScore");
        //TextMeshPro dailyScoreComponent = dailyScoreDisplay.GetComponent<TMPro.TextMeshPro>();
        //var dailyPlayerScoreResult = GetPlayerScore();
        //dailyScoreComponent.text = dailyPlayerScoreResult.ToString();

        //wordAnswer = GameObject.Find("Text (TMP)Practice");
        //wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
        //wordAnswerComponent.text = word;

        if (Input.touchCount == 0)
            return;

        //if (Input.GetTouch(0).tapCount == 2)
        //{
        //    if (Input.GetTouch(0).phase == TouchPhase.Began)
        //    {
        //        if (Physics.Raycast(ray, out hit))
        //        {
        //            addLetter(hit.collider.gameObject);
        //        }
        //    }
        //    if (Input.GetTouch(0).phase == TouchPhase.Ended)
        //    {
        //        //lettersCount++;
        //        Debug.Log("Letters Count: " + lettersCount);
        //        spawnedObject = null;
        //    }
        //}

        if (Input.GetTouch(0).tapCount == 2 && lettersCount == 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    addLetter(hit.collider.gameObject);
                }
            }
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                spawnedObject = null;
            }
        }
        else if (Input.GetTouch(0).tapCount == 2 && lettersCount == 1)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.name == "Text (TMP)Practice")
                    {
                        deleteLetter();
                    }
                    else
                    {
                        addLetter(hit.collider.gameObject);
                    }
                }
            }
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                //letter1 = "";
                //lettersCount = 0;
                spawnedObject = null;
            }
        }
        else if (Input.GetTouch(0).tapCount == 2 && lettersCount == 2)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.name == "Text (TMP)Practice")
                    {
                        deleteLetter();
                    }
                    else
                    {
                        addLetter(hit.collider.gameObject);
                    }
                }
            }
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                //letter2 = "";
                //lettersCount = 1;
                spawnedObject = null;
            }
        }
        else if (Input.GetTouch(0).tapCount == 2 && lettersCount == 3)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.name == "Text (TMP)Practice")
                    {
                        deleteLetter();
                    }
                    else
                    {
                        addLetter(hit.collider.gameObject);
                    }
                }
            }
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                //letter3 = "";
                //lettersCount = 2;
                spawnedObject = null;
            }
        }
        else if (Input.GetTouch(0).tapCount == 2 && lettersCount == 4)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.name == "Text (TMP)Practice")
                    {
                        deleteLetter();
                    }
                    else
                    {
                        addLetter(hit.collider.gameObject);
                    }
                }
            }
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                //letter4 = "";
                //lettersCount = 3;
                spawnedObject = null;
            }
        }
        else if (Input.GetTouch(0).tapCount == 2 && lettersCount == 5)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.name == "Text (TMP)Practice")
                    {
                        deleteLetter();
                    }
                    else
                    {
                        addLetter(hit.collider.gameObject);
                    }
                }
            }
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                //letter5 = "";
                //lettersCount = 4;
                spawnedObject = null;
            }
        }
        else if (Input.GetTouch(0).tapCount == 2 && lettersCount == 6)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.name == "Text (TMP)Practice")
                    {
                        deleteLetter();
                    }
                    else
                    {
                        addLetter(hit.collider.gameObject);
                    }
                }
            }
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                //letter6 = "";
                //lettersCount = 5;
                spawnedObject = null;
            }
        }
        else if (Input.GetTouch(0).tapCount == 2 && lettersCount == 7)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.name == "Text (TMP)Practice")
                    {
                        deleteLetter();
                    }
                    else
                    {
                        addLetter(hit.collider.gameObject);
                    }
                }
            }
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                //letter7 = "";
                //lettersCount = 6;
                spawnedObject = null;
            }
        }

        if (Input.touchCount == 1)
        {
            //if (m_RaycastManager.Raycast(Input.GetTouch(0).position, m_Hits))
            //{
            if (Input.GetTouch(0).phase == TouchPhase.Began && spawnedObject == null)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.tag == "SpawnableCube1CubeSide1")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube1");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube1");
                        GameObject child = originalGameObject.transform.GetChild(0).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube1CubeSide2")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube1");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube1");
                        GameObject child = originalGameObject.transform.GetChild(1).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube1CubeSide3")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube1");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube1");
                        GameObject child = originalGameObject.transform.GetChild(2).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube1CubeSide4")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube1");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube1");
                        GameObject child = originalGameObject.transform.GetChild(3).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube1CubeSide5")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube1");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube1");
                        GameObject child = originalGameObject.transform.GetChild(4).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube1CubeSide6")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube1");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube1");
                        GameObject child = originalGameObject.transform.GetChild(5).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube2CubeSide1")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube2");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube2");
                        GameObject child = originalGameObject.transform.GetChild(0).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);

                        //wordAnswer = GameObject.Find("Text (TMP)Practice");
                        ////TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                        //string word1 = textObj1 + " _ _ _ _ _ _";
                        //wordAnswerComponent.text = word1;
                        //Debug.Log("Word: " + textObj1 + " _ _ _ _ _ _");
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube2CubeSide2")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube2");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube2");
                        GameObject child = originalGameObject.transform.GetChild(1).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube2CubeSide3")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube2");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube2");
                        GameObject child = originalGameObject.transform.GetChild(2).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube2CubeSide4")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube2");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube2");
                        GameObject child = originalGameObject.transform.GetChild(3).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube2CubeSide5")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube2");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube2");
                        GameObject child = originalGameObject.transform.GetChild(4).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube2CubeSide6")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube2");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube2");
                        GameObject child = originalGameObject.transform.GetChild(5).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube3CubeSide1")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube3");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube3");
                        GameObject child = originalGameObject.transform.GetChild(0).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube3CubeSide2")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube3");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube3");
                        GameObject child = originalGameObject.transform.GetChild(1).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube3CubeSide3")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube3");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube3");
                        GameObject child = originalGameObject.transform.GetChild(2).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube3CubeSide4")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube3");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube3");
                        GameObject child = originalGameObject.transform.GetChild(3).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube3CubeSide5")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube3");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube3");
                        GameObject child = originalGameObject.transform.GetChild(4).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube3CubeSide6")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube3");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube3");
                        GameObject child = originalGameObject.transform.GetChild(5).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube4CubeSide1")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube4");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube4");
                        GameObject child = originalGameObject.transform.GetChild(0).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube4CubeSide2")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube4");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube4");
                        GameObject child = originalGameObject.transform.GetChild(1).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube4CubeSide3")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube4");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube4");
                        GameObject child = originalGameObject.transform.GetChild(2).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube4CubeSide4")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube4");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube4");
                        GameObject child = originalGameObject.transform.GetChild(3).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube4CubeSide5")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube4");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube4");
                        GameObject child = originalGameObject.transform.GetChild(4).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube4CubeSide6")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube4");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube4");
                        GameObject child = originalGameObject.transform.GetChild(5).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube5CubeSide1")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube5");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube5");
                        GameObject child = originalGameObject.transform.GetChild(0).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube5CubeSide2")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube5");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube5");
                        GameObject child = originalGameObject.transform.GetChild(1).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube5CubeSide3")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube5");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube5");
                        GameObject child = originalGameObject.transform.GetChild(2).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube5CubeSide4")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube5");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube5");
                        GameObject child = originalGameObject.transform.GetChild(3).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube5CubeSide5")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube5");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube5");
                        GameObject child = originalGameObject.transform.GetChild(4).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube5CubeSide6")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube5");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube5");
                        GameObject child = originalGameObject.transform.GetChild(5).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube6CubeSide1")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube6");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube6");
                        GameObject child = originalGameObject.transform.GetChild(0).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube6CubeSide2")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube6");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube6");
                        GameObject child = originalGameObject.transform.GetChild(1).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube6CubeSide3")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube6");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube6");
                        GameObject child = originalGameObject.transform.GetChild(2).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube6CubeSide4")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube6");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube6");
                        GameObject child = originalGameObject.transform.GetChild(3).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube6CubeSide5")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube6");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube6");
                        GameObject child = originalGameObject.transform.GetChild(4).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube6CubeSide6")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube6");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube6");
                        GameObject child = originalGameObject.transform.GetChild(5).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube7CubeSide1")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube7");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube7");
                        GameObject child = originalGameObject.transform.GetChild(0).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube7CubeSide2")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube7");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube7");
                        GameObject child = originalGameObject.transform.GetChild(1).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube7CubeSide3")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube7");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube7");
                        GameObject child = originalGameObject.transform.GetChild(2).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube7CubeSide4")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube7");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube7");
                        GameObject child = originalGameObject.transform.GetChild(3).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube7CubeSide5")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube7");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube7");
                        GameObject child = originalGameObject.transform.GetChild(4).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube7CubeSide6")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube7");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube7");
                        GameObject child = originalGameObject.transform.GetChild(5).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube8CubeSide1")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube8");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube8");
                        GameObject child = originalGameObject.transform.GetChild(0).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube8CubeSide2")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube8");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube8");
                        GameObject child = originalGameObject.transform.GetChild(1).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube8CubeSide3")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube8");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube8");
                        GameObject child = originalGameObject.transform.GetChild(2).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube8CubeSide4")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube8");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube8");
                        GameObject child = originalGameObject.transform.GetChild(3).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube8CubeSide5")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube8");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube8");
                        GameObject child = originalGameObject.transform.GetChild(4).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube8CubeSide6")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube8");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube8");
                        GameObject child = originalGameObject.transform.GetChild(5).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube9CubeSide1")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube9");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube9");
                        GameObject child = originalGameObject.transform.GetChild(0).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube9CubeSide2")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube9");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube9");
                        GameObject child = originalGameObject.transform.GetChild(1).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube9CubeSide3")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube9");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube9");
                        GameObject child = originalGameObject.transform.GetChild(2).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube9CubeSide4")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube9");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube9");
                        GameObject child = originalGameObject.transform.GetChild(3).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube9CubeSide5")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube9");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube9");
                        GameObject child = originalGameObject.transform.GetChild(4).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    else if (hit.collider.gameObject.tag == "SpawnableCube9CubeSide6")
                    {
                        spawnedObject = GameObject.Find("SpawnableCube9");
                        //Touch touch = Input.GetTouch(0);
                        //startingPositionX = touch.position.x;
                        //startingPositionY = touch.position.y;
                        GameObject originalGameObject = GameObject.Find("SpawnableCube9");
                        GameObject child = originalGameObject.transform.GetChild(5).gameObject;
                        GameObject childWithText = child.transform.GetChild(1).gameObject;
                        Text cubeToSelect = childWithText.GetComponent<Text>();
                        string textObj1 = cubeToSelect.text.ToString();
                        Debug.Log("Letter: " + textObj1);
                    }
                    //Touch touch = Input.GetTouch(0);
                    //switch (touch.phase)
                    //{
                    //    case TouchPhase.Began:
                    //        startingPosition = touch.position.x;
                    //        break;
                    //    case TouchPhase.Moved:
                    //        if (startingPosition > touch.position.x)
                    //        {
                    //            spawnedObject2.transform.Rotate(Vector3.back, -rotatespeed * Time.deltaTime);
                    //       }
                    //        else if (startingPosition < touch.position.x)
                    //        {
                    //            spawnedObject2.transform.Rotate(Vector3.back, rotatespeed * Time.deltaTime);
                    //        }
                    //        break;
                    //    case TouchPhase.Ended:
                    //        break;
                    //}
                    //}
                }
            }
            else if (Input.GetTouch(0).phase == TouchPhase.Moved && spawnedObject != null)
            {
                //if (startingPositionX > touch.position.x)
                //{
                spawnedObject.transform.Rotate(touch.deltaPosition.x * Time.deltaTime * 10, touch.deltaPosition.y * Time.deltaTime * 10, 0f, Space.Self);
                //}
                //else if (startingPositionX < touch.position.x)
                //{
                //    spawnedObject.transform.Rotate(-Vector3.forward, rotatespeed * Time.deltaTime);
                //}
                //else if (startingPositionY < touch.position.y)
                //{
                //    spawnedObject.transform.Rotate(Vector3.up, -rotatespeed * Time.deltaTime);
                //}
                //else if (startingPositionY < touch.position.y)
                //{
                //    spawnedObject.transform.Rotate(-Vector3.down, rotatespeed * Time.deltaTime);
                //}
            }
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                spawnedObject = null;
            }
            //}

            //}
        }

        if (Input.touchCount == 1 && lettersCount == 7)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began && spawnedObject == null)
            {
                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject.name == "Text (TMP)Practice")
                    {
                        submitWord(finalWord);
                    }
                }
            }
            if (Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                spawnedObject = null;
            }
        }
    }

    private string addLetter(GameObject hit)
    {
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube1CubeSide1")
        {
            spawnedObject = GameObject.Find("SpawnableCube1");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube1");
            GameObject child = originalGameObject.transform.GetChild(0).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube1CubeSide2")
        {
            spawnedObject = GameObject.Find("SpawnableCube1");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube1");
            GameObject child = originalGameObject.transform.GetChild(1).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube1CubeSide3")
        {
            spawnedObject = GameObject.Find("SpawnableCube1");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube1");
            GameObject child = originalGameObject.transform.GetChild(2).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube1CubeSide4")
        {
            spawnedObject = GameObject.Find("SpawnableCube1");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube1");
            GameObject child = originalGameObject.transform.GetChild(3).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube1CubeSide5")
        {
            spawnedObject = GameObject.Find("SpawnableCube1");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube1");
            GameObject child = originalGameObject.transform.GetChild(4).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube1CubeSide6")
        {
            spawnedObject = GameObject.Find("SpawnableCube1");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube1");
            GameObject child = originalGameObject.transform.GetChild(5).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube2CubeSide1")
        {
            spawnedObject = GameObject.Find("SpawnableCube2");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube2");
            GameObject child = originalGameObject.transform.GetChild(0).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube2CubeSide2")
        {
            spawnedObject = GameObject.Find("SpawnableCube2");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube2");
            GameObject child = originalGameObject.transform.GetChild(1).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube2CubeSide3")
        {
            spawnedObject = GameObject.Find("SpawnableCube2");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube2");
            GameObject child = originalGameObject.transform.GetChild(2).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube2CubeSide4")
        {
            spawnedObject = GameObject.Find("SpawnableCube2");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube2");
            GameObject child = originalGameObject.transform.GetChild(3).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube2CubeSide5")
        {
            spawnedObject = GameObject.Find("SpawnableCube2");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube2");
            GameObject child = originalGameObject.transform.GetChild(4).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube2CubeSide6")
        {
            spawnedObject = GameObject.Find("SpawnableCube2");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube2");
            GameObject child = originalGameObject.transform.GetChild(5).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube3CubeSide1")
        {
            spawnedObject = GameObject.Find("SpawnableCube3");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube3");
            GameObject child = originalGameObject.transform.GetChild(0).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube3CubeSide2")
        {
            spawnedObject = GameObject.Find("SpawnableCube3");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube3");
            GameObject child = originalGameObject.transform.GetChild(1).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube3CubeSide3")
        {
            spawnedObject = GameObject.Find("SpawnableCube3");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube3");
            GameObject child = originalGameObject.transform.GetChild(2).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube3CubeSide4")
        {
            spawnedObject = GameObject.Find("SpawnableCube3");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube3");
            GameObject child = originalGameObject.transform.GetChild(3).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube3CubeSide5")
        {
            spawnedObject = GameObject.Find("SpawnableCube3");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube3");
            GameObject child = originalGameObject.transform.GetChild(4).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube3CubeSide6")
        {
            spawnedObject = GameObject.Find("SpawnableCube3");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube3");
            GameObject child = originalGameObject.transform.GetChild(5).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube4CubeSide1")
        {
            spawnedObject = GameObject.Find("SpawnableCube4");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube4");
            GameObject child = originalGameObject.transform.GetChild(0).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube4CubeSide2")
        {
            spawnedObject = GameObject.Find("SpawnableCube4");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube4");
            GameObject child = originalGameObject.transform.GetChild(1).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube4CubeSide3")
        {
            spawnedObject = GameObject.Find("SpawnableCube4");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube4");
            GameObject child = originalGameObject.transform.GetChild(2).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube4CubeSide4")
        {
            spawnedObject = GameObject.Find("SpawnableCube4");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube4");
            GameObject child = originalGameObject.transform.GetChild(3).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube4CubeSide5")
        {
            spawnedObject = GameObject.Find("SpawnableCube4");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube4");
            GameObject child = originalGameObject.transform.GetChild(4).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube4CubeSide6")
        {
            spawnedObject = GameObject.Find("SpawnableCube4");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube4");
            GameObject child = originalGameObject.transform.GetChild(5).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube5CubeSide1")
        {
            spawnedObject = GameObject.Find("SpawnableCube5");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube5");
            GameObject child = originalGameObject.transform.GetChild(0).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube5CubeSide2")
        {
            spawnedObject = GameObject.Find("SpawnableCube5");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube5");
            GameObject child = originalGameObject.transform.GetChild(1).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube5CubeSide3")
        {
            spawnedObject = GameObject.Find("SpawnableCube5");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube5");
            GameObject child = originalGameObject.transform.GetChild(2).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube5CubeSide4")
        {
            spawnedObject = GameObject.Find("SpawnableCube5");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube5");
            GameObject child = originalGameObject.transform.GetChild(3).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube5CubeSide5")
        {
            spawnedObject = GameObject.Find("SpawnableCube5");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube5");
            GameObject child = originalGameObject.transform.GetChild(4).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube5CubeSide6")
        {
            spawnedObject = GameObject.Find("SpawnableCube5");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube5");
            GameObject child = originalGameObject.transform.GetChild(5).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube6CubeSide1")
        {
            spawnedObject = GameObject.Find("SpawnableCube6");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube6");
            GameObject child = originalGameObject.transform.GetChild(0).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube6CubeSide2")
        {
            spawnedObject = GameObject.Find("SpawnableCube6");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube6");
            GameObject child = originalGameObject.transform.GetChild(1).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube6CubeSide3")
        {
            spawnedObject = GameObject.Find("SpawnableCube6");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube6");
            GameObject child = originalGameObject.transform.GetChild(2).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube6CubeSide4")
        {
            spawnedObject = GameObject.Find("SpawnableCube6");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube6");
            GameObject child = originalGameObject.transform.GetChild(3).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube6CubeSide5")
        {
            spawnedObject = GameObject.Find("SpawnableCube6");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube6");
            GameObject child = originalGameObject.transform.GetChild(4).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube6CubeSide6")
        {
            spawnedObject = GameObject.Find("SpawnableCube6");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube6");
            GameObject child = originalGameObject.transform.GetChild(5).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube7CubeSide1")
        {
            spawnedObject = GameObject.Find("SpawnableCube7");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube7");
            GameObject child = originalGameObject.transform.GetChild(0).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube7CubeSide2")
        {
            spawnedObject = GameObject.Find("SpawnableCube7");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube7");
            GameObject child = originalGameObject.transform.GetChild(1).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube7CubeSide3")
        {
            spawnedObject = GameObject.Find("SpawnableCube7");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube7");
            GameObject child = originalGameObject.transform.GetChild(2).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube7CubeSide4")
        {
            spawnedObject = GameObject.Find("SpawnableCube7");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube7");
            GameObject child = originalGameObject.transform.GetChild(3).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube7CubeSide5")
        {
            spawnedObject = GameObject.Find("SpawnableCube7");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube7");
            GameObject child = originalGameObject.transform.GetChild(4).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube7CubeSide6")
        {
            spawnedObject = GameObject.Find("SpawnableCube7");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube7");
            GameObject child = originalGameObject.transform.GetChild(5).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube8CubeSide1")
        {
            spawnedObject = GameObject.Find("SpawnableCube8");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube8");
            GameObject child = originalGameObject.transform.GetChild(0).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube8CubeSide2")
        {
            spawnedObject = GameObject.Find("SpawnableCube8");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube8");
            GameObject child = originalGameObject.transform.GetChild(1).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube8CubeSide3")
        {
            spawnedObject = GameObject.Find("SpawnableCube8");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube8");
            GameObject child = originalGameObject.transform.GetChild(2).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube8CubeSide4")
        {
            spawnedObject = GameObject.Find("SpawnableCube8");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube8");
            GameObject child = originalGameObject.transform.GetChild(3).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube8CubeSide5")
        {
            spawnedObject = GameObject.Find("SpawnableCube8");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube8");
            GameObject child = originalGameObject.transform.GetChild(4).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube8CubeSide6")
        {
            spawnedObject = GameObject.Find("SpawnableCube8");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube8");
            GameObject child = originalGameObject.transform.GetChild(5).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube9CubeSide1")
        {
            spawnedObject = GameObject.Find("SpawnableCube9");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube9");
            GameObject child = originalGameObject.transform.GetChild(0).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube9CubeSide2")
        {
            spawnedObject = GameObject.Find("SpawnableCube9");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube9");
            GameObject child = originalGameObject.transform.GetChild(1).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube9CubeSide3")
        {
            spawnedObject = GameObject.Find("SpawnableCube9");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube9");
            GameObject child = originalGameObject.transform.GetChild(2).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube9CubeSide4")
        {
            spawnedObject = GameObject.Find("SpawnableCube9");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube9");
            GameObject child = originalGameObject.transform.GetChild(3).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube9CubeSide5")
        {
            spawnedObject = GameObject.Find("SpawnableCube9");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube9");
            GameObject child = originalGameObject.transform.GetChild(4).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        if (hit.GetComponent<Collider>().gameObject.tag == "SpawnableCube9CubeSide6")
        {
            spawnedObject = GameObject.Find("SpawnableCube9");
            //Touch touch = Input.GetTouch(0);
            //startingPositionX = touch.position.x;
            //startingPositionY = touch.position.y;
            GameObject originalGameObject = GameObject.Find("SpawnableCube9");
            GameObject child = originalGameObject.transform.GetChild(5).gameObject;
            GameObject childWithText = child.transform.GetChild(1).gameObject;
            Text cubeToSelect = childWithText.GetComponent<Text>();
            string textObj1 = cubeToSelect.text.ToString();
            Debug.Log("Letter: " + textObj1);
            if (lettersCount == 0)
            {
                letter1 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + " _ _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 1;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 1)
            {
                letter2 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + " _ _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 2;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 2)
            {
                letter3 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + " _ _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 3;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 3)
            {
                letter4 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + " _ _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 4;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 4)
            {
                letter5 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + " _ _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 5;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 5)
            {
                letter6 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + " _";
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 6;
                createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
            else if (lettersCount == 6)
            {
                letter7 = textObj1;
                wordAnswer = GameObject.Find("Text (TMP)Practice");
                //TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
                //word = letter1 + letter2 + letter3 + letter4 + letter5 + letter6 + letter7;
                //wordAnswerComponent.text = word;
                //Debug.Log("Word: " + word);
                lettersCount = 7;
                finalWord = createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
            }
        }
        return word;
    }

    private void submitWord(string finalWord)
    {
        finalWord = finalWord.Replace(" ", "");
        finalWord = finalWord.ToLower();
        Debug.Log(finalWord);

        if (ContainsString(finalWord) == true)
        {
            GameObject wordMatched = GameObject.Find("MatchedPractice");
            TextMeshPro wordMatchedComponent = wordMatched.GetComponent<TMPro.TextMeshPro>();
            string matched = "You did it!";
            wordMatchedComponent.text = matched;
            double timeLeft = timerStart;
            Debug.Log("Time Left: " + timeLeft);
            finalScore = (currentScore * 2) + (timeLeft / 5);
            finalScore = Math.Round(finalScore, 2);
            Debug.Log("Current Score: " + currentScore);
            Debug.Log("Final Score: " + finalScore);
            //StartCoroutine(waiter());
            OnGameFinished();
            //AddScore();
            //SignedOut();
            Debug.Log("Matched");
        }
        else if (!ContainsString(finalWord) == true)
        {
            GameObject wordMatched = GameObject.Find("MatchedPractice");
            TextMeshPro wordMatchedComponent = wordMatched.GetComponent<TMPro.TextMeshPro>();
            string notMatched = "Not a word";
            wordMatchedComponent.text = notMatched;
            Debug.Log("Not Matched");
        }
    }

    private void deleteLetter()
    {
        if (lettersCount == 1)
        {
            wordAnswer = GameObject.Find("Text (TMP)Practice");
            TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
            word = "_ _ _ _ _ _ _";
            wordAnswerComponent.text = word;
            Debug.Log("Word: " + word);
            letter1 = "";
            lettersCount = 0;
            letter1Score = 0;
            currentScore = 0;
        }
        else if (lettersCount == 2)
        {
            wordAnswer = GameObject.Find("Text (TMP)Practice");
            TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
            word = letter1 + " _ _ _ _ _ _";
            wordAnswerComponent.text = word;
            Debug.Log("Word: " + word);
            letter2 = "";
            lettersCount = 1;
            letter2Score = 0;
            createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
        }
        else if (lettersCount == 3)
        {
            wordAnswer = GameObject.Find("Text (TMP)Practice");
            TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
            word = letter1 + " " + letter2 + " _ _ _ _ _";
            wordAnswerComponent.text = word;
            Debug.Log("Word: " + word);
            letter3 = "";
            lettersCount = 2;
            letter3Score = 0;
            createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
        }
        else if (lettersCount == 4)
        {
            wordAnswer = GameObject.Find("Text (TMP)Practice");
            TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
            word = letter1 + " " + letter2 + " " + letter3 + " _ _ _ _";
            wordAnswerComponent.text = word;
            Debug.Log("Word: " + word);
            letter4 = "";
            lettersCount = 3;
            letter4Score = 0;
            createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
        }
        else if (lettersCount == 5)
        {
            wordAnswer = GameObject.Find("Text (TMP)Practice");
            TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
            word = letter1 + " " + letter2 + " " + letter3 + " " + letter4 + " _ _ _";
            wordAnswerComponent.text = word;
            Debug.Log("Word: " + word);
            letter5 = "";
            lettersCount = 4;
            letter5Score = 0;
            createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
        }
        else if (lettersCount == 6)
        {
            wordAnswer = GameObject.Find("Text (TMP)Practice");
            TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
            word = letter1 + " " + letter2 + " " + letter3 + " " + letter4 + " " + letter5 + " _ _";
            wordAnswerComponent.text = word;
            Debug.Log("Word: " + word);
            letter6 = "";
            lettersCount = 5;
            letter6Score = 0;
            createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
        }
        else if (lettersCount == 7)
        {
            wordAnswer = GameObject.Find("Text (TMP)Practice");
            TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
            word = letter1 + " " + letter2 + " " + letter3 + " " + letter4 + " " + letter5 + " " + letter6 + " _";
            wordAnswerComponent.text = word;
            Debug.Log("Word: " + word);
            letter7 = "";
            lettersCount = 6;
            letter7Score = 0;
            createWord(letter1, letter2, letter3, letter4, letter5, letter6, letter7, lettersCount);
        }
    }

    public string createWord(string letter1, string letter2, string letter3, string letter4, string letter5, string letter6, string letter7, int lettersCount)
    {
        if (lettersCount == 0)
        {
            wordAnswer = GameObject.Find("Text (TMP)Practice");
            TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
            word = "_ _ _ _ _ _ _";
            currentScore = 0;
            wordAnswerComponent.text = word;
            Debug.Log("Word: " + word);
        }
        else if (lettersCount == 1)
        {
            wordAnswer = GameObject.Find("Text (TMP)Practice");
            TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
            word = letter1 + " _ _ _ _ _ _";
            wordAnswerComponent.text = word;
            currentScore = calculateScore(letter1.ToLower(), letter2.ToLower(), letter3.ToLower(), letter4.ToLower(), letter5.ToLower(), letter6.ToLower(), letter7.ToLower(), lettersCount);
            Debug.Log("Word: " + word);
        }
        else if (lettersCount == 2)
        {
            wordAnswer = GameObject.Find("Text (TMP)Practice");
            TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
            word = letter1 + " " + letter2 + " _ _ _ _ _";
            wordAnswerComponent.text = word;
            currentScore = calculateScore(letter1.ToLower(), letter2.ToLower(), letter3.ToLower(), letter4.ToLower(), letter5.ToLower(), letter6.ToLower(), letter7.ToLower(), lettersCount);
            Debug.Log("Word: " + word);
        }
        else if (lettersCount == 3)
        {
            wordAnswer = GameObject.Find("Text (TMP)Practice");
            TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
            word = letter1 + " " + letter2 + " " + letter3 + " _ _ _ _";
            wordAnswerComponent.text = word;
            currentScore = calculateScore(letter1.ToLower(), letter2.ToLower(), letter3.ToLower(), letter4.ToLower(), letter5.ToLower(), letter6.ToLower(), letter7.ToLower(), lettersCount);
            Debug.Log("Word: " + word);
        }
        else if (lettersCount == 4)
        {
            wordAnswer = GameObject.Find("Text (TMP)Practice");
            TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
            word = letter1 + " " + letter2 + " " + letter3 + " " + letter4 + " _ _ _";
            wordAnswerComponent.text = word;
            currentScore = calculateScore(letter1.ToLower(), letter2.ToLower(), letter3.ToLower(), letter4.ToLower(), letter5.ToLower(), letter6.ToLower(), letter7.ToLower(), lettersCount);
            Debug.Log("Word: " + word);
        }
        else if (lettersCount == 5)
        {
            wordAnswer = GameObject.Find("Text (TMP)Practice");
            TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
            word = letter1 + " " + letter2 + " " + letter3 + " " + letter4 + " " + letter5 + " _ _";
            wordAnswerComponent.text = word;
            currentScore = calculateScore(letter1.ToLower(), letter2.ToLower(), letter3.ToLower(), letter4.ToLower(), letter5.ToLower(), letter6.ToLower(), letter7.ToLower(), lettersCount);
            Debug.Log("Word: " + word);
        }
        else if (lettersCount == 6)
        {
            wordAnswer = GameObject.Find("Text (TMP)Practice");
            TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
            word = letter1 + " " + letter2 + " " + letter3 + " " + letter4 + " " + letter5 + " " + letter6 + " _";
            wordAnswerComponent.text = word;
            currentScore = calculateScore(letter1.ToLower(), letter2.ToLower(), letter3.ToLower(), letter4.ToLower(), letter5.ToLower(), letter6.ToLower(), letter7.ToLower(), lettersCount);
            Debug.Log("Word: " + word);
        }
        else if (lettersCount == 7)
        {
            wordAnswer = GameObject.Find("Text (TMP)Practice");
            TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
            word = letter1 + " " + letter2 + " " + letter3 + " " + letter4 + " " + letter5 + " " + letter6 + " " + letter7;
            wordAnswerComponent.text = word;
            currentScore = calculateScore(letter1.ToLower(), letter2.ToLower(), letter3.ToLower(), letter4.ToLower(), letter5.ToLower(), letter6.ToLower(), letter7.ToLower(), lettersCount);
            Debug.Log("Word: " + word);
        }
        return word;
    }

    private double calculateScore(string letter1, string letter2, string letter3, string letter4, string letter5, string letter6, string letter7, int lettersCount)
    {
        if (lettersCount == 1)
        {
            if (letter1 == "a" || letter1 == "e" || letter1 == "i" || letter1 == "o" || letter1 == "u" || letter1 == "l" || letter1 == "n" || letter1 == "s" || letter1 == "t" || letter1 == "r")
            {
                letter1Score = 1;
            }
            if (letter1 == "d" || letter1 == "g")
            {
                letter1Score = 2;
            }
            if (letter1 == "b" || letter1 == "c" || letter1 == "m" || letter1 == "p")
            {
                letter1Score = 3;
            }
            if (letter1 == "f" || letter1 == "h" || letter1 == "v" || letter1 == "w" || letter1 == "y")
            {
                letter1Score = 4;
            }
            if (letter1 == "k")
            {
                letter1Score = 5;
            }
            if (letter1 == "j" || letter1 == "x")
            {
                letter1Score = 8;
            }
            if (letter1 == "q" || letter1 == "z")
            {
                letter1Score = 10;
            }
            currentScore = letter1Score;
        }
        else if (lettersCount == 2)
        {
            if (letter2 == "a" || letter2 == "e" || letter2 == "i" || letter2 == "o" || letter2 == "u" || letter2 == "l" || letter2 == "n" || letter2 == "s" || letter2 == "t" || letter2 == "r")
            {
                letter2Score = 1;
            }
            if (letter2 == "d" || letter2 == "g")
            {
                letter2Score = 2;
            }
            if (letter2 == "b" || letter2 == "c" || letter2 == "m" || letter2 == "p")
            {
                letter2Score = 3;
            }
            if (letter2 == "f" || letter2 == "h" || letter2 == "v" || letter2 == "w" || letter2 == "y")
            {
                letter2Score = 4;
            }
            if (letter2 == "k")
            {
                letter2Score = 5;
            }
            if (letter2 == "j" || letter2 == "x")
            {
                letter2Score = 8;
            }
            if (letter2 == "q" || letter2 == "z")
            {
                letter2Score = 10;
            }
            currentScore = letter1Score + letter2Score;
        }
        else if (lettersCount == 3)
        {
            if (letter3 == "a" || letter3 == "e" || letter3 == "i" || letter3 == "o" || letter3 == "u" || letter3 == "l" || letter3 == "n" || letter3 == "s" || letter3 == "t" || letter3 == "r")
            {
                letter3Score = 1;
            }
            if (letter3 == "d" || letter3 == "g")
            {
                letter3Score = 2;
            }
            if (letter3 == "b" || letter3 == "c" || letter3 == "m" || letter3 == "p")
            {
                letter3Score = 3;
            }
            if (letter3 == "f" || letter3 == "h" || letter3 == "v" || letter3 == "w" || letter3 == "y")
            {
                letter3Score = 4;
            }
            if (letter3 == "k")
            {
                letter3Score = 5;
            }
            if (letter3 == "j" || letter3 == "x")
            {
                letter3Score = 8;
            }
            if (letter3 == "q" || letter3 == "z")
            {
                letter3Score = 10;
            }
            currentScore = letter1Score + letter2Score + letter3Score;
        }
        else if (lettersCount == 4)
        {
            if (letter4 == "a" || letter4 == "e" || letter4 == "i" || letter4 == "o" || letter4 == "u" || letter4 == "l" || letter4 == "n" || letter4 == "s" || letter4 == "t" || letter4 == "r")
            {
                letter4Score = 1;
            }
            if (letter4 == "d" || letter4 == "g")
            {
                letter4Score = 2;
            }
            if (letter4 == "b" || letter4 == "c" || letter4 == "m" || letter4 == "p")
            {
                letter4Score = 3;
            }
            if (letter4 == "f" || letter4 == "h" || letter4 == "v" || letter4 == "w" || letter4 == "y")
            {
                letter4Score = 4;
            }
            if (letter4 == "k")
            {
                letter4Score = 5;
            }
            if (letter4 == "j" || letter4 == "x")
            {
                letter4Score = 8;
            }
            if (letter4 == "q" || letter4 == "z")
            {
                letter4Score = 10;
            }
            currentScore = letter1Score + letter2Score + letter3Score + letter4Score;
        }
        else if (lettersCount == 5)
        {
            if (letter5 == "a" || letter5 == "e" || letter5 == "i" || letter5 == "o" || letter5 == "u" || letter5 == "l" || letter5 == "n" || letter5 == "s" || letter5 == "t" || letter5 == "r")
            {
                letter5Score = 1;
            }
            if (letter5 == "d" || letter5 == "g")
            {
                letter5Score = 2;
            }
            if (letter5 == "b" || letter5 == "c" || letter5 == "m" || letter5 == "p")
            {
                letter5Score = 3;
            }
            if (letter5 == "f" || letter5 == "h" || letter5 == "v" || letter5 == "w" || letter5 == "y")
            {
                letter5Score = 4;
            }
            if (letter5 == "k")
            {
                letter5Score = 5;
            }
            if (letter5 == "j" || letter5 == "x")
            {
                letter5Score = 8;
            }
            if (letter5 == "q" || letter5 == "z")
            {
                letter5Score = 10;
            }
            currentScore = letter1Score + letter2Score + letter3Score + letter4Score + letter5Score;
        }
        else if (lettersCount == 6)
        {
            if (letter6 == "a" || letter6 == "e" || letter6 == "i" || letter6 == "o" || letter6 == "u" || letter6 == "l" || letter6 == "n" || letter6 == "s" || letter6 == "t" || letter6 == "r")
            {
                letter6Score = 1;
            }
            if (letter6 == "d" || letter6 == "g")
            {
                letter6Score = 2;
            }
            if (letter6 == "b" || letter6 == "c" || letter6 == "m" || letter6 == "p")
            {
                letter6Score = 3;
            }
            if (letter6 == "f" || letter6 == "h" || letter6 == "v" || letter6 == "w" || letter6 == "y")
            {
                letter6Score = 4;
            }
            if (letter6 == "k")
            {
                letter6Score = 5;
            }
            if (letter6 == "j" || letter6 == "x")
            {
                letter6Score = 8;
            }
            if (letter6 == "q" || letter6 == "z")
            {
                letter6Score = 10;
            }
            currentScore = letter1Score + letter2Score + letter3Score + letter4Score + letter5Score + letter6Score;
        }
        else if (lettersCount == 7)
        {
            if (letter7 == "a" || letter7 == "e" || letter7 == "i" || letter7 == "o" || letter7 == "u" || letter7 == "l" || letter7 == "n" || letter7 == "s" || letter7 == "t" || letter7 == "r")
            {
                letter7Score = 1;
            }
            if (letter7 == "d" || letter7 == "g")
            {
                letter7Score = 2;
            }
            if (letter7 == "b" || letter7 == "c" || letter7 == "m" || letter7 == "p")
            {
                letter7Score = 3;
            }
            if (letter7 == "f" || letter7 == "h" || letter7 == "v" || letter7 == "w" || letter7 == "y")
            {
                letter7Score = 4;
            }
            if (letter7 == "k")
            {
                letter7Score = 5;
            }
            if (letter7 == "j" || letter7 == "x")
            {
                letter7Score = 8;
            }
            if (letter7 == "q" || letter7 == "z")
            {
                letter7Score = 10;
            }
            currentScore = letter1Score + letter2Score + letter3Score + letter4Score + letter5Score + letter6Score + letter7Score;
        }
        return currentScore;
    }

    private void SpawnPrefab(Font cubeSideFont, Vector3 spawnPosition, string stringToRetrieve1, string stringToRetrieve2, string stringToRetrieve3, string stringToRetrieve4, string stringToRetrieve5, string stringToRetrieve6,
        string stringToRetrieve7, string stringToRetrieve8, string stringToRetrieve9, string stringToRetrieve10, string stringToRetrieve11, string stringToRetrieve12,
        string stringToRetrieve13, string stringToRetrieve14, string stringToRetrieve15, string stringToRetrieve16, string stringToRetrieve17, string stringToRetrieve18,
        string stringToRetrieve19, string stringToRetrieve20, string stringToRetrieve21, string stringToRetrieve22, string stringToRetrieve23, string stringToRetrieve24,
        string stringToRetrieve25, string stringToRetrieve26, string stringToRetrieve27, string stringToRetrieve28, string stringToRetrieve29, string stringToRetrieve30,
        string stringToRetrieve31, string stringToRetrieve32, string stringToRetrieve33, string stringToRetrieve34, string stringToRetrieve35, string stringToRetrieve36,
        string stringToRetrieve37, string stringToRetrieve38, string stringToRetrieve39, string stringToRetrieve40, string stringToRetrieve41, string stringToRetrieve42,
        string stringToRetrieve43, string stringToRetrieve44, string stringToRetrieve45, string stringToRetrieve46, string stringToRetrieve47, string stringToRetrieve48,
        string stringToRetrieve49, string stringToRetrieve50, string stringToRetrieve51, string stringToRetrieve52, string stringToRetrieve53, string stringToRetrieve54)
    {

        cube1 = SpawnableCubeManagerPractice.createCube(cubeSideFont, "SpawnableCube1", 40, stringToRetrieve1, stringToRetrieve2, stringToRetrieve3, stringToRetrieve4, stringToRetrieve5, stringToRetrieve6);
        cube1.tag = "Practice1";
        //cube1.AddComponent<BoxCollider>();
        //BoxCollider collider = cube1.transform.gameObject.GetComponent<BoxCollider>();
        //collider.size = new Vector3(40.0f, 40.0f, 40.0f);
        //target1 = GameObject.Find("SpawnableCube1");
        //target1.AddComponent<scriptCube>();
        scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
        cube1.transform.localScale = scaleChange;
        positionChange = new Vector3(-0.75f, 0.75f, 2.0f);

        if (cube1 != null)
        {
            cube1.transform.LookAt(cube1.transform);
            cube1.transform.localScale = scaleChange;
            cube1.transform.position = positionChange;
        }



        cube2 = SpawnableCubeManagerPractice.createCube(cubeSideFont, "SpawnableCube2", 40, stringToRetrieve7, stringToRetrieve8, stringToRetrieve9, stringToRetrieve10, stringToRetrieve11, stringToRetrieve12);
        cube2.tag = "Practice2";
        //cube2.AddComponent<BoxCollider>();
        //collider = cube2.transform.gameObject.GetComponent<BoxCollider>();
        //collider.size = new Vector3(40.0f, 40.0f, 40.0f);
        //target2 = GameObject.Find("SpawnableCube2");
        //target2.AddComponent<scriptCube>();
        scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
        cube2.transform.localScale = scaleChange;
        positionChange = new Vector3(0.0f, 0.75f, 2.0f); ;

        if (cube2 != null)
        {
            cube2.transform.LookAt(cube2.transform);
            cube2.transform.localScale = scaleChange;
            cube2.transform.position = positionChange;
        }

        cube3 = SpawnableCubeManagerPractice.createCube(cubeSideFont, "SpawnableCube3", 40, stringToRetrieve13, stringToRetrieve14, stringToRetrieve15, stringToRetrieve16, stringToRetrieve17, stringToRetrieve18);
        cube3.tag = "Practice3";
        //cube3.AddComponent<BoxCollider>();
        //collider = cube3.transform.gameObject.GetComponent<BoxCollider>();
        //collider.size = new Vector3(40.0f, 40.0f, 40.0f);
        //target2 = GameObject.Find("SpawnableCube3");
        //target2.AddComponent<scriptCube>();
        scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
        cube3.transform.localScale = scaleChange;
        positionChange = new Vector3(0.75f, 0.75f, 2.0f); ;

        if (cube3 != null)
        {
            cube3.transform.LookAt(cube3.transform);
            cube3.transform.localScale = scaleChange;
            cube3.transform.position = positionChange;
        }

        cube4 = SpawnableCubeManagerPractice.createCube(cubeSideFont, "SpawnableCube4", 40, stringToRetrieve19, stringToRetrieve20, stringToRetrieve21, stringToRetrieve22, stringToRetrieve23, stringToRetrieve24);
        cube4.tag = "Practice4";
        //cube4.AddComponent<BoxCollider>();
        //collider = cube4.transform.gameObject.GetComponent<BoxCollider>();
        //collider.size = new Vector3(40.0f, 40.0f, 40.0f);
        //target2 = GameObject.Find("SpawnableCube3");
        //target2.AddComponent<scriptCube>();
        scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
        cube4.transform.localScale = scaleChange;
        positionChange = new Vector3(-0.75f, 0f, 2f); ;

        if (cube4 != null)
        {
            cube4.transform.LookAt(cube4.transform);
            cube4.transform.localScale = scaleChange;
            cube4.transform.position = positionChange;
        }

        cube5 = SpawnableCubeManagerPractice.createCube(cubeSideFont, "SpawnableCube5", 40, stringToRetrieve25, stringToRetrieve26, stringToRetrieve27, stringToRetrieve28, stringToRetrieve29, stringToRetrieve30);
        cube5.tag = "Practice5";
        //cube5.AddComponent<BoxCollider>();
        //collider = cube5.transform.gameObject.GetComponent<BoxCollider>();
        //collider.size = new Vector3(40.0f, 40.0f, 40.0f);
        //target2 = GameObject.Find("SpawnableCube3");
        //target2.AddComponent<scriptCube>();
        scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
        cube5.transform.localScale = scaleChange;
        positionChange = new Vector3(0.0f, 0f, 2f); ;

        if (cube5 != null)
        {
            cube5.transform.LookAt(cube5.transform);
            cube5.transform.localScale = scaleChange;
            cube5.transform.position = positionChange;
        }

        cube6 = SpawnableCubeManagerPractice.createCube(cubeSideFont, "SpawnableCube6", 40, stringToRetrieve31, stringToRetrieve32, stringToRetrieve33, stringToRetrieve34, stringToRetrieve35, stringToRetrieve36);
        cube6.tag = "Practice6";
        //cube6.AddComponent<BoxCollider>();
        //collider = cube6.transform.gameObject.GetComponent<BoxCollider>();
        //collider.size = new Vector3(40.0f, 40.0f, 40.0f);
        //target2 = GameObject.Find("SpawnableCube3");
        //target2.AddComponent<scriptCube>();
        scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
        cube6.transform.localScale = scaleChange;
        positionChange = new Vector3(0.75f, 0f, 2f); ;

        if (cube6 != null)
        {
            cube6.transform.LookAt(cube6.transform);
            cube6.transform.localScale = scaleChange;
            cube6.transform.position = positionChange;
        }

        cube7 = SpawnableCubeManagerPractice.createCube(cubeSideFont, "SpawnableCube7", 40, stringToRetrieve37, stringToRetrieve38, stringToRetrieve39, stringToRetrieve40, stringToRetrieve41, stringToRetrieve42);
        cube7.tag = "Practice7";
        //cube7.AddComponent<BoxCollider>();
        //collider = cube7.transform.gameObject.GetComponent<BoxCollider>();
        //collider.size = new Vector3(40.0f, 40.0f, 40.0f);
        //target2 = GameObject.Find("SpawnableCube3");
        //target2.AddComponent<scriptCube>();
        scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
        cube7.transform.localScale = scaleChange;
        positionChange = new Vector3(-0.75f, -0.75f, 2f); ;

        if (cube7 != null)
        {
            cube7.transform.LookAt(cube7.transform);
            cube7.transform.localScale = scaleChange;
            cube7.transform.position = positionChange;
        }

        cube8 = SpawnableCubeManagerPractice.createCube(cubeSideFont, "SpawnableCube8", 40, stringToRetrieve43, stringToRetrieve44, stringToRetrieve45, stringToRetrieve46, stringToRetrieve47, stringToRetrieve48);
        cube8.tag = "Practice8";
        //cube8.AddComponent<BoxCollider>();
        //collider = cube8.transform.gameObject.GetComponent<BoxCollider>();
        //collider.size = new Vector3(40.0f, 40.0f, 40.0f);
        //target2 = GameObject.Find("SpawnableCube3");
        //target2.AddComponent<scriptCube>();
        scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
        cube8.transform.localScale = scaleChange;
        positionChange = new Vector3(0.0f, -0.75f, 2f); ;

        if (cube8 != null)
        {
            cube8.transform.LookAt(cube8.transform);
            cube8.transform.localScale = scaleChange;
            cube8.transform.position = positionChange;
        }

        cube9 = SpawnableCubeManagerPractice.createCube(cubeSideFont, "SpawnableCube9", 40, stringToRetrieve49, stringToRetrieve50, stringToRetrieve51, stringToRetrieve52, stringToRetrieve53, stringToRetrieve54);
        cube9.tag = "Practice9";
        //cube9.AddComponent<BoxCollider>();
        //collider = cube9.transform.gameObject.GetComponent<BoxCollider>();
        //collider.size = new Vector3(40.0f, 40.0f, 40.0f);
        //target2 = GameObject.Find("SpawnableCube3");
        //target2.AddComponent<scriptCube>();
        scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
        cube9.transform.localScale = scaleChange;
        positionChange = new Vector3(0.75f, -0.75f, 2f); ;

        if (cube9 != null)
        {
            cube9.transform.LookAt(cube9.transform);
            cube9.transform.localScale = scaleChange;
            cube9.transform.position = positionChange;
        }

        //spawnedObject1 = Instantiate(cube1, spawnPosition, Quaternion.identity);
        //spawnedObject2 = Instantiate(cube2, spawnPosition, Quaternion.identity);
    }

    public static GameObject createCube(Font cubeSideFont, string name, int size, string stringToRetrieve1, string stringToRetrieve2, string stringToRetrieve3, string stringToRetrieve4, string stringToRetrieve5, string stringToRetrieve6)
    {
        GameObject mainObj = new GameObject();

        mainObj.name = name;

        string cubeside1 = name + "CubeSide1";
        GameObject side1 = addSide(cubeSideFont, cubeside1, size, stringToRetrieve1);
        side1.transform.SetParent(mainObj.transform);
        side1.transform.position = new Vector3(0, 0, -size / 2);
        side1.transform.rotation = Quaternion.Euler(0, 0, 0);

        string cubeside2 = name + "CubeSide2";
        GameObject side2 = addSide(cubeSideFont, cubeside2, size, stringToRetrieve2);
        side2.transform.SetParent(mainObj.transform);
        side2.transform.position = new Vector3(0, 0, size / 2);
        side2.transform.rotation = Quaternion.Euler(0, 180, 0);

        string cubeside3 = name + "CubeSide3";
        GameObject side3 = addSide(cubeSideFont, cubeside3, size, stringToRetrieve3);
        side3.transform.SetParent(mainObj.transform);
        side3.transform.position = new Vector3(0, -size / 2, 0);
        side3.transform.rotation = Quaternion.Euler(270, 0, 0);

        string cubeside4 = name + "CubeSide4";
        GameObject side4 = addSide(cubeSideFont, cubeside4, size, stringToRetrieve4);
        side4.transform.SetParent(mainObj.transform);
        side4.transform.position = new Vector3(0, size / 2, 0);
        side4.transform.rotation = Quaternion.Euler(90, 0, 0);

        string cubeside5 = name + "CubeSide5";
        GameObject side5 = addSide(cubeSideFont, cubeside5, size, stringToRetrieve5);
        side5.transform.SetParent(mainObj.transform);
        side5.transform.position = new Vector3(-size / 2, 0, 0);
        side5.transform.rotation = Quaternion.Euler(0, 90, 0);

        string cubeside6 = name + "CubeSide6";
        GameObject side6 = addSide(cubeSideFont, cubeside6, size, stringToRetrieve6);
        side6.transform.SetParent(mainObj.transform);
        side6.transform.position = new Vector3(size / 2, 0, 0);
        side6.transform.rotation = Quaternion.Euler(0, 270, 0);

        // mainObj.transform.rotation = Quaternion.Euler(45, 45, 45);

        return mainObj;
    }

    static GameObject addSide(Font cubeSideFont, string name, int size, string text)
    {
        GameObject mainObj = new GameObject();
        Canvas canvasObj = mainObj.AddComponent<Canvas>();
        canvasObj.renderMode = RenderMode.WorldSpace;

        GameObject childObj2 = new GameObject();
        RawImage rawimageObj = childObj2.AddComponent<RawImage>();
        rawimageObj.rectTransform.SetSizeWithCurrentAnchors
             (RectTransform.Axis.Horizontal, size);
        rawimageObj.rectTransform.SetSizeWithCurrentAnchors
             (RectTransform.Axis.Vertical, size);
        rawimageObj.color = Color.white;
        childObj2.transform.SetParent(mainObj.transform, false);

        GameObject childObj1 = new GameObject();
        childObj1.tag = name;
        childObj1.AddComponent<BoxCollider>();
        BoxCollider collider = childObj1.transform.gameObject.GetComponent<BoxCollider>();
        collider.size = new Vector3(40.0f, 40.0f, 40.0f);
        Text textObj = childObj1.AddComponent<Text>();
        //TextMeshPro textObj = childObj1.AddComponent<TMPro.TextMeshPro>();
        textObj.font = cubeSideFont; // (Font)Resources.GetBuiltinResource(typeof(Font), "Electronic Highway Sign.ttf"); 
        textObj.text = text;
        textObj.alignment = TextAnchor.MiddleCenter;
        textObj.enabled = true;
        //textObj.sortingOrder = 1;
        textObj.fontSize = 32; // (int)(size * 0.8);
        textObj.fontStyle = FontStyle.Bold;
        textObj.color = Color.black;
        TextGenerationSettings settings = textObj.GetGenerationSettings(textObj.rectTransform.rect.size);
        //settings.resizeTextForBestFit = true;
        textObj.alignByGeometry = true;
        textObj.supportRichText = true;
        textObj.rectTransform.SetSizeWithCurrentAnchors
            (RectTransform.Axis.Horizontal, size);
        textObj.rectTransform.SetSizeWithCurrentAnchors
            (RectTransform.Axis.Vertical, size);
        childObj1.transform.SetParent(mainObj.transform, false);

        return mainObj;
    }

    public string GetRandomItemArray(string[] arrayToRandomize)
    {
        int randomNum = Random.Range(0, arrayToRandomize.Length);
        string printRandom = arrayToRandomize[randomNum];
        return printRandom;
    }

    public bool ContainsString(string s)
    {
        return arr.Contains(s);
    }

    public IEnumerator MoveOverSeconds(GameObject objectToMove, Vector3 end, float seconds)
    {
        float elapsedTime = 0;
        Vector3 startingPos = objectToMove.transform.position;
        while (elapsedTime < seconds)
        {
            objectToMove.transform.position = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        objectToMove.transform.position = end;
    }

    IEnumerator ButtonCoroutine()
    {
        yield return new WaitForSeconds(2.5f);
        
        //Button threeDeebutton = threeDbutton.GetComponent<Button>();
        threeDbutton.interactable = true;
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(0.5f);
    }

    public async void AddScore()
    {
        var playerEntry = await LeaderboardsService.Instance.AddPlayerScoreAsync(LeaderboardId, currentScore);

        //Debug.Log(JsonConvert.SerializeObject(playerEntry));
    }


    private void OnGameFinished()
    {
        //mainmenu.gameObject.SetActive(true);
        scorespanel = FindInActiveObjectByName("ScoresPanelPractice");
        scorespanel.SetActive(true);
        success = Caching.ClearCache();
        Debug.Log("Cache cleared: " + success);
        
        GameObject scoreDisplay = GameObject.Find("ScorePractice");
        TextMeshPro scoreComponent = scoreDisplay.GetComponent<TMPro.TextMeshPro>();
        scoreComponent.text = currentScore.ToString();

        GameObject timeScoreDisplay = GameObject.Find("TimeScorePractice");
        TextMeshPro timeScoreComponent = timeScoreDisplay.GetComponent<TMPro.TextMeshPro>();
        currentTimerScore = timerStart / 5;
        currentTimerScore = Math.Round(currentTimerScore, 1);
        timeScoreComponent.text = currentTimerScore.ToString();

        GameObject timeScoreResult = GameObject.Find("TimeScoreResultPractice");
        TextMeshProUGUI timeScoreResultComponent = timeScoreResult.GetComponent<TMPro.TextMeshProUGUI>();
        timeScoreResultComponent.text = currentTimerScore.ToString();

        GameObject wordScoreResult = GameObject.Find("WordScoreResultPractice");
        TextMeshProUGUI wordScoreResultComponent = wordScoreResult.GetComponent<TMPro.TextMeshProUGUI>();
        wordScoreResultComponent.text = (currentScore * 2).ToString();

        GameObject finalScoreResult = GameObject.Find("FinalScoreResultPractice");
        TextMeshProUGUI finalScoreResultComponent = finalScoreResult.GetComponent<TMPro.TextMeshProUGUI>();
        finalScoreResultComponent.text = finalScore.ToString();

        //AuthenticationService.Instance.SignOut(false);
        //textTMP.gameObject.SetActive(false);
        //countdownTimer.gameObject.SetActive(false);
        //score.gameObject.SetActive(false);
        //matched.gameObject.SetActive(false);
    }

    GameObject FindInActiveObjectByName(string name)
    {
        Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
        for (int i = 0; i < objs.Length; i++)
        {
            if (objs[i].hideFlags == HideFlags.None)
            {
                if (objs[i].name == name)
                {
                    return objs[i].gameObject;
                }
            }
        }
        return null;
    }

    public async void ResetPractice()
    {
        GameObject cube11 = GameObject.FindWithTag("Practice1");
        Destroy(cube11);
        GameObject cube21 = GameObject.FindWithTag("Practice2");
        Destroy(cube21);
        GameObject cube31 = GameObject.FindWithTag("Practice3");
        Destroy(cube31);
        GameObject cube41 = GameObject.FindWithTag("Practice4");
        Destroy(cube41);
        GameObject cube51 = GameObject.FindWithTag("Practice5");
        Destroy(cube51);
        GameObject cube61 = GameObject.FindWithTag("Practice6");
        Destroy(cube61);
        GameObject cube71 = GameObject.FindWithTag("Practice7");
        Destroy(cube71);
        GameObject cube81 = GameObject.FindWithTag("Practice8");
        Destroy(cube81);
        GameObject cube91 = GameObject.FindWithTag("Practice9");
        Destroy(cube91);
        letter1 = "";
        letter2 = "";
        letter3 = "";
        letter4 = "";
        letter5 = "";
        letter6 = "";
        letter7 = "";
        lettersCount = 0;
        currentScore = 0;
        word = "_ _ _ _ _ _ _";
        //matched = null;
        timerStart = 120;
        currentTimerScore = timerStart / 5;
        currentTimerScore = Math.Round(currentTimerScore, 1);
        string resetDone = "Reset";
        TimeSpan timeSpan = TimeSpan.FromSeconds(timerStart);
        //countDownText.text = timeSpan.Minutes.ToString("00") + ":" + timeSpan.Seconds.ToString("00");
        //timeLeft -= Time.deltaTime;
        //string timer = timeLeft.ToString();
        GameObject countdownTimer = GameObject.Find("CountdownTimerPractice");
        TextMeshPro timerComponent = countdownTimer.GetComponent<TMPro.TextMeshPro>();
        timerComponent.text = timeSpan.Minutes.ToString("00") + ":" + timeSpan.Seconds.ToString("00");

        GameObject scoreDisplay = GameObject.Find("ScorePractice");
        TextMeshPro scoreComponent = scoreDisplay.GetComponent<TMPro.TextMeshPro>();
        scoreComponent.text = currentScore.ToString();

        GameObject scoreTimerDisplay = GameObject.Find("TimeScorePractice");
        TextMeshPro scoreTimerComponent = scoreTimerDisplay.GetComponent<TMPro.TextMeshPro>();
        scoreTimerComponent.text = currentTimerScore.ToString();

        wordAnswer = GameObject.Find("Text (TMP)Practice");
        TextMeshPro wordAnswerComponent = wordAnswer.GetComponent<TMPro.TextMeshPro>();
        wordAnswerComponent.text = word;

        wordMatched = GameObject.Find("MatchedPractice");
        TextMeshPro wordMatchedComponent = wordMatched.GetComponent<TMPro.TextMeshPro>();
        string matched = "";
        wordMatchedComponent.text = matched;

        scorespanel.gameObject.SetActive(false);
    }

    private void SignedOut()
    {
        try
        {
            AuthenticationService.Instance.SignOut();
            signedIn = AuthenticationService.Instance.IsSignedIn;
            Debug.Log("Signed In: " + signedIn);
        }
        catch (Exception e)
        {
            Debug.LogException(e);
        }
    }
}

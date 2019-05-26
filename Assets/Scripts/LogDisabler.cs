using UnityEngine;
using System.Collections;

public class LogDisabler : MonoBehaviour
{
    private static ILogger logger = Debug.unityLogger;
    private static string kTAG = "MyGameTag";

    void Start()
    {
        logger.logEnabled = Debug.isDebugBuild;

        logger.Log(kTAG, "This log will be displayed only in debug build");
    }
}
using System;
using Unity.Netcode;
using UnityEngine;

public class CommandLineController : MonoBehaviour
{
    #region MEMBERS

    private const string windowModeArg = "isWindowedMode=";
    private const string resolutionWidthArg = "width=";
    private const string resolutionHeightArg = "height=";
    private const string server = "server=";
    private const string client = "client=";

    [SerializeField]
    private int defaultWidth = 640;
    [SerializeField]
    private int defaultHeight = 480;

    #endregion

    #region PROPERTIES

    public int DefaultHeight
    {
        get { return defaultHeight; }
    }

    public int DefaultWidth
    {
        get { return defaultWidth; }
    }

    #endregion

    #region FUNCTIONS

    void Start()
    {
        ParseCommandLineArguments();
    }

    private void ParseCommandLineArguments()
    {
        string[] args = System.Environment.GetCommandLineArgs();

        int screenWidth = DefaultWidth;
        int screenHeight = DefaultHeight;
        bool isWindowsMode = true;
        string argumentString;
        bool isServer = false;
        bool isClient = false;
        for (int i = 0; i < args.Length; i++)
        {
            argumentString = "";
            if (args[i].StartsWith(windowModeArg) == true)
            {
                argumentString = args[i].Replace(windowModeArg, "");
                Boolean.TryParse(argumentString, out isWindowsMode);
            }
            else if (args[i].StartsWith(resolutionWidthArg) == true)
            {
                argumentString = args[i].Replace(resolutionWidthArg, "");
                Int32.TryParse(argumentString, out screenWidth);
            }
            else if (args[i].StartsWith(resolutionHeightArg) == true)
            {
                argumentString = args[i].Replace(resolutionHeightArg, "");
                Int32.TryParse(argumentString, out screenHeight);
            }
            else if (args[i].StartsWith(server) == true)
            {
                argumentString = args[i].Replace(server, "");
                Boolean.TryParse(argumentString, out isServer);
            }
            else if (args[i].StartsWith(client) == true)
            {
                argumentString = args[i].Replace(client, "");
                Boolean.TryParse(argumentString, out isClient);
            }
        }
        if (isServer)
        {
            NetworkManager.Singleton.StartServer();
        }
        else if(isClient)
        {
            NetworkManager.Singleton.StartClient();
        }
        
        Screen.SetResolution(screenWidth, screenHeight, isWindowsMode == false);
    }

    #endregion

    #region CLASS_ENUMS

    #endregion
}
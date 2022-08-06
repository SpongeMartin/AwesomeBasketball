using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveHandler : MonoBehaviour
{

    // persistentDataPath -> directory path where you can store data that you want to be kept between runs
    // iOS and Android, persistentDataPath points to a public directory on the device 
    private static string path = Application.persistentDataPath + "/maxscore.abd";

    public static void sh_SaveMaxScore (int a_maxScore) {
        Debug.Log("Saving game data . . . ");

        BinaryFormatter _formatter = new BinaryFormatter();

        // provedes a stream for a file { read, write operations }
        // path -> string reference to the file location
        // FileMode -> Specifies how the operating system should open a file
        FileStream _stream = new FileStream(path, FileMode.Create);

        GameData _data = new GameData(a_maxScore);
        _formatter.Serialize(_stream, _data);
        _stream.Close();
    }

    public static int sh_LoadMaxScore () {
        if(!File.Exists(path)) {
            Debug.LogError("No max score data found in " + path);
            return 0;
        } 
    
        BinaryFormatter _formatter = new BinaryFormatter();

        // provedes a stream for a file { read, write operations }
        // path -> string reference to the file location
        // FileMode -> Specifies how the operating system should open a file
        FileStream _stream = new FileStream(path, FileMode.Open);

        GameData data = (GameData)_formatter.Deserialize(_stream);
        _stream.Close();
        return data.maxScore;
    }

}

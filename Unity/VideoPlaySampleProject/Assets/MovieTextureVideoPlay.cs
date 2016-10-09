using UnityEngine;
using System.Collections;

public class MovieTextureVideoPlay : MonoBehaviour
{
    private string url;
    private MovieTexture movieTexture;
    private WWW www;

    void Start()
    {
        //本地视频
        //url = "file:///C:/Users/usuny/Documents/Github/MyProjects/Unity/VideoPlaySampleProject/sample.mp4"; // cannot play
        url = "file:///C:/Users/usuny/Documents/Github/MyProjects/Unity/VideoPlaySampleProject/small.ogv";
        StartCoroutine(DownLoadMovie());
    }

    private IEnumerator DownLoadMovie()
    {
        www = new WWW(url);
        while (!www.isDone)
        {
            yield return null;
        }
        movieTexture = www.movie;
        GetComponent<Renderer>().material.mainTexture = movieTexture;
        movieTexture.loop = true;
        yield return www;
    }

    void Update()
    {
        if (movieTexture == null) return;
        Debug.Log("movieTexture.isReadyToPlay" + ": " + movieTexture.isReadyToPlay);
        Debug.Log("www.isDone" + ": " + www.isDone);
        Debug.Log("movieTexture.duration" + ": " + movieTexture.duration);
        Debug.Log("movieTexture.isPlaying" + ": " + movieTexture.isPlaying);

        //if (!movieTexture.isPlaying && movieTexture.isReadyToPlay)
        //    movieTexture.Play();
    }

    void OnGUI()
    {
        if (GUILayout.Button("播放/继续"))
        {
            //播放/继续播放视频    
            if (!movieTexture.isPlaying)
            {
                movieTexture.Play();
            }
        }

        if (GUILayout.Button("暂停播放"))
        {
            //暂停播放    
            movieTexture.Pause();
        }

        if (GUILayout.Button("停止播放"))
        {
            //停止播放    
            movieTexture.Stop();
        }
    }
}
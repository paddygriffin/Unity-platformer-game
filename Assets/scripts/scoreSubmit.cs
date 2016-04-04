using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreSubmit : MonoBehaviour {

	public static int score;
	
	private string secretKey = "secretKey"; // Edit this value and make sure it's the same as the one stored on the server
	public string addScoreURL = "http://paddygriffin.cloudapp.net/addscore.php?"; //be sure to add a ? to your url
	public string name = "";
	
	public InputField Field;
	public Button Submit;

	void Start()
	{
		score = PlayerPrefs.GetInt ("CurrentScore", score);
		// Use this for initialization

	}

	public void SubmitScore()
	{
		StartCoroutine(PostScores("PAddy", 12345));
		Field.gameObject.SetActive(false);
		Submit.gameObject.SetActive(false);
		Application.LoadLevel("menu");
	}
	
	public void SubmitButton()
	{
		name = Field.text;
		SubmitScore();
	}
	
	public string Md5Sum(string strToEncrypt)
	{
		System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
		byte[] bytes = ue.GetBytes(strToEncrypt);
		
		// encrypt bytes
		System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
		byte[] hashBytes = md5.ComputeHash(bytes);
		
		// Convert the encrypted bytes back to a string (base 16)
		string hashString = "";
		
		for (int i = 0; i < hashBytes.Length; i++)
		{
			hashString += System.Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
		}
		
		return hashString.PadLeft(32, '0');
	}
	
	IEnumerator PostScores(string name, int score)
	{
		//This connects to a server side php script that will add the name and score to a MySQL DB.
		// Supply it with a string representing the players name and the players score.
		string hash = Md5Sum(name + score + secretKey);
		
		string post_url = addScoreURL + "name=" + WWW.EscapeURL(name) + "&score=" + score + "&hash=" + hash;
		
		// Post the URL to the site and create a download object to get the result.
		WWW hs_post = new WWW(post_url);
		yield return hs_post; // Wait until the download is done
		
		if (hs_post.error != null)
		{
			print("There was an error posting the high score: " + hs_post.error);
		}
	}
}
using UnityEngine;

public class CGoogleAnalytics : MonoBehaviour
{
	public string appname;
	public string profileId;
	public string appversion = "1.1.5";
	public bool autoConnect = true;
	private GoogleAnalyticsForApps m_ga;
	
	public static CGoogleAnalytics instance;
	
	public GoogleAnalyticsForApps analytics {
		get { 
			if (m_ga == null && autoConnect)
				Connect ();
			
			return m_ga;
		}
	}
	
	void Awake()
	{
		if(instance)
			DestroyImmediate(gameObject);
		else
		{
			DontDestroyOnLoad(gameObject);
			instance = this;
		}
	}
	
	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	
	public void Connect ()
	{
		if (m_ga == null)
			m_ga = new GoogleAnalyticsForApps (profileId, appname, appversion, this);
	}
}


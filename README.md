unity3d-google-analytics
========================

Simple scripts to be able to use tracking via google analytics app profiles.

This class uses the new "Measurement Protocol" (see https://developers.google.com/analytics/devguides/collection/protocol/v1/devguide)

The library is platform independant and works for webplayer,IOS,Android and Blackberry 10.


How to use?
============

1. Add CGoogleAnalytics.cs to a GameObject that will not be deleted.
2. Setup the public variables Appname, Profile Id and Appversion in the editor.
3. Call any method of CGoogleAnalyticsForApps using CGoogleAnalytics.instance.METHOD(), some of the methods are:

    -TrackSession(bool _start)
    
    -TrackAppview(string _contentDescription)
    
    -TrackEvent(string _category,string _label,string _action, int _value)


Example
=======

    // session starts
	  CGoogleAnalytics.instance.analytics.TrackSession(true);
	  
    // tracking screens
	  CGoogleAnalytics.instance.analytics.TrackAppview("SampleScreen");
	  
    // track some event
    CGoogleAnalytics.instance.analytics.TrackEvent("eventCategory","eventLabel","eventAction",1234);
    
    // session ends
    CGoogleAnalytics.instance.analytics.TrackSession(false);



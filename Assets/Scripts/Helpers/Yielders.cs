using UnityEngine;
using System.Collections.Generic;

public static class Yielders
{

    static Dictionary<float, WaitForSeconds> _timeInterval = new Dictionary<float, WaitForSeconds>(100);
    static Dictionary<float, WaitForSecondsRealtime> _timeIntervalRealtime = new Dictionary<float, WaitForSecondsRealtime>(100);

    static WaitForEndOfFrame _endOfFrame = new WaitForEndOfFrame();
    public static WaitForEndOfFrame EndOfFrame
    {
        get { return _endOfFrame; }
    }

    static WaitForFixedUpdate _fixedUpdate = new WaitForFixedUpdate();
    public static WaitForFixedUpdate FixedUpdate
    {
        get { return _fixedUpdate; }
    }

    public static WaitForSeconds Get(float seconds)
    {
        if (!_timeInterval.ContainsKey(seconds))
            _timeInterval.Add(seconds, new WaitForSeconds(seconds));
        return _timeInterval[seconds];
    }
    
    public static WaitForSecondsRealtime GetRealtime(float seconds)
    {
        if (!_timeIntervalRealtime.ContainsKey(seconds))
            _timeIntervalRealtime.Add(seconds, new WaitForSecondsRealtime(seconds));
        return _timeIntervalRealtime[seconds];
    }
}


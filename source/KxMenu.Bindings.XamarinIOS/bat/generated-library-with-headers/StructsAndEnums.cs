using System;
using ObjCRuntime;

[Native]
public enum BCOVProgressPolicyCuePointsToProcess : nint
{
	AllCuePoints,
	FinalCuePoint,
	FirstCuePoint
}

[Native]
public enum BCOVProgressPolicyResumePosition : nint
{
	ContentPlayhead,
	LastProcessedCuePoint
}

[Native]
public enum BCOVPlaybackServiceErrorCode : nint
{
	ConnectionError,
	JSONDeserializationError,
	APIError
}

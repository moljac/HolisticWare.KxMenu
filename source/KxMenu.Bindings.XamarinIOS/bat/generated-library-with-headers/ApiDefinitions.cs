using System;
using Foundation;
using UIKit;

// typedef BCOVSource * (^BCOVBasicSessionProviderSourceSelectionPolicy)(BCOVVideo *);
delegate BCOVSource BCOVBasicSessionProviderSourceSelectionPolicy (BCOVVideo arg0);

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern NSString *const kBCOVCatalogJSONKeyAccountId;
	[Field ("kBCOVCatalogJSONKeyAccountId", "__Internal")]
	NSString kBCOVCatalogJSONKeyAccountId { get; }

	// extern NSString *const kBCOVCatalogJSONKeyCuePoints;
	[Field ("kBCOVCatalogJSONKeyCuePoints", "__Internal")]
	NSString kBCOVCatalogJSONKeyCuePoints { get; }

	// extern NSString *const kBCOVCatalogJSONKeyCustomFields;
	[Field ("kBCOVCatalogJSONKeyCustomFields", "__Internal")]
	NSString kBCOVCatalogJSONKeyCustomFields { get; }

	// extern NSString *const kBCOVCatalogJSONKeyDuration;
	[Field ("kBCOVCatalogJSONKeyDuration", "__Internal")]
	NSString kBCOVCatalogJSONKeyDuration { get; }

	// extern NSString *const kBCOVCatalogJSONKeyFLVFullLength;
	[Field ("kBCOVCatalogJSONKeyFLVFullLength", "__Internal")]
	NSString kBCOVCatalogJSONKeyFLVFullLength { get; }

	// extern NSString *const kBCOVCatalogJSONKeyFLVUrl;
	[Field ("kBCOVCatalogJSONKeyFLVUrl", "__Internal")]
	NSString kBCOVCatalogJSONKeyFLVUrl { get; }

	// extern NSString *const kBCOVCatalogJSONKeyHLSUrl;
	[Field ("kBCOVCatalogJSONKeyHLSUrl", "__Internal")]
	NSString kBCOVCatalogJSONKeyHLSUrl { get; }

	// extern NSString *const kBCOVCatalogJSONKeyId;
	[Field ("kBCOVCatalogJSONKeyId", "__Internal")]
	NSString kBCOVCatalogJSONKeyId { get; }

	// extern NSString *const kBCOVCatalogJSONKeyMetaData;
	[Field ("kBCOVCatalogJSONKeyMetaData", "__Internal")]
	NSString kBCOVCatalogJSONKeyMetaData { get; }

	// extern NSString *const kBCOVCatalogJSONKeyName;
	[Field ("kBCOVCatalogJSONKeyName", "__Internal")]
	NSString kBCOVCatalogJSONKeyName { get; }

	// extern NSString *const kBCOVCatalogJSONKeyPlaylistThumbnailURL;
	[Field ("kBCOVCatalogJSONKeyPlaylistThumbnailURL", "__Internal")]
	NSString kBCOVCatalogJSONKeyPlaylistThumbnailURL { get; }

	// extern NSString *const kBCOVCatalogJSONKeyReferenceId;
	[Field ("kBCOVCatalogJSONKeyReferenceId", "__Internal")]
	NSString kBCOVCatalogJSONKeyReferenceId { get; }

	// extern NSString *const kBCOVCatalogJSONKeyRenditions;
	[Field ("kBCOVCatalogJSONKeyRenditions", "__Internal")]
	NSString kBCOVCatalogJSONKeyRenditions { get; }

	// extern NSString *const kBCOVCatalogJSONKeyRenditionContainer;
	[Field ("kBCOVCatalogJSONKeyRenditionContainer", "__Internal")]
	NSString kBCOVCatalogJSONKeyRenditionContainer { get; }

	// extern NSString *const kBCOVCatalogJSONKeyRenditionURL;
	[Field ("kBCOVCatalogJSONKeyRenditionURL", "__Internal")]
	NSString kBCOVCatalogJSONKeyRenditionURL { get; }

	// extern NSString *const kBCOVCatalogJSONKeyRenditionRemoteURL;
	[Field ("kBCOVCatalogJSONKeyRenditionRemoteURL", "__Internal")]
	NSString kBCOVCatalogJSONKeyRenditionRemoteURL { get; }

	// extern NSString *const kBCOVCatalogJSONKeyShortDescription;
	[Field ("kBCOVCatalogJSONKeyShortDescription", "__Internal")]
	NSString kBCOVCatalogJSONKeyShortDescription { get; }

	// extern NSString *const kBCOVCatalogJSONKeyTime;
	[Field ("kBCOVCatalogJSONKeyTime", "__Internal")]
	NSString kBCOVCatalogJSONKeyTime { get; }

	// extern NSString *const kBCOVCatalogJSONKeyTypeEnum;
	[Field ("kBCOVCatalogJSONKeyTypeEnum", "__Internal")]
	NSString kBCOVCatalogJSONKeyTypeEnum { get; }

	// extern NSString *const kBCOVCatalogJSONKeyVideoDuration;
	[Field ("kBCOVCatalogJSONKeyVideoDuration", "__Internal")]
	NSString kBCOVCatalogJSONKeyVideoDuration { get; }

	// extern NSString *const kBCOVCatalogJSONKeyVideoStillUrl;
	[Field ("kBCOVCatalogJSONKeyVideoStillUrl", "__Internal")]
	NSString kBCOVCatalogJSONKeyVideoStillUrl { get; }

	// extern NSString *const kBCOVCatalogJSONKeyVideos;
	[Field ("kBCOVCatalogJSONKeyVideos", "__Internal")]
	NSString kBCOVCatalogJSONKeyVideos { get; }

	// extern NSString *const kBCOVCatalogURLParameterCommandKey;
	[Field ("kBCOVCatalogURLParameterCommandKey", "__Internal")]
	NSString kBCOVCatalogURLParameterCommandKey { get; }

	// extern NSString *const kBCOVCatalogURLParameterCommandValueFindPlaylistById;
	[Field ("kBCOVCatalogURLParameterCommandValueFindPlaylistById", "__Internal")]
	NSString kBCOVCatalogURLParameterCommandValueFindPlaylistById { get; }

	// extern NSString *const kBCOVCatalogURLParameterCommandValueFindPlaylistByReference;
	[Field ("kBCOVCatalogURLParameterCommandValueFindPlaylistByReference", "__Internal")]
	NSString kBCOVCatalogURLParameterCommandValueFindPlaylistByReference { get; }

	// extern NSString *const kBCOVCatalogURLParameterCommandValueFindVideoById;
	[Field ("kBCOVCatalogURLParameterCommandValueFindVideoById", "__Internal")]
	NSString kBCOVCatalogURLParameterCommandValueFindVideoById { get; }

	// extern NSString *const kBCOVCatalogURLParameterCommandValueFindVideoByReference;
	[Field ("kBCOVCatalogURLParameterCommandValueFindVideoByReference", "__Internal")]
	NSString kBCOVCatalogURLParameterCommandValueFindVideoByReference { get; }

	// extern NSString *const kBCOVCatalogURLParameterMediaDeliveryKey;
	[Field ("kBCOVCatalogURLParameterMediaDeliveryKey", "__Internal")]
	NSString kBCOVCatalogURLParameterMediaDeliveryKey { get; }

	// extern NSString *const kBCOVCatalogURLParameterMediaDeliveryValueHTTP;
	[Field ("kBCOVCatalogURLParameterMediaDeliveryValueHTTP", "__Internal")]
	NSString kBCOVCatalogURLParameterMediaDeliveryValueHTTP { get; }

	// extern NSString *const kBCOVCatalogURLParameterMediaDeliveryValueHTTPIOS;
	[Field ("kBCOVCatalogURLParameterMediaDeliveryValueHTTPIOS", "__Internal")]
	NSString kBCOVCatalogURLParameterMediaDeliveryValueHTTPIOS { get; }

	// extern NSString *const kBCOVCatalogURLParameterPlaylistIdKey;
	[Field ("kBCOVCatalogURLParameterPlaylistIdKey", "__Internal")]
	NSString kBCOVCatalogURLParameterPlaylistIdKey { get; }

	// extern NSString *const kBCOVCatalogURLParameterReferenceIdKey;
	[Field ("kBCOVCatalogURLParameterReferenceIdKey", "__Internal")]
	NSString kBCOVCatalogURLParameterReferenceIdKey { get; }

	// extern NSString *const kBCOVCatalogURLParameterTokenKey;
	[Field ("kBCOVCatalogURLParameterTokenKey", "__Internal")]
	NSString kBCOVCatalogURLParameterTokenKey { get; }

	// extern NSString *const kBCOVCatalogURLParameterVideoFieldsKey;
	[Field ("kBCOVCatalogURLParameterVideoFieldsKey", "__Internal")]
	NSString kBCOVCatalogURLParameterVideoFieldsKey { get; }

	// extern NSString *const kBCOVCatalogURLParameterVideoIdKey;
	[Field ("kBCOVCatalogURLParameterVideoIdKey", "__Internal")]
	NSString kBCOVCatalogURLParameterVideoIdKey { get; }

	// extern NSString *const kBCOVCatalogServiceErrorDomain;
	[Field ("kBCOVCatalogServiceErrorDomain", "__Internal")]
	NSString kBCOVCatalogServiceErrorDomain { get; }

	// extern const NSInteger kBCOVCatalogServiceErrorCodeMediaAPIError;
	[Field ("kBCOVCatalogServiceErrorCodeMediaAPIError", "__Internal")]
	nint kBCOVCatalogServiceErrorCodeMediaAPIError { get; }

	// extern NSString *const kBCOVCatalogErrorRequestKey;
	[Field ("kBCOVCatalogErrorRequestKey", "__Internal")]
	NSString kBCOVCatalogErrorRequestKey { get; }

	// extern NSString *const kBCOVCatalogJSONDeserializationErrorRawDataKey;
	[Field ("kBCOVCatalogJSONDeserializationErrorRawDataKey", "__Internal")]
	NSString kBCOVCatalogJSONDeserializationErrorRawDataKey { get; }

	// extern NSString *const kBCOVSourceDeliveryHLS;
	[Field ("kBCOVSourceDeliveryHLS", "__Internal")]
	NSString kBCOVSourceDeliveryHLS { get; }

	// extern NSString *const kBCOVSourceDeliveryMP4;
	[Field ("kBCOVSourceDeliveryMP4", "__Internal")]
	NSString kBCOVSourceDeliveryMP4 { get; }

	// extern NSString *const kBCOVVideoPropertyKeyAccountId;
	[Field ("kBCOVVideoPropertyKeyAccountId", "__Internal")]
	NSString kBCOVVideoPropertyKeyAccountId { get; }

	// extern NSString *const kBCOVVideoPropertyKeyName;
	[Field ("kBCOVVideoPropertyKeyName", "__Internal")]
	NSString kBCOVVideoPropertyKeyName { get; }

	// extern NSString *const kBCOVVideoPropertyKeyId;
	[Field ("kBCOVVideoPropertyKeyId", "__Internal")]
	NSString kBCOVVideoPropertyKeyId { get; }
}

// typedef UIView * (^BCOVPlaybackControllerViewStrategy)(UIView *, id<BCOVPlaybackController>);
delegate UIView BCOVPlaybackControllerViewStrategy (UIView arg0, BCOVPlaybackController arg1);

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern NSString *const kBCOVPlaybackServiceErrorDomain;
	[Field ("kBCOVPlaybackServiceErrorDomain", "__Internal")]
	NSString kBCOVPlaybackServiceErrorDomain { get; }

	// extern NSString *const kBCOVPlaybackServiceErrorKeyRawResponseData;
	[Field ("kBCOVPlaybackServiceErrorKeyRawResponseData", "__Internal")]
	NSString kBCOVPlaybackServiceErrorKeyRawResponseData { get; }

	// extern NSString *const kBCOVPlaybackServiceErrorKeyAPIErrors;
	[Field ("kBCOVPlaybackServiceErrorKeyAPIErrors", "__Internal")]
	NSString kBCOVPlaybackServiceErrorKeyAPIErrors { get; }

	// extern NSString *const kBCOVPlaybackServiceErrorKeyAPIHTTPStatusCode;
	[Field ("kBCOVPlaybackServiceErrorKeyAPIHTTPStatusCode", "__Internal")]
	NSString kBCOVPlaybackServiceErrorKeyAPIHTTPStatusCode { get; }

	// extern NSString *const kBCOVPlaybackSessionLifecycleEventReady;
	[Field ("kBCOVPlaybackSessionLifecycleEventReady", "__Internal")]
	NSString kBCOVPlaybackSessionLifecycleEventReady { get; }

	// extern NSString *const kBCOVPlaybackSessionLifecycleEventPlay;
	[Field ("kBCOVPlaybackSessionLifecycleEventPlay", "__Internal")]
	NSString kBCOVPlaybackSessionLifecycleEventPlay { get; }

	// extern NSString *const kBCOVPlaybackSessionLifecycleEventPause;
	[Field ("kBCOVPlaybackSessionLifecycleEventPause", "__Internal")]
	NSString kBCOVPlaybackSessionLifecycleEventPause { get; }

	// extern NSString *const kBCOVPlaybackSessionLifecycleEventFailedToPlayToEndTime;
	[Field ("kBCOVPlaybackSessionLifecycleEventFailedToPlayToEndTime", "__Internal")]
	NSString kBCOVPlaybackSessionLifecycleEventFailedToPlayToEndTime { get; }

	// extern NSString *const kBCOVPlaybackSessionLifecycleEventResumeBegin;
	[Field ("kBCOVPlaybackSessionLifecycleEventResumeBegin", "__Internal")]
	NSString kBCOVPlaybackSessionLifecycleEventResumeBegin { get; }

	// extern NSString *const kBCOVPlaybackSessionLifecycleEventResumeComplete;
	[Field ("kBCOVPlaybackSessionLifecycleEventResumeComplete", "__Internal")]
	NSString kBCOVPlaybackSessionLifecycleEventResumeComplete { get; }

	// extern NSString *const kBCOVPlaybackSessionLifecycleEventResumeFail;
	[Field ("kBCOVPlaybackSessionLifecycleEventResumeFail", "__Internal")]
	NSString kBCOVPlaybackSessionLifecycleEventResumeFail { get; }

	// extern NSString *const kBCOVPlaybackSessionLifecycleEventEnd;
	[Field ("kBCOVPlaybackSessionLifecycleEventEnd", "__Internal")]
	NSString kBCOVPlaybackSessionLifecycleEventEnd { get; }

	// extern NSString *const kBCOVPlaybackSessionLifecycleEventTerminate;
	[Field ("kBCOVPlaybackSessionLifecycleEventTerminate", "__Internal")]
	NSString kBCOVPlaybackSessionLifecycleEventTerminate { get; }

	// extern NSString *const kBCOVPlaybackSessionLifecycleEventFail;
	[Field ("kBCOVPlaybackSessionLifecycleEventFail", "__Internal")]
	NSString kBCOVPlaybackSessionLifecycleEventFail { get; }

	// extern NSString *const kBCOVPlaybackSessionEventKeyPreviousTime;
	[Field ("kBCOVPlaybackSessionEventKeyPreviousTime", "__Internal")]
	NSString kBCOVPlaybackSessionEventKeyPreviousTime { get; }

	// extern NSString *const kBCOVPlaybackSessionEventKeyCurrentTime;
	[Field ("kBCOVPlaybackSessionEventKeyCurrentTime", "__Internal")]
	NSString kBCOVPlaybackSessionEventKeyCurrentTime { get; }

	// extern NSString *const kBCOVPlaybackSessionEventKeyCuePoints;
	[Field ("kBCOVPlaybackSessionEventKeyCuePoints", "__Internal")]
	NSString kBCOVPlaybackSessionEventKeyCuePoints { get; }

	// extern NSString *const kBCOVPlaybackSessionErrorDomain;
	[Field ("kBCOVPlaybackSessionErrorDomain", "__Internal")]
	NSString kBCOVPlaybackSessionErrorDomain { get; }

	// extern const NSInteger kBCOVPlaybackSessionErrorCodeLoadFailed;
	[Field ("kBCOVPlaybackSessionErrorCodeLoadFailed", "__Internal")]
	nint kBCOVPlaybackSessionErrorCodeLoadFailed { get; }
}

//
//  AnalySDKUnity3DBridge.m
//  Unity-iPhone
//
//  Created by 陈剑东 on 2018/1/16.
//

#import "AnalySDKUnity3DBridge.h"
#import <MOBFoundation/MOBFJson.h>
#import <AnalySDK/AnalySDK.h>
#import <CoreLocation/CoreLocation.h>

#if defined (__cplusplus)
extern "C" {
#endif

    extern void __iosAnalySDKtrackEvent (void *eventName, void *eventsInfo);
    
    extern void __iosAnalySDKSetLocation (float latitude, float longitude);
    
    extern void __iosAnalySDKUserRegist (void *eventsInfo);
    
    extern void __iosAnalySDKUserLogin (void *eventsInfo);
    
    extern void __iosAnalySDKUserUpdate (void *eventsInfo);
    
    extern void __iosAnalySDKRoleCreate (void *eventsInfo);
    
    extern void __iosAnalySDKRoleLogin (void *eventsInfo);
    
    extern void __iosAnalySDKRoleUpdate (void *eventsInfo);
    
    extern void __iosAnalySDKTrackPayEvent (void *eventsInfo);

    extern void __iosAnalySDKtrackEvent (void *eventName, void *eventsInfo)
    {
        NSString *event = [NSString stringWithCString:eventName encoding:NSUTF8StringEncoding];
        NSString *theParamsStr = [NSString stringWithCString:eventsInfo encoding:NSUTF8StringEncoding];
        NSDictionary *eventParams = [MOBFJson objectFromJSONString:theParamsStr];
        
        [AnalySDK trackEvent:event eventParams:eventParams];
    }
    
    void __iosAnalySDKSetLocation (float latitude, float longitude)
    {
        CLLocation *location = [[CLLocation alloc] initWithLatitude:latitude longitude:longitude];
        [AnalySDK setLocation:location];
    }
    
    void __iosAnalySDKUserRegist (void *eventsInfo)
    {
        NSString *theParamsStr = [NSString stringWithCString:eventsInfo encoding:NSUTF8StringEncoding];
        NSDictionary *eventParams = [MOBFJson objectFromJSONString:theParamsStr];
        
        NSString *userId = eventParams[@"_userId"];
        ALSDKUser *user = [ALSDKUser userWithId:userId];
        
        user.nickName = eventParams[@"nickName"];
        
        
    }

    void __iosAnalySDKUserLogin (void *eventsInfo)
    {
        
    }
    
    void __iosAnalySDKUserUpdate (void *eventsInfo)
    {
        
    }
    
    void __iosAnalySDKRoleCreate (void *eventsInfo)
    {
        
    }
    
    void __iosAnalySDKRoleLogin (void *eventsInfo)
    {
        
    }
    
    void __iosAnalySDKRoleUpdate (void *eventsInfo)
    {
        
    }
    
    void __iosAnalySDKTrackPayEvent (void *eventsInfo)
    {
        
    }
    

#if defined (__cplusplus)
}
#endif

@implementation AnalySDKUnity3DBridge

@end

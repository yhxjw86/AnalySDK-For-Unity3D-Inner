//
//  IMOBFAnalyComponent.h
//  AnalySDK
//
//  Created by 陈剑东 on 2017/9/14.
//  Copyright © 2017年 Mob. All rights reserved.
//


#import <MOBFoundation/IMOBFServiceComponent.h>
#import "IMOBFAnalyUser.h"

@protocol IMOBFAnalyComponent <IMOBFServiceComponent>

/**
 *  事件追踪
 *
 *  @param eventName 事件名称
 *  @param params    事件属性
 */
+ (void)trackEvent:(NSString *)eventName eventParams:(NSDictionary *)params;


/**
 *  设置地理位置信息(一旦设置,则事件的追踪均带上此地理信息;否则不带)
 *
 *  @param location 地理位置
 */
+ (void)setLocation:(CLLocation *)location;

@end








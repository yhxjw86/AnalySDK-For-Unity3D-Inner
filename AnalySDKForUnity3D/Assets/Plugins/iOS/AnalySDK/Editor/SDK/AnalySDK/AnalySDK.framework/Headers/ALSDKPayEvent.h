//
//  ALSDKPayEvent.h
//  AnalySDK
//
//  Created by 陈剑东 on 2018/1/25.
//  Copyright © 2018年 Mob. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface ALSDKPayEvent : NSObject

@property (nonatomic, strong) NSNumber *payMoney;

@property (nonatomic, copy) NSString *payContent;

@property (nonatomic, copy) NSString *payType;

@property (nonatomic, copy) NSString *payActivity;

@property (nonatomic, strong) NSNumber *payDiscount;

@property (nonatomic, copy) NSString *discountReason;

/**
 *  其他自定义属性
 */
@property (nonatomic, strong) NSDictionary *customProperties;

@end

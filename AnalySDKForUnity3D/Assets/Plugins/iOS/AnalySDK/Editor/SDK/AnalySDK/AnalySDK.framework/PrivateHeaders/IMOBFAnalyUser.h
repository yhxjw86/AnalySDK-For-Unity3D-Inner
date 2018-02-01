//
//  IMOBFAnalyUser.h
//  AnalySDK
//
//  Created by 陈剑东 on 2017/9/14.
//  Copyright © 2017年 Mob. All rights reserved.
//

@protocol IMOBFAnalyUser <NSObject>

/**
 用户id(必传属性)
 */
@property (nonatomic, copy) NSString *userId;

/**
 注册方式
 */
@property (nonatomic, copy) NSString *regType;

/**
 注册渠道
 */
@property (nonatomic, copy) NSArray *regChannel;

/**
 登陆方式
 */
@property (nonatomic, copy) NSString *loginType;

/**
 登陆渠道
 */
@property (nonatomic, copy) NSArray *loginChannel;

/**
 账号类型
 */
@property (nonatomic, copy) NSString *userType;

/**
 防沉迷标识
 */
@property (nonatomic, copy) NSString *addiction;

/**
 账号通用货币
 */
@property (nonatomic) float money;

/**
 *  性别
 */
@property (nonatomic, copy) NSString *gender;

/**
 *  国家
 */
@property (nonatomic, copy) NSString *country;

/**
 *  省份
 */
@property (nonatomic, copy) NSString *province;

/**
 *  城市
 */
@property (nonatomic, copy) NSString *city;

/**
 年龄
 */
@property (nonatomic) NSInteger age;

/**
 星座
 */
@property (nonatomic, copy) NSString *constellation;

/**
 生肖
 */
@property (nonatomic, copy) NSString *zodiac;

/**
 *  其他自定义属性
 */
@property (nonatomic, strong) NSDictionary *customProperties;


@end


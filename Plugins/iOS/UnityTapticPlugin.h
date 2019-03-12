// Haptic Touch Unity3D Plugin
// Vladislav Khartanovich
// vmchar@outlook.com

#ifndef UnityTapticPlugin_h
#define UnityTapticPlugin_h

#import <UIKit/UIKit.h>


@interface UnityTapticPlugin : NSObject{

}

+ (UnityTapticPlugin*) shared;
+ (BOOL) isSupport;

- (void) notification:(UINotificationFeedbackType) type;
- (void) selection;
- (void) impact:(UIImpactFeedbackStyle) style;

@end

#endif /* UnityTapticPlugin_h */

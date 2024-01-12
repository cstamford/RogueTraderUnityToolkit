namespace RogueTraderUnityToolkit.UnityGenerated.Types.Engine;

using Core;
using System.Text;
using Unity;

/* $PlayerSettings (158 fields) PlayerSettings D2D3AF88ADFC2C6F3B5555C4959F094D */
public record class PlayerSettings (
    GUID productGUID,
    bool AndroidProfiler,
    bool AndroidFilterTouchesWhenObscured,
    bool AndroidEnableSustainedPerformanceMode,
    int defaultScreenOrientation,
    int targetDevice,
    bool useOnDemandResources,
    int accelerometerFrequency,
    AsciiString companyName,
    AsciiString productName,
    PPtr<Texture2D> defaultCursor,
    Vector2f cursorHotspot,
    ColorRGBA_1 m_SplashScreenBackgroundColor,
    bool m_ShowUnitySplashScreen,
    bool m_ShowUnitySplashLogo,
    float m_SplashScreenOverlayOpacity,
    int m_SplashScreenAnimation,
    int m_SplashScreenLogoStyle,
    int m_SplashScreenDrawMode,
    float m_SplashScreenBackgroundAnimationZoom,
    float m_SplashScreenLogoAnimationZoom,
    float m_SplashScreenBackgroundLandscapeAspect,
    float m_SplashScreenBackgroundPortraitAspect,
    Rectf m_SplashScreenBackgroundLandscapeUvs,
    Rectf m_SplashScreenBackgroundPortraitUvs,
    SplashScreenLogo[] m_SplashScreenLogos,
    PPtr<Texture2D> m_SplashScreenBackgroundLandscape,
    PPtr<Texture2D> m_SplashScreenBackgroundPortrait,
    PPtr<Sprite> m_UnitySplashLogo,
    PPtr<Texture2D> m_VirtualRealitySplashScreen,
    PPtr<Texture2D> m_HolographicTrackingLossScreen,
    int defaultScreenWidth,
    int defaultScreenHeight,
    int defaultScreenWidthWeb,
    int defaultScreenHeightWeb,
    int m_StereoRenderingPath,
    int m_ActiveColorSpace,
    int m_SpriteBatchVertexThreshold,
    bool m_MTRendering,
    bool mobileMTRenderingBaked,
    Hash128 AID,
    int playerMinOpenGLESVersion,
    bool mipStripping,
    int numberOfMipsStripped,
    Dictionary<AsciiString, int> numberOfMipsStrippedPerMipmapLimitGroup,
    int[] m_StackTraceTypes,
    int iosShowActivityIndicatorOnLoading,
    int androidShowActivityIndicatorOnLoading,
    bool iosUseCustomAppBackgroundBehavior,
    bool allowedAutorotateToPortrait,
    bool allowedAutorotateToPortraitUpsideDown,
    bool allowedAutorotateToLandscapeRight,
    bool allowedAutorotateToLandscapeLeft,
    bool useOSAutorotation,
    bool use32BitDisplayBuffer,
    bool preserveFramebufferAlpha,
    bool disableDepthAndStencilBuffers,
    bool androidStartInFullscreen,
    bool androidRenderOutsideSafeArea,
    bool androidUseSwappy,
    int androidBlitType,
    bool androidResizableWindow,
    int androidDefaultWindowWidth,
    int androidDefaultWindowHeight,
    int androidMinimumWindowWidth,
    int androidMinimumWindowHeight,
    int androidFullscreenMode,
    bool defaultIsNativeResolution,
    bool macRetinaSupport,
    bool runInBackground,
    bool captureSingleScreen,
    bool muteOtherAudioSources,
    bool Prepare_IOS_For_Recording,
    bool Force_IOS_Speakers_When_Recording,
    int deferSystemGesturesMode,
    bool hideHomeButton,
    bool submitAnalytics,
    bool usePlayerLog,
    bool bakeCollisionMeshes,
    bool forceSingleInstance,
    bool useFlipModelSwapchain,
    bool resizableWindow,
    bool useMacAppStoreValidation,
    AsciiString macAppStoreCategory,
    bool gpuSkinning,
    bool xboxPIXTextureCapture,
    bool xboxEnableAvatar,
    bool xboxEnableKinect,
    bool xboxEnableKinectAutoTracking,
    bool xboxEnableFitness,
    bool visibleInBackground,
    bool allowFullscreenSwitch,
    int fullscreenMode,
    uint xboxSpeechDB,
    bool xboxEnableHeadOrientation,
    bool xboxEnableGuest,
    bool xboxEnablePIXSampling,
    bool metalFramebufferOnly,
    int xboxOneResolution,
    int xboxOneSResolution,
    int xboxOneXResolution,
    int xboxOneMonoLoggingLevel,
    int xboxOneLoggingLevel,
    bool xboxOneDisableEsram,
    bool xboxOneEnableTypeOptimization,
    uint xboxOnePresentImmediateThreshold,
    int switchQueueCommandMemory,
    int switchQueueControlMemory,
    int switchQueueComputeMemory,
    int switchNVNShaderPoolsGranularity,
    int switchNVNDefaultPoolsGranularity,
    int switchNVNOtherPoolsGranularity,
    int switchGpuScratchPoolGranularity,
    bool switchAllowGpuScratchShrinking,
    int switchNVNMaxPublicTextureIDCount,
    int switchNVNMaxPublicSamplerIDCount,
    int switchNVNGraphicsFirmwareMemory,
    int stadiaPresentMode,
    int stadiaTargetFramerate,
    uint vulkanNumSwapchainBuffers,
    bool vulkanEnableSetSRGBWrite,
    bool vulkanEnablePreTransform,
    bool vulkanEnableLateAcquireNextImage,
    bool vulkanEnableCommandBufferRecycling,
    bool loadStoreDebugModeEnabled,
    PPtr<Texture2D> invalidatedPatternTexture,
    AsciiString bundleVersion,
    PPtr<Object>[] preloadedAssets,
    int metroInputSource,
    bool wsaTransparentSwapchain,
    bool m_HolographicPauseOnTrackingLoss,
    bool xboxOneDisableKinectGpuReservation,
    bool xboxOneEnable7thCore,
    VRSettings vrSettings,
    bool isWsaHolographicRemotingEnabled,
    bool enableFrameTimingStats,
    bool enableOpenGLProfilerGPURecorders,
    bool useHDRDisplay,
    int hdrBitDepth,
    int[] m_ColorGamuts,
    int targetPixelDensity,
    int resolutionScalingMode,
    bool resetResolutionOnWindowResize,
    int androidSupportedAspectRatio,
    float androidMaxAspectRatio,
    int activeInputHandler,
    int windowsGamepadBackendHint,
    AsciiString cloudProjectId,
    int framebufferDepthMemorylessMode,
    AsciiString[] qualitySettingsNames,
    AsciiString projectName,
    AsciiString organizationId,
    bool cloudEnabled,
    bool legacyClampBlendShapeWeights,
    PPtr<Texture2D> hmiLoadingImage,
    bool platformRequiresReadableAssets,
    bool virtualTexturingSupportEnabled,
    int insecureHttpOption) : IUnityEngineStructure
{
    public static UnityObjectType ObjectType => UnityObjectType.PlayerSettings;
    public static Hash128 Hash => new("D2D3AF88ADFC2C6F3B5555C4959F094D");
    public static PlayerSettings Read(EndianBinaryReader reader)
    {
        GUID productGUID_ = GUID.Read(reader);
        bool AndroidProfiler_ = reader.ReadBool();
        bool AndroidFilterTouchesWhenObscured_ = reader.ReadBool();
        bool AndroidEnableSustainedPerformanceMode_ = reader.ReadBool();
        reader.AlignTo(4); /* AndroidEnableSustainedPerformanceMode */
        int defaultScreenOrientation_ = reader.ReadS32();
        int targetDevice_ = reader.ReadS32();
        bool useOnDemandResources_ = reader.ReadBool();
        reader.AlignTo(4); /* useOnDemandResources */
        int accelerometerFrequency_ = reader.ReadS32();
        reader.AlignTo(4); /* accelerometerFrequency */
        AsciiString companyName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* companyName */
        AsciiString productName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* productName */
        PPtr<Texture2D> defaultCursor_ = PPtr<Texture2D>.Read(reader);
        Vector2f cursorHotspot_ = Vector2f.Read(reader);
        ColorRGBA_1 m_SplashScreenBackgroundColor_ = ColorRGBA_1.Read(reader);
        bool m_ShowUnitySplashScreen_ = reader.ReadBool();
        bool m_ShowUnitySplashLogo_ = reader.ReadBool();
        reader.AlignTo(4); /* m_ShowUnitySplashLogo */
        float m_SplashScreenOverlayOpacity_ = reader.ReadF32();
        int m_SplashScreenAnimation_ = reader.ReadS32();
        int m_SplashScreenLogoStyle_ = reader.ReadS32();
        int m_SplashScreenDrawMode_ = reader.ReadS32();
        reader.AlignTo(4); /* m_SplashScreenDrawMode */
        float m_SplashScreenBackgroundAnimationZoom_ = reader.ReadF32();
        float m_SplashScreenLogoAnimationZoom_ = reader.ReadF32();
        float m_SplashScreenBackgroundLandscapeAspect_ = reader.ReadF32();
        float m_SplashScreenBackgroundPortraitAspect_ = reader.ReadF32();
        Rectf m_SplashScreenBackgroundLandscapeUvs_ = Rectf.Read(reader);
        Rectf m_SplashScreenBackgroundPortraitUvs_ = Rectf.Read(reader);
        SplashScreenLogo[] m_SplashScreenLogos_ = BuiltInArray<SplashScreenLogo>.Read(reader);
        reader.AlignTo(4); /* m_SplashScreenLogos */
        PPtr<Texture2D> m_SplashScreenBackgroundLandscape_ = PPtr<Texture2D>.Read(reader);
        PPtr<Texture2D> m_SplashScreenBackgroundPortrait_ = PPtr<Texture2D>.Read(reader);
        PPtr<Sprite> m_UnitySplashLogo_ = PPtr<Sprite>.Read(reader);
        PPtr<Texture2D> m_VirtualRealitySplashScreen_ = PPtr<Texture2D>.Read(reader);
        reader.AlignTo(4); /* m_VirtualRealitySplashScreen */
        PPtr<Texture2D> m_HolographicTrackingLossScreen_ = PPtr<Texture2D>.Read(reader);
        int defaultScreenWidth_ = reader.ReadS32();
        int defaultScreenHeight_ = reader.ReadS32();
        int defaultScreenWidthWeb_ = reader.ReadS32();
        int defaultScreenHeightWeb_ = reader.ReadS32();
        int m_StereoRenderingPath_ = reader.ReadS32();
        int m_ActiveColorSpace_ = reader.ReadS32();
        int m_SpriteBatchVertexThreshold_ = reader.ReadS32();
        bool m_MTRendering_ = reader.ReadBool();
        bool mobileMTRenderingBaked_ = reader.ReadBool();
        Hash128 AID_ = Hash128.Read(reader);
        reader.AlignTo(4); /* AID */
        int playerMinOpenGLESVersion_ = reader.ReadS32();
        bool mipStripping_ = reader.ReadBool();
        reader.AlignTo(4); /* mipStripping */
        int numberOfMipsStripped_ = reader.ReadS32();
        Dictionary<AsciiString, int> numberOfMipsStrippedPerMipmapLimitGroup_ = BuiltInMap<AsciiString, int>.Read(reader);
        reader.AlignTo(4); /* numberOfMipsStrippedPerMipmapLimitGroup */
        int[] m_StackTraceTypes_ = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* m_StackTraceTypes */
        int iosShowActivityIndicatorOnLoading_ = reader.ReadS32();
        int androidShowActivityIndicatorOnLoading_ = reader.ReadS32();
        bool iosUseCustomAppBackgroundBehavior_ = reader.ReadBool();
        bool allowedAutorotateToPortrait_ = reader.ReadBool();
        bool allowedAutorotateToPortraitUpsideDown_ = reader.ReadBool();
        bool allowedAutorotateToLandscapeRight_ = reader.ReadBool();
        bool allowedAutorotateToLandscapeLeft_ = reader.ReadBool();
        bool useOSAutorotation_ = reader.ReadBool();
        bool use32BitDisplayBuffer_ = reader.ReadBool();
        bool preserveFramebufferAlpha_ = reader.ReadBool();
        bool disableDepthAndStencilBuffers_ = reader.ReadBool();
        bool androidStartInFullscreen_ = reader.ReadBool();
        bool androidRenderOutsideSafeArea_ = reader.ReadBool();
        bool androidUseSwappy_ = reader.ReadBool();
        reader.AlignTo(4); /* androidUseSwappy */
        int androidBlitType_ = reader.ReadS32();
        reader.AlignTo(4); /* androidBlitType */
        bool androidResizableWindow_ = reader.ReadBool();
        reader.AlignTo(4); /* androidResizableWindow */
        int androidDefaultWindowWidth_ = reader.ReadS32();
        int androidDefaultWindowHeight_ = reader.ReadS32();
        int androidMinimumWindowWidth_ = reader.ReadS32();
        int androidMinimumWindowHeight_ = reader.ReadS32();
        int androidFullscreenMode_ = reader.ReadS32();
        bool defaultIsNativeResolution_ = reader.ReadBool();
        bool macRetinaSupport_ = reader.ReadBool();
        bool runInBackground_ = reader.ReadBool();
        bool captureSingleScreen_ = reader.ReadBool();
        bool muteOtherAudioSources_ = reader.ReadBool();
        bool Prepare_IOS_For_Recording_ = reader.ReadBool();
        bool Force_IOS_Speakers_When_Recording_ = reader.ReadBool();
        reader.AlignTo(4); /* Force_IOS_Speakers_When_Recording */
        int deferSystemGesturesMode_ = reader.ReadS32();
        bool hideHomeButton_ = reader.ReadBool();
        bool submitAnalytics_ = reader.ReadBool();
        bool usePlayerLog_ = reader.ReadBool();
        bool bakeCollisionMeshes_ = reader.ReadBool();
        bool forceSingleInstance_ = reader.ReadBool();
        bool useFlipModelSwapchain_ = reader.ReadBool();
        bool resizableWindow_ = reader.ReadBool();
        bool useMacAppStoreValidation_ = reader.ReadBool();
        reader.AlignTo(4); /* useMacAppStoreValidation */
        AsciiString macAppStoreCategory_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* macAppStoreCategory */
        bool gpuSkinning_ = reader.ReadBool();
        bool xboxPIXTextureCapture_ = reader.ReadBool();
        bool xboxEnableAvatar_ = reader.ReadBool();
        bool xboxEnableKinect_ = reader.ReadBool();
        bool xboxEnableKinectAutoTracking_ = reader.ReadBool();
        bool xboxEnableFitness_ = reader.ReadBool();
        bool visibleInBackground_ = reader.ReadBool();
        bool allowFullscreenSwitch_ = reader.ReadBool();
        reader.AlignTo(4); /* allowFullscreenSwitch */
        int fullscreenMode_ = reader.ReadS32();
        reader.AlignTo(4); /* fullscreenMode */
        uint xboxSpeechDB_ = reader.ReadU32();
        bool xboxEnableHeadOrientation_ = reader.ReadBool();
        reader.AlignTo(4); /* xboxEnableHeadOrientation */
        bool xboxEnableGuest_ = reader.ReadBool();
        reader.AlignTo(4); /* xboxEnableGuest */
        bool xboxEnablePIXSampling_ = reader.ReadBool();
        reader.AlignTo(4); /* xboxEnablePIXSampling */
        bool metalFramebufferOnly_ = reader.ReadBool();
        reader.AlignTo(4); /* metalFramebufferOnly */
        int xboxOneResolution_ = reader.ReadS32();
        int xboxOneSResolution_ = reader.ReadS32();
        int xboxOneXResolution_ = reader.ReadS32();
        int xboxOneMonoLoggingLevel_ = reader.ReadS32();
        int xboxOneLoggingLevel_ = reader.ReadS32();
        bool xboxOneDisableEsram_ = reader.ReadBool();
        reader.AlignTo(4); /* xboxOneDisableEsram */
        bool xboxOneEnableTypeOptimization_ = reader.ReadBool();
        reader.AlignTo(4); /* xboxOneEnableTypeOptimization */
        uint xboxOnePresentImmediateThreshold_ = reader.ReadU32();
        int switchQueueCommandMemory_ = reader.ReadS32();
        int switchQueueControlMemory_ = reader.ReadS32();
        int switchQueueComputeMemory_ = reader.ReadS32();
        int switchNVNShaderPoolsGranularity_ = reader.ReadS32();
        int switchNVNDefaultPoolsGranularity_ = reader.ReadS32();
        int switchNVNOtherPoolsGranularity_ = reader.ReadS32();
        int switchGpuScratchPoolGranularity_ = reader.ReadS32();
        bool switchAllowGpuScratchShrinking_ = reader.ReadBool();
        reader.AlignTo(4); /* switchAllowGpuScratchShrinking */
        int switchNVNMaxPublicTextureIDCount_ = reader.ReadS32();
        int switchNVNMaxPublicSamplerIDCount_ = reader.ReadS32();
        int switchNVNGraphicsFirmwareMemory_ = reader.ReadS32();
        int stadiaPresentMode_ = reader.ReadS32();
        int stadiaTargetFramerate_ = reader.ReadS32();
        reader.AlignTo(4); /* stadiaTargetFramerate */
        uint vulkanNumSwapchainBuffers_ = reader.ReadU32();
        bool vulkanEnableSetSRGBWrite_ = reader.ReadBool();
        bool vulkanEnablePreTransform_ = reader.ReadBool();
        bool vulkanEnableLateAcquireNextImage_ = reader.ReadBool();
        bool vulkanEnableCommandBufferRecycling_ = reader.ReadBool();
        reader.AlignTo(4); /* vulkanEnableCommandBufferRecycling */
        bool loadStoreDebugModeEnabled_ = reader.ReadBool();
        reader.AlignTo(4); /* loadStoreDebugModeEnabled */
        PPtr<Texture2D> invalidatedPatternTexture_ = PPtr<Texture2D>.Read(reader);
        reader.AlignTo(4); /* invalidatedPatternTexture */
        AsciiString bundleVersion_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* bundleVersion */
        PPtr<Object>[] preloadedAssets_ = BuiltInArray<PPtr<Object>>.Read(reader);
        reader.AlignTo(4); /* preloadedAssets */
        int metroInputSource_ = reader.ReadS32();
        bool wsaTransparentSwapchain_ = reader.ReadBool();
        reader.AlignTo(4); /* wsaTransparentSwapchain */
        bool m_HolographicPauseOnTrackingLoss_ = reader.ReadBool();
        bool xboxOneDisableKinectGpuReservation_ = reader.ReadBool();
        bool xboxOneEnable7thCore_ = reader.ReadBool();
        reader.AlignTo(4); /* xboxOneEnable7thCore */
        VRSettings vrSettings_ = VRSettings.Read(reader);
        reader.AlignTo(4); /* vrSettings */
        bool isWsaHolographicRemotingEnabled_ = reader.ReadBool();
        reader.AlignTo(4); /* isWsaHolographicRemotingEnabled */
        bool enableFrameTimingStats_ = reader.ReadBool();
        bool enableOpenGLProfilerGPURecorders_ = reader.ReadBool();
        reader.AlignTo(4); /* enableOpenGLProfilerGPURecorders */
        bool useHDRDisplay_ = reader.ReadBool();
        reader.AlignTo(4); /* useHDRDisplay */
        int hdrBitDepth_ = reader.ReadS32();
        int[] m_ColorGamuts_ = BuiltInArray<int>.Read(reader);
        reader.AlignTo(4); /* m_ColorGamuts */
        int targetPixelDensity_ = reader.ReadS32();
        int resolutionScalingMode_ = reader.ReadS32();
        bool resetResolutionOnWindowResize_ = reader.ReadBool();
        reader.AlignTo(4); /* resetResolutionOnWindowResize */
        int androidSupportedAspectRatio_ = reader.ReadS32();
        float androidMaxAspectRatio_ = reader.ReadF32();
        reader.AlignTo(4); /* androidMaxAspectRatio */
        int activeInputHandler_ = reader.ReadS32();
        int windowsGamepadBackendHint_ = reader.ReadS32();
        AsciiString cloudProjectId_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* cloudProjectId */
        int framebufferDepthMemorylessMode_ = reader.ReadS32();
        AsciiString[] qualitySettingsNames_ = BuiltInArray<AsciiString>.Read(reader);
        reader.AlignTo(4); /* qualitySettingsNames */
        AsciiString projectName_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* projectName */
        AsciiString organizationId_ = BuiltInString.Read(reader);
        reader.AlignTo(4); /* organizationId */
        bool cloudEnabled_ = reader.ReadBool();
        bool legacyClampBlendShapeWeights_ = reader.ReadBool();
        reader.AlignTo(4); /* legacyClampBlendShapeWeights */
        PPtr<Texture2D> hmiLoadingImage_ = PPtr<Texture2D>.Read(reader);
        bool platformRequiresReadableAssets_ = reader.ReadBool();
        bool virtualTexturingSupportEnabled_ = reader.ReadBool();
        reader.AlignTo(4); /* virtualTexturingSupportEnabled */
        int insecureHttpOption_ = reader.ReadS32();
        
        return new(productGUID_,
            AndroidProfiler_,
            AndroidFilterTouchesWhenObscured_,
            AndroidEnableSustainedPerformanceMode_,
            defaultScreenOrientation_,
            targetDevice_,
            useOnDemandResources_,
            accelerometerFrequency_,
            companyName_,
            productName_,
            defaultCursor_,
            cursorHotspot_,
            m_SplashScreenBackgroundColor_,
            m_ShowUnitySplashScreen_,
            m_ShowUnitySplashLogo_,
            m_SplashScreenOverlayOpacity_,
            m_SplashScreenAnimation_,
            m_SplashScreenLogoStyle_,
            m_SplashScreenDrawMode_,
            m_SplashScreenBackgroundAnimationZoom_,
            m_SplashScreenLogoAnimationZoom_,
            m_SplashScreenBackgroundLandscapeAspect_,
            m_SplashScreenBackgroundPortraitAspect_,
            m_SplashScreenBackgroundLandscapeUvs_,
            m_SplashScreenBackgroundPortraitUvs_,
            m_SplashScreenLogos_,
            m_SplashScreenBackgroundLandscape_,
            m_SplashScreenBackgroundPortrait_,
            m_UnitySplashLogo_,
            m_VirtualRealitySplashScreen_,
            m_HolographicTrackingLossScreen_,
            defaultScreenWidth_,
            defaultScreenHeight_,
            defaultScreenWidthWeb_,
            defaultScreenHeightWeb_,
            m_StereoRenderingPath_,
            m_ActiveColorSpace_,
            m_SpriteBatchVertexThreshold_,
            m_MTRendering_,
            mobileMTRenderingBaked_,
            AID_,
            playerMinOpenGLESVersion_,
            mipStripping_,
            numberOfMipsStripped_,
            numberOfMipsStrippedPerMipmapLimitGroup_,
            m_StackTraceTypes_,
            iosShowActivityIndicatorOnLoading_,
            androidShowActivityIndicatorOnLoading_,
            iosUseCustomAppBackgroundBehavior_,
            allowedAutorotateToPortrait_,
            allowedAutorotateToPortraitUpsideDown_,
            allowedAutorotateToLandscapeRight_,
            allowedAutorotateToLandscapeLeft_,
            useOSAutorotation_,
            use32BitDisplayBuffer_,
            preserveFramebufferAlpha_,
            disableDepthAndStencilBuffers_,
            androidStartInFullscreen_,
            androidRenderOutsideSafeArea_,
            androidUseSwappy_,
            androidBlitType_,
            androidResizableWindow_,
            androidDefaultWindowWidth_,
            androidDefaultWindowHeight_,
            androidMinimumWindowWidth_,
            androidMinimumWindowHeight_,
            androidFullscreenMode_,
            defaultIsNativeResolution_,
            macRetinaSupport_,
            runInBackground_,
            captureSingleScreen_,
            muteOtherAudioSources_,
            Prepare_IOS_For_Recording_,
            Force_IOS_Speakers_When_Recording_,
            deferSystemGesturesMode_,
            hideHomeButton_,
            submitAnalytics_,
            usePlayerLog_,
            bakeCollisionMeshes_,
            forceSingleInstance_,
            useFlipModelSwapchain_,
            resizableWindow_,
            useMacAppStoreValidation_,
            macAppStoreCategory_,
            gpuSkinning_,
            xboxPIXTextureCapture_,
            xboxEnableAvatar_,
            xboxEnableKinect_,
            xboxEnableKinectAutoTracking_,
            xboxEnableFitness_,
            visibleInBackground_,
            allowFullscreenSwitch_,
            fullscreenMode_,
            xboxSpeechDB_,
            xboxEnableHeadOrientation_,
            xboxEnableGuest_,
            xboxEnablePIXSampling_,
            metalFramebufferOnly_,
            xboxOneResolution_,
            xboxOneSResolution_,
            xboxOneXResolution_,
            xboxOneMonoLoggingLevel_,
            xboxOneLoggingLevel_,
            xboxOneDisableEsram_,
            xboxOneEnableTypeOptimization_,
            xboxOnePresentImmediateThreshold_,
            switchQueueCommandMemory_,
            switchQueueControlMemory_,
            switchQueueComputeMemory_,
            switchNVNShaderPoolsGranularity_,
            switchNVNDefaultPoolsGranularity_,
            switchNVNOtherPoolsGranularity_,
            switchGpuScratchPoolGranularity_,
            switchAllowGpuScratchShrinking_,
            switchNVNMaxPublicTextureIDCount_,
            switchNVNMaxPublicSamplerIDCount_,
            switchNVNGraphicsFirmwareMemory_,
            stadiaPresentMode_,
            stadiaTargetFramerate_,
            vulkanNumSwapchainBuffers_,
            vulkanEnableSetSRGBWrite_,
            vulkanEnablePreTransform_,
            vulkanEnableLateAcquireNextImage_,
            vulkanEnableCommandBufferRecycling_,
            loadStoreDebugModeEnabled_,
            invalidatedPatternTexture_,
            bundleVersion_,
            preloadedAssets_,
            metroInputSource_,
            wsaTransparentSwapchain_,
            m_HolographicPauseOnTrackingLoss_,
            xboxOneDisableKinectGpuReservation_,
            xboxOneEnable7thCore_,
            vrSettings_,
            isWsaHolographicRemotingEnabled_,
            enableFrameTimingStats_,
            enableOpenGLProfilerGPURecorders_,
            useHDRDisplay_,
            hdrBitDepth_,
            m_ColorGamuts_,
            targetPixelDensity_,
            resolutionScalingMode_,
            resetResolutionOnWindowResize_,
            androidSupportedAspectRatio_,
            androidMaxAspectRatio_,
            activeInputHandler_,
            windowsGamepadBackendHint_,
            cloudProjectId_,
            framebufferDepthMemorylessMode_,
            qualitySettingsNames_,
            projectName_,
            organizationId_,
            cloudEnabled_,
            legacyClampBlendShapeWeights_,
            hmiLoadingImage_,
            platformRequiresReadableAssets_,
            virtualTexturingSupportEnabled_,
            insecureHttpOption_);
    }

    public override string ToString() => $"PlayerSettings\n{ToString(4)}";

    public string ToString(int indent)
    {
        StringBuilder sb = new();
        string indent_ = ' '.Repeat(indent);

        ToString_Field0(sb, indent, indent_);
        ToString_Field1(sb, indent, indent_);
        ToString_Field2(sb, indent, indent_);
        ToString_Field3(sb, indent, indent_);
        ToString_Field4(sb, indent, indent_);
        ToString_Field5(sb, indent, indent_);
        ToString_Field6(sb, indent, indent_);
        ToString_Field7(sb, indent, indent_);
        ToString_Field8(sb, indent, indent_);
        ToString_Field9(sb, indent, indent_);
        ToString_Field10(sb, indent, indent_);
        ToString_Field11(sb, indent, indent_);
        ToString_Field12(sb, indent, indent_);
        ToString_Field13(sb, indent, indent_);
        ToString_Field14(sb, indent, indent_);
        ToString_Field15(sb, indent, indent_);
        ToString_Field16(sb, indent, indent_);
        ToString_Field17(sb, indent, indent_);
        ToString_Field18(sb, indent, indent_);
        ToString_Field19(sb, indent, indent_);
        ToString_Field20(sb, indent, indent_);
        ToString_Field21(sb, indent, indent_);
        ToString_Field22(sb, indent, indent_);
        ToString_Field23(sb, indent, indent_);
        ToString_Field24(sb, indent, indent_);
        ToString_Field25(sb, indent, indent_);
        ToString_Field26(sb, indent, indent_);
        ToString_Field27(sb, indent, indent_);
        ToString_Field28(sb, indent, indent_);
        ToString_Field29(sb, indent, indent_);
        ToString_Field30(sb, indent, indent_);
        ToString_Field31(sb, indent, indent_);
        ToString_Field32(sb, indent, indent_);
        ToString_Field33(sb, indent, indent_);
        ToString_Field34(sb, indent, indent_);
        ToString_Field35(sb, indent, indent_);
        ToString_Field36(sb, indent, indent_);
        ToString_Field37(sb, indent, indent_);
        ToString_Field38(sb, indent, indent_);
        ToString_Field39(sb, indent, indent_);
        ToString_Field40(sb, indent, indent_);
        ToString_Field41(sb, indent, indent_);
        ToString_Field42(sb, indent, indent_);
        ToString_Field43(sb, indent, indent_);
        ToString_Field44(sb, indent, indent_);
        ToString_Field45(sb, indent, indent_);
        ToString_Field46(sb, indent, indent_);
        ToString_Field47(sb, indent, indent_);
        ToString_Field48(sb, indent, indent_);
        ToString_Field49(sb, indent, indent_);
        ToString_Field50(sb, indent, indent_);
        ToString_Field51(sb, indent, indent_);
        ToString_Field52(sb, indent, indent_);
        ToString_Field53(sb, indent, indent_);
        ToString_Field54(sb, indent, indent_);
        ToString_Field55(sb, indent, indent_);
        ToString_Field56(sb, indent, indent_);
        ToString_Field57(sb, indent, indent_);
        ToString_Field58(sb, indent, indent_);
        ToString_Field59(sb, indent, indent_);
        ToString_Field60(sb, indent, indent_);
        ToString_Field61(sb, indent, indent_);
        ToString_Field62(sb, indent, indent_);
        ToString_Field63(sb, indent, indent_);
        ToString_Field64(sb, indent, indent_);
        ToString_Field65(sb, indent, indent_);
        ToString_Field66(sb, indent, indent_);
        ToString_Field67(sb, indent, indent_);
        ToString_Field68(sb, indent, indent_);
        ToString_Field69(sb, indent, indent_);
        ToString_Field70(sb, indent, indent_);
        ToString_Field71(sb, indent, indent_);
        ToString_Field72(sb, indent, indent_);
        ToString_Field73(sb, indent, indent_);
        ToString_Field74(sb, indent, indent_);
        ToString_Field75(sb, indent, indent_);
        ToString_Field76(sb, indent, indent_);
        ToString_Field77(sb, indent, indent_);
        ToString_Field78(sb, indent, indent_);
        ToString_Field79(sb, indent, indent_);
        ToString_Field80(sb, indent, indent_);
        ToString_Field81(sb, indent, indent_);
        ToString_Field82(sb, indent, indent_);
        ToString_Field83(sb, indent, indent_);
        ToString_Field84(sb, indent, indent_);
        ToString_Field85(sb, indent, indent_);
        ToString_Field86(sb, indent, indent_);
        ToString_Field87(sb, indent, indent_);
        ToString_Field88(sb, indent, indent_);
        ToString_Field89(sb, indent, indent_);
        ToString_Field90(sb, indent, indent_);
        ToString_Field91(sb, indent, indent_);
        ToString_Field92(sb, indent, indent_);
        ToString_Field93(sb, indent, indent_);
        ToString_Field94(sb, indent, indent_);
        ToString_Field95(sb, indent, indent_);
        ToString_Field96(sb, indent, indent_);
        ToString_Field97(sb, indent, indent_);
        ToString_Field98(sb, indent, indent_);
        ToString_Field99(sb, indent, indent_);
        ToString_Field100(sb, indent, indent_);
        ToString_Field101(sb, indent, indent_);
        ToString_Field102(sb, indent, indent_);
        ToString_Field103(sb, indent, indent_);
        ToString_Field104(sb, indent, indent_);
        ToString_Field105(sb, indent, indent_);
        ToString_Field106(sb, indent, indent_);
        ToString_Field107(sb, indent, indent_);
        ToString_Field108(sb, indent, indent_);
        ToString_Field109(sb, indent, indent_);
        ToString_Field110(sb, indent, indent_);
        ToString_Field111(sb, indent, indent_);
        ToString_Field112(sb, indent, indent_);
        ToString_Field113(sb, indent, indent_);
        ToString_Field114(sb, indent, indent_);
        ToString_Field115(sb, indent, indent_);
        ToString_Field116(sb, indent, indent_);
        ToString_Field117(sb, indent, indent_);
        ToString_Field118(sb, indent, indent_);
        ToString_Field119(sb, indent, indent_);
        ToString_Field120(sb, indent, indent_);
        ToString_Field121(sb, indent, indent_);
        ToString_Field122(sb, indent, indent_);
        ToString_Field123(sb, indent, indent_);
        ToString_Field124(sb, indent, indent_);
        ToString_Field125(sb, indent, indent_);
        ToString_Field126(sb, indent, indent_);
        ToString_Field127(sb, indent, indent_);
        ToString_Field128(sb, indent, indent_);
        ToString_Field129(sb, indent, indent_);
        ToString_Field130(sb, indent, indent_);
        ToString_Field131(sb, indent, indent_);
        ToString_Field132(sb, indent, indent_);
        ToString_Field133(sb, indent, indent_);
        ToString_Field134(sb, indent, indent_);
        ToString_Field135(sb, indent, indent_);
        ToString_Field136(sb, indent, indent_);
        ToString_Field137(sb, indent, indent_);
        ToString_Field138(sb, indent, indent_);
        ToString_Field139(sb, indent, indent_);
        ToString_Field140(sb, indent, indent_);
        ToString_Field141(sb, indent, indent_);
        ToString_Field142(sb, indent, indent_);
        ToString_Field143(sb, indent, indent_);
        ToString_Field144(sb, indent, indent_);
        ToString_Field145(sb, indent, indent_);
        ToString_Field146(sb, indent, indent_);
        ToString_Field147(sb, indent, indent_);
        ToString_Field148(sb, indent, indent_);
        ToString_Field149(sb, indent, indent_);
        ToString_Field150(sb, indent, indent_);
        ToString_Field151(sb, indent, indent_);
        ToString_Field152(sb, indent, indent_);
        ToString_Field153(sb, indent, indent_);
        ToString_Field154(sb, indent, indent_);
        ToString_Field155(sb, indent, indent_);
        ToString_Field156(sb, indent, indent_);
        ToString_Field157(sb, indent, indent_);

        return sb.ToString();
    }

    public void ToString_Field0(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}productGUID: {{ data_0: {productGUID.data_0}, data_1: {productGUID.data_1}, data_2: {productGUID.data_2}, data_3: {productGUID.data_3} }}\n");
    }

    public void ToString_Field1(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}AndroidProfiler: {AndroidProfiler}");
    }

    public void ToString_Field2(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}AndroidFilterTouchesWhenObscured: {AndroidFilterTouchesWhenObscured}");
    }

    public void ToString_Field3(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}AndroidEnableSustainedPerformanceMode: {AndroidEnableSustainedPerformanceMode}");
    }

    public void ToString_Field4(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}defaultScreenOrientation: {defaultScreenOrientation}");
    }

    public void ToString_Field5(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}targetDevice: {targetDevice}");
    }

    public void ToString_Field6(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}useOnDemandResources: {useOnDemandResources}");
    }

    public void ToString_Field7(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}accelerometerFrequency: {accelerometerFrequency}");
    }

    public void ToString_Field8(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}companyName: \"{companyName}\"");
    }

    public void ToString_Field9(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}productName: \"{productName}\"");
    }

    public void ToString_Field10(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}defaultCursor: {defaultCursor}");
    }

    public void ToString_Field11(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}cursorHotspot: {{ x: {cursorHotspot.x}, y: {cursorHotspot.y} }}\n");
    }

    public void ToString_Field12(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SplashScreenBackgroundColor: {{ r: {m_SplashScreenBackgroundColor.r}, g: {m_SplashScreenBackgroundColor.g}, b: {m_SplashScreenBackgroundColor.b}, a: {m_SplashScreenBackgroundColor.a} }}\n");
    }

    public void ToString_Field13(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ShowUnitySplashScreen: {m_ShowUnitySplashScreen}");
    }

    public void ToString_Field14(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ShowUnitySplashLogo: {m_ShowUnitySplashLogo}");
    }

    public void ToString_Field15(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SplashScreenOverlayOpacity: {m_SplashScreenOverlayOpacity}");
    }

    public void ToString_Field16(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SplashScreenAnimation: {m_SplashScreenAnimation}");
    }

    public void ToString_Field17(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SplashScreenLogoStyle: {m_SplashScreenLogoStyle}");
    }

    public void ToString_Field18(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SplashScreenDrawMode: {m_SplashScreenDrawMode}");
    }

    public void ToString_Field19(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SplashScreenBackgroundAnimationZoom: {m_SplashScreenBackgroundAnimationZoom}");
    }

    public void ToString_Field20(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SplashScreenLogoAnimationZoom: {m_SplashScreenLogoAnimationZoom}");
    }

    public void ToString_Field21(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SplashScreenBackgroundLandscapeAspect: {m_SplashScreenBackgroundLandscapeAspect}");
    }

    public void ToString_Field22(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SplashScreenBackgroundPortraitAspect: {m_SplashScreenBackgroundPortraitAspect}");
    }

    public void ToString_Field23(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SplashScreenBackgroundLandscapeUvs: {{ x: {m_SplashScreenBackgroundLandscapeUvs.x}, y: {m_SplashScreenBackgroundLandscapeUvs.y}, width: {m_SplashScreenBackgroundLandscapeUvs.width}, height: {m_SplashScreenBackgroundLandscapeUvs.height} }}\n");
    }

    public void ToString_Field24(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SplashScreenBackgroundPortraitUvs: {{ x: {m_SplashScreenBackgroundPortraitUvs.x}, y: {m_SplashScreenBackgroundPortraitUvs.y}, width: {m_SplashScreenBackgroundPortraitUvs.width}, height: {m_SplashScreenBackgroundPortraitUvs.height} }}\n");
    }

    public void ToString_Field25(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_SplashScreenLogos[{m_SplashScreenLogos.Length}] = {{");
        if (m_SplashScreenLogos.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (SplashScreenLogo _4 in m_SplashScreenLogos)
        {
            sb.Append($"{indent_ + ' '.Repeat(4)}[{_4i}] = {{ \n{_4.ToString(indent+8)}{indent_ + ' '.Repeat(4)}}}\n");
            ++_4i;
        }
        if (m_SplashScreenLogos.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field26(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SplashScreenBackgroundLandscape: {m_SplashScreenBackgroundLandscape}");
    }

    public void ToString_Field27(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SplashScreenBackgroundPortrait: {m_SplashScreenBackgroundPortrait}");
    }

    public void ToString_Field28(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_UnitySplashLogo: {m_UnitySplashLogo}");
    }

    public void ToString_Field29(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_VirtualRealitySplashScreen: {m_VirtualRealitySplashScreen}");
    }

    public void ToString_Field30(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HolographicTrackingLossScreen: {m_HolographicTrackingLossScreen}");
    }

    public void ToString_Field31(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}defaultScreenWidth: {defaultScreenWidth}");
    }

    public void ToString_Field32(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}defaultScreenHeight: {defaultScreenHeight}");
    }

    public void ToString_Field33(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}defaultScreenWidthWeb: {defaultScreenWidthWeb}");
    }

    public void ToString_Field34(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}defaultScreenHeightWeb: {defaultScreenHeightWeb}");
    }

    public void ToString_Field35(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_StereoRenderingPath: {m_StereoRenderingPath}");
    }

    public void ToString_Field36(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_ActiveColorSpace: {m_ActiveColorSpace}");
    }

    public void ToString_Field37(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_SpriteBatchVertexThreshold: {m_SpriteBatchVertexThreshold}");
    }

    public void ToString_Field38(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_MTRendering: {m_MTRendering}");
    }

    public void ToString_Field39(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}mobileMTRenderingBaked: {mobileMTRenderingBaked}");
    }

    public void ToString_Field40(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}AID: {AID}");
    }

    public void ToString_Field41(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}playerMinOpenGLESVersion: {playerMinOpenGLESVersion}");
    }

    public void ToString_Field42(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}mipStripping: {mipStripping}");
    }

    public void ToString_Field43(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}numberOfMipsStripped: {numberOfMipsStripped}");
    }

    public void ToString_Field44(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}numberOfMipsStrippedPerMipmapLimitGroup[{numberOfMipsStrippedPerMipmapLimitGroup.Count}] = {{");
        if (numberOfMipsStrippedPerMipmapLimitGroup.Count > 0) sb.AppendLine();
        int _4i = 0;
        foreach (KeyValuePair<AsciiString, int> _4 in numberOfMipsStrippedPerMipmapLimitGroup)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[\"{_4.Key}\"] = {_4.Value}");
            ++_4i;
        }
        if (numberOfMipsStrippedPerMipmapLimitGroup.Count > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field45(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_StackTraceTypes[{m_StackTraceTypes.Length}] = {{");
        if (m_StackTraceTypes.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (int _4 in m_StackTraceTypes)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_StackTraceTypes.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field46(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}iosShowActivityIndicatorOnLoading: {iosShowActivityIndicatorOnLoading}");
    }

    public void ToString_Field47(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}androidShowActivityIndicatorOnLoading: {androidShowActivityIndicatorOnLoading}");
    }

    public void ToString_Field48(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}iosUseCustomAppBackgroundBehavior: {iosUseCustomAppBackgroundBehavior}");
    }

    public void ToString_Field49(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}allowedAutorotateToPortrait: {allowedAutorotateToPortrait}");
    }

    public void ToString_Field50(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}allowedAutorotateToPortraitUpsideDown: {allowedAutorotateToPortraitUpsideDown}");
    }

    public void ToString_Field51(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}allowedAutorotateToLandscapeRight: {allowedAutorotateToLandscapeRight}");
    }

    public void ToString_Field52(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}allowedAutorotateToLandscapeLeft: {allowedAutorotateToLandscapeLeft}");
    }

    public void ToString_Field53(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}useOSAutorotation: {useOSAutorotation}");
    }

    public void ToString_Field54(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}use32BitDisplayBuffer: {use32BitDisplayBuffer}");
    }

    public void ToString_Field55(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}preserveFramebufferAlpha: {preserveFramebufferAlpha}");
    }

    public void ToString_Field56(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}disableDepthAndStencilBuffers: {disableDepthAndStencilBuffers}");
    }

    public void ToString_Field57(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}androidStartInFullscreen: {androidStartInFullscreen}");
    }

    public void ToString_Field58(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}androidRenderOutsideSafeArea: {androidRenderOutsideSafeArea}");
    }

    public void ToString_Field59(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}androidUseSwappy: {androidUseSwappy}");
    }

    public void ToString_Field60(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}androidBlitType: {androidBlitType}");
    }

    public void ToString_Field61(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}androidResizableWindow: {androidResizableWindow}");
    }

    public void ToString_Field62(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}androidDefaultWindowWidth: {androidDefaultWindowWidth}");
    }

    public void ToString_Field63(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}androidDefaultWindowHeight: {androidDefaultWindowHeight}");
    }

    public void ToString_Field64(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}androidMinimumWindowWidth: {androidMinimumWindowWidth}");
    }

    public void ToString_Field65(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}androidMinimumWindowHeight: {androidMinimumWindowHeight}");
    }

    public void ToString_Field66(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}androidFullscreenMode: {androidFullscreenMode}");
    }

    public void ToString_Field67(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}defaultIsNativeResolution: {defaultIsNativeResolution}");
    }

    public void ToString_Field68(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}macRetinaSupport: {macRetinaSupport}");
    }

    public void ToString_Field69(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}runInBackground: {runInBackground}");
    }

    public void ToString_Field70(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}captureSingleScreen: {captureSingleScreen}");
    }

    public void ToString_Field71(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}muteOtherAudioSources: {muteOtherAudioSources}");
    }

    public void ToString_Field72(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}Prepare_IOS_For_Recording: {Prepare_IOS_For_Recording}");
    }

    public void ToString_Field73(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}Force_IOS_Speakers_When_Recording: {Force_IOS_Speakers_When_Recording}");
    }

    public void ToString_Field74(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}deferSystemGesturesMode: {deferSystemGesturesMode}");
    }

    public void ToString_Field75(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}hideHomeButton: {hideHomeButton}");
    }

    public void ToString_Field76(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}submitAnalytics: {submitAnalytics}");
    }

    public void ToString_Field77(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}usePlayerLog: {usePlayerLog}");
    }

    public void ToString_Field78(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}bakeCollisionMeshes: {bakeCollisionMeshes}");
    }

    public void ToString_Field79(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}forceSingleInstance: {forceSingleInstance}");
    }

    public void ToString_Field80(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}useFlipModelSwapchain: {useFlipModelSwapchain}");
    }

    public void ToString_Field81(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}resizableWindow: {resizableWindow}");
    }

    public void ToString_Field82(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}useMacAppStoreValidation: {useMacAppStoreValidation}");
    }

    public void ToString_Field83(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}macAppStoreCategory: \"{macAppStoreCategory}\"");
    }

    public void ToString_Field84(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}gpuSkinning: {gpuSkinning}");
    }

    public void ToString_Field85(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}xboxPIXTextureCapture: {xboxPIXTextureCapture}");
    }

    public void ToString_Field86(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}xboxEnableAvatar: {xboxEnableAvatar}");
    }

    public void ToString_Field87(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}xboxEnableKinect: {xboxEnableKinect}");
    }

    public void ToString_Field88(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}xboxEnableKinectAutoTracking: {xboxEnableKinectAutoTracking}");
    }

    public void ToString_Field89(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}xboxEnableFitness: {xboxEnableFitness}");
    }

    public void ToString_Field90(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}visibleInBackground: {visibleInBackground}");
    }

    public void ToString_Field91(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}allowFullscreenSwitch: {allowFullscreenSwitch}");
    }

    public void ToString_Field92(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}fullscreenMode: {fullscreenMode}");
    }

    public void ToString_Field93(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}xboxSpeechDB: {xboxSpeechDB}");
    }

    public void ToString_Field94(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}xboxEnableHeadOrientation: {xboxEnableHeadOrientation}");
    }

    public void ToString_Field95(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}xboxEnableGuest: {xboxEnableGuest}");
    }

    public void ToString_Field96(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}xboxEnablePIXSampling: {xboxEnablePIXSampling}");
    }

    public void ToString_Field97(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}metalFramebufferOnly: {metalFramebufferOnly}");
    }

    public void ToString_Field98(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}xboxOneResolution: {xboxOneResolution}");
    }

    public void ToString_Field99(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}xboxOneSResolution: {xboxOneSResolution}");
    }

    public void ToString_Field100(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}xboxOneXResolution: {xboxOneXResolution}");
    }

    public void ToString_Field101(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}xboxOneMonoLoggingLevel: {xboxOneMonoLoggingLevel}");
    }

    public void ToString_Field102(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}xboxOneLoggingLevel: {xboxOneLoggingLevel}");
    }

    public void ToString_Field103(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}xboxOneDisableEsram: {xboxOneDisableEsram}");
    }

    public void ToString_Field104(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}xboxOneEnableTypeOptimization: {xboxOneEnableTypeOptimization}");
    }

    public void ToString_Field105(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}xboxOnePresentImmediateThreshold: {xboxOnePresentImmediateThreshold}");
    }

    public void ToString_Field106(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}switchQueueCommandMemory: {switchQueueCommandMemory}");
    }

    public void ToString_Field107(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}switchQueueControlMemory: {switchQueueControlMemory}");
    }

    public void ToString_Field108(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}switchQueueComputeMemory: {switchQueueComputeMemory}");
    }

    public void ToString_Field109(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}switchNVNShaderPoolsGranularity: {switchNVNShaderPoolsGranularity}");
    }

    public void ToString_Field110(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}switchNVNDefaultPoolsGranularity: {switchNVNDefaultPoolsGranularity}");
    }

    public void ToString_Field111(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}switchNVNOtherPoolsGranularity: {switchNVNOtherPoolsGranularity}");
    }

    public void ToString_Field112(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}switchGpuScratchPoolGranularity: {switchGpuScratchPoolGranularity}");
    }

    public void ToString_Field113(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}switchAllowGpuScratchShrinking: {switchAllowGpuScratchShrinking}");
    }

    public void ToString_Field114(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}switchNVNMaxPublicTextureIDCount: {switchNVNMaxPublicTextureIDCount}");
    }

    public void ToString_Field115(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}switchNVNMaxPublicSamplerIDCount: {switchNVNMaxPublicSamplerIDCount}");
    }

    public void ToString_Field116(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}switchNVNGraphicsFirmwareMemory: {switchNVNGraphicsFirmwareMemory}");
    }

    public void ToString_Field117(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}stadiaPresentMode: {stadiaPresentMode}");
    }

    public void ToString_Field118(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}stadiaTargetFramerate: {stadiaTargetFramerate}");
    }

    public void ToString_Field119(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}vulkanNumSwapchainBuffers: {vulkanNumSwapchainBuffers}");
    }

    public void ToString_Field120(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}vulkanEnableSetSRGBWrite: {vulkanEnableSetSRGBWrite}");
    }

    public void ToString_Field121(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}vulkanEnablePreTransform: {vulkanEnablePreTransform}");
    }

    public void ToString_Field122(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}vulkanEnableLateAcquireNextImage: {vulkanEnableLateAcquireNextImage}");
    }

    public void ToString_Field123(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}vulkanEnableCommandBufferRecycling: {vulkanEnableCommandBufferRecycling}");
    }

    public void ToString_Field124(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}loadStoreDebugModeEnabled: {loadStoreDebugModeEnabled}");
    }

    public void ToString_Field125(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}invalidatedPatternTexture: {invalidatedPatternTexture}");
    }

    public void ToString_Field126(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}bundleVersion: \"{bundleVersion}\"");
    }

    public void ToString_Field127(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}preloadedAssets[{preloadedAssets.Length}] = {{");
        if (preloadedAssets.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (PPtr<Object> _4 in preloadedAssets)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (preloadedAssets.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field128(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}metroInputSource: {metroInputSource}");
    }

    public void ToString_Field129(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}wsaTransparentSwapchain: {wsaTransparentSwapchain}");
    }

    public void ToString_Field130(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}m_HolographicPauseOnTrackingLoss: {m_HolographicPauseOnTrackingLoss}");
    }

    public void ToString_Field131(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}xboxOneDisableKinectGpuReservation: {xboxOneDisableKinectGpuReservation}");
    }

    public void ToString_Field132(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}xboxOneEnable7thCore: {xboxOneEnable7thCore}");
    }

    public void ToString_Field133(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}vrSettings: {{ enable360StereoCapture: {vrSettings.enable360StereoCapture} }}\n");
    }

    public void ToString_Field134(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}isWsaHolographicRemotingEnabled: {isWsaHolographicRemotingEnabled}");
    }

    public void ToString_Field135(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enableFrameTimingStats: {enableFrameTimingStats}");
    }

    public void ToString_Field136(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}enableOpenGLProfilerGPURecorders: {enableOpenGLProfilerGPURecorders}");
    }

    public void ToString_Field137(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}useHDRDisplay: {useHDRDisplay}");
    }

    public void ToString_Field138(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}hdrBitDepth: {hdrBitDepth}");
    }

    public void ToString_Field139(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}m_ColorGamuts[{m_ColorGamuts.Length}] = {{");
        if (m_ColorGamuts.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (int _4 in m_ColorGamuts)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = {_4}");
            ++_4i;
        }
        if (m_ColorGamuts.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field140(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}targetPixelDensity: {targetPixelDensity}");
    }

    public void ToString_Field141(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}resolutionScalingMode: {resolutionScalingMode}");
    }

    public void ToString_Field142(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}resetResolutionOnWindowResize: {resetResolutionOnWindowResize}");
    }

    public void ToString_Field143(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}androidSupportedAspectRatio: {androidSupportedAspectRatio}");
    }

    public void ToString_Field144(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}androidMaxAspectRatio: {androidMaxAspectRatio}");
    }

    public void ToString_Field145(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}activeInputHandler: {activeInputHandler}");
    }

    public void ToString_Field146(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}windowsGamepadBackendHint: {windowsGamepadBackendHint}");
    }

    public void ToString_Field147(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}cloudProjectId: \"{cloudProjectId}\"");
    }

    public void ToString_Field148(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}framebufferDepthMemorylessMode: {framebufferDepthMemorylessMode}");
    }

    public void ToString_Field149(StringBuilder sb, int indent, string indent_)
    {
        sb.Append($"{indent_}qualitySettingsNames[{qualitySettingsNames.Length}] = {{");
        if (qualitySettingsNames.Length > 0) sb.AppendLine();
        int _4i = 0;
        foreach (AsciiString _4 in qualitySettingsNames)
        {
            sb.AppendLine($"{indent_ + ' '.Repeat(4)}[{_4i}] = \"{_4}\"");
            ++_4i;
        }
        if (qualitySettingsNames.Length > 0) sb.Append(indent_);
        sb.AppendLine("}");
    }

    public void ToString_Field150(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}projectName: \"{projectName}\"");
    }

    public void ToString_Field151(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}organizationId: \"{organizationId}\"");
    }

    public void ToString_Field152(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}cloudEnabled: {cloudEnabled}");
    }

    public void ToString_Field153(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}legacyClampBlendShapeWeights: {legacyClampBlendShapeWeights}");
    }

    public void ToString_Field154(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}hmiLoadingImage: {hmiLoadingImage}");
    }

    public void ToString_Field155(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}platformRequiresReadableAssets: {platformRequiresReadableAssets}");
    }

    public void ToString_Field156(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}virtualTexturingSupportEnabled: {virtualTexturingSupportEnabled}");
    }

    public void ToString_Field157(StringBuilder sb, int indent, string indent_)
    {
        sb.AppendLine($"{indent_}insecureHttpOption: {insecureHttpOption}");
    }
}


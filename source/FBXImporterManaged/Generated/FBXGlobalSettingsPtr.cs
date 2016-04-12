//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class FBXGlobalSettingsPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FBXGlobalSettingsPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FBXGlobalSettingsPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FBXGlobalSettingsPtr() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FBXImporterUnmanagedPINVOKE.delete_FBXGlobalSettingsPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FBXGlobalSettingsPtr() : this(FBXImporterUnmanagedPINVOKE.new_FBXGlobalSettingsPtr__SWIG_0(), true) {
  }

  public FBXGlobalSettingsPtr(FBXGlobalSettings p) : this(FBXImporterUnmanagedPINVOKE.new_FBXGlobalSettingsPtr__SWIG_1(FBXGlobalSettings.getCPtr(p)), true) {
  }

  public FBXGlobalSettingsPtr(FBXGlobalSettingsPtr other) : this(FBXImporterUnmanagedPINVOKE.new_FBXGlobalSettingsPtr__SWIG_2(FBXGlobalSettingsPtr.getCPtr(other)), true) {
    if (FBXImporterUnmanagedPINVOKE.SWIGPendingException.Pending) throw FBXImporterUnmanagedPINVOKE.SWIGPendingException.Retrieve();
  }

  public FBXGlobalSettings get() {
    global::System.IntPtr cPtr = FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_get(swigCPtr);
    FBXGlobalSettings ret = (cPtr == global::System.IntPtr.Zero) ? null : new FBXGlobalSettings(cPtr, false);
    return ret;
  }

  public FBXGlobalSettings __deref__() {
    global::System.IntPtr cPtr = FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr___deref__(swigCPtr);
    FBXGlobalSettings ret = (cPtr == global::System.IntPtr.Zero) ? null : new FBXGlobalSettings(cPtr, false);
    return ret;
  }

  public FBXGlobalSettings __ref__() {
    FBXGlobalSettings ret = new FBXGlobalSettings(FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr___ref__(swigCPtr), false);
    return ret;
  }

  public bool IsNull() {
    bool ret = FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_IsNull(swigCPtr);
    return ret;
  }

  public static FBXGlobalSettingsPtr Null {
    set {
      FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_Null_set(FBXGlobalSettingsPtr.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_Null_get();
      FBXGlobalSettingsPtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new FBXGlobalSettingsPtr(cPtr, false);
      return ret;
    } 
  }

  public float unitScaleFactor {
    set {
      FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_unitScaleFactor_set(swigCPtr, value);
    } 
    get {
      float ret = FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_unitScaleFactor_get(swigCPtr);
      return ret;
    } 
  }

  public float originalScaleFactor {
    set {
      FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_originalScaleFactor_set(swigCPtr, value);
    } 
    get {
      float ret = FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_originalScaleFactor_get(swigCPtr);
      return ret;
    } 
  }

  public FBXGlobalSettings.UpVector upVector {
    set {
      FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_upVector_set(swigCPtr, (int)value);
    } 
    get {
      FBXGlobalSettings.UpVector ret = (FBXGlobalSettings.UpVector)FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_upVector_get(swigCPtr);
      return ret;
    } 
  }

  public FBXGlobalSettings.UpVector originalUpVector {
    set {
      FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_originalUpVector_set(swigCPtr, (int)value);
    } 
    get {
      FBXGlobalSettings.UpVector ret = (FBXGlobalSettings.UpVector)FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_originalUpVector_get(swigCPtr);
      return ret;
    } 
  }

  public FBXGlobalSettings.FrontVector frontVector {
    set {
      FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_frontVector_set(swigCPtr, (int)value);
    } 
    get {
      FBXGlobalSettings.FrontVector ret = (FBXGlobalSettings.FrontVector)FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_frontVector_get(swigCPtr);
      return ret;
    } 
  }

  public FBXGlobalSettings.CoordinateSystem coordinateSystem {
    set {
      FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_coordinateSystem_set(swigCPtr, (int)value);
    } 
    get {
      FBXGlobalSettings.CoordinateSystem ret = (FBXGlobalSettings.CoordinateSystem)FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_coordinateSystem_get(swigCPtr);
      return ret;
    } 
  }

  public FBXGlobalSettingsPtr Create() {
    FBXGlobalSettingsPtr ret = new FBXGlobalSettingsPtr(FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_Create(swigCPtr), true);
    return ret;
  }

  public void SetUnitScaleFactor(float value) {
    FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_SetUnitScaleFactor(swigCPtr, value);
  }

  public void SetOriginalUnitScaleFactor(float value) {
    FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_SetOriginalUnitScaleFactor(swigCPtr, value);
  }

  public void SetUpVector(FBXGlobalSettings.UpVector value) {
    FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_SetUpVector(swigCPtr, (int)value);
  }

  public void SetOriginalUpVector(FBXGlobalSettings.UpVector value) {
    FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_SetOriginalUpVector(swigCPtr, (int)value);
  }

  public void SetFrontVector(FBXGlobalSettings.FrontVector value) {
    FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_SetFrontVector(swigCPtr, (int)value);
  }

  public void SetCoordinateSystem(FBXGlobalSettings.CoordinateSystem value) {
    FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_SetCoordinateSystem(swigCPtr, (int)value);
  }

  public float GetUnitScaleFactor() {
    float ret = FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_GetUnitScaleFactor(swigCPtr);
    return ret;
  }

  public float GetOriginalUnitScaleFactor() {
    float ret = FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_GetOriginalUnitScaleFactor(swigCPtr);
    return ret;
  }

  public FBXGlobalSettings.UpVector GetUpVector() {
    FBXGlobalSettings.UpVector ret = (FBXGlobalSettings.UpVector)FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_GetUpVector(swigCPtr);
    return ret;
  }

  public FBXGlobalSettings.UpVector GetOriginalUpVector() {
    FBXGlobalSettings.UpVector ret = (FBXGlobalSettings.UpVector)FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_GetOriginalUpVector(swigCPtr);
    return ret;
  }

  public FBXGlobalSettings.FrontVector GetFrontVector() {
    FBXGlobalSettings.FrontVector ret = (FBXGlobalSettings.FrontVector)FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_GetFrontVector(swigCPtr);
    return ret;
  }

  public FBXGlobalSettings.CoordinateSystem GetCoordinateSystem() {
    FBXGlobalSettings.CoordinateSystem ret = (FBXGlobalSettings.CoordinateSystem)FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_GetCoordinateSystem(swigCPtr);
    return ret;
  }

  public void addReference() {
    FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_addReference(swigCPtr);
  }

  public void removeReference() {
    FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_removeReference(swigCPtr);
  }

  public int getReferenceCount() {
    int ret = FBXImporterUnmanagedPINVOKE.FBXGlobalSettingsPtr_getReferenceCount(swigCPtr);
    return ret;
  }

}
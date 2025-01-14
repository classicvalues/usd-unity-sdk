//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class UsdStageLoadRulesPair : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdStageLoadRulesPair(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdStageLoadRulesPair obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdStageLoadRulesPair() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdStageLoadRulesPair(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public UsdStageLoadRulesPair() : this(UsdCsPINVOKE.new_UsdStageLoadRulesPair__SWIG_0(), true) {
  }

  public UsdStageLoadRulesPair(SdfPath t, UsdStageLoadRules.Rule u) : this(UsdCsPINVOKE.new_UsdStageLoadRulesPair__SWIG_1(SdfPath.getCPtr(t), (int)u), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdStageLoadRulesPair(UsdStageLoadRulesPair p) : this(UsdCsPINVOKE.new_UsdStageLoadRulesPair__SWIG_2(UsdStageLoadRulesPair.getCPtr(p)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SdfPath first {
    set {
      UsdCsPINVOKE.UsdStageLoadRulesPair_first_set(swigCPtr, SdfPath.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = UsdCsPINVOKE.UsdStageLoadRulesPair_first_get(swigCPtr);
      SdfPath ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfPath(cPtr, false);
      return ret;
    } 
  }

  public UsdStageLoadRules.Rule second {
    set {
      UsdCsPINVOKE.UsdStageLoadRulesPair_second_set(swigCPtr, (int)value);
    } 
    get {
      UsdStageLoadRules.Rule ret = (UsdStageLoadRules.Rule)UsdCsPINVOKE.UsdStageLoadRulesPair_second_get(swigCPtr);
      return ret;
    } 
  }

}

}
